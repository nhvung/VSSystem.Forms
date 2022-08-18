using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace VSSystem.Forms
{
    public partial class ConnectDatabaseDialog : Form
    {

        DBConnectionInfo _ConnectionInfo;
        public DBConnectionInfo ConnectionInfo { get { return _ConnectionInfo; } }

        DelegateProcess dlgProcess;

        FileInfo _rememberFile, _lastAuthFile;
        DBAuthentications _dBAuthentications;
        string _databaseQuery;
        DbConnection _connection;

        public ConnectDatabaseDialog(bool includeDatabase = false, string title = "")
        {
            InitializeComponent();
            _ConnectionInfo = new DBConnectionInfo();
            LoadDrivers();
            if (!string.IsNullOrEmpty(title))
            {
                Text = title;
            }

            but_connect.Visible = includeDatabase;
            lab_database.Visible = includeDatabase;
            com_database.Visible = includeDatabase;

            com_driver.Sorted = true;
            dlgProcess = new DelegateProcess();
            com_driver.SelectedIndexChanged += Com_driver_SelectedIndexChanged;
            com_username.SelectedIndexChanged += Com_username_SelectedIndexChanged;
            com_server.SelectedIndexChanged += Com_server_SelectedIndexChanged;

            _rememberFile = new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "auths.xml");
            if (_rememberFile.Exists)
            {
                _dBAuthentications = new DBAuthentications(_rememberFile.FullName);
                string[] servers = _dBAuthentications.Servers;
                if (servers.Length > 0)
                {
                    com_server.Items.AddRange(servers);
                    com_server.SelectedIndex = 0;
                }
                com_driver.Text = _dBAuthentications.LastDriver;
                com_server.Text = _dBAuthentications.LastServer;
                com_username.Text = _dBAuthentications.LastUsername;
                txt_password.Text = _dBAuthentications.LastPassword;
                txt_port.Text = _dBAuthentications.LastPort;
                com_database.Text = _dBAuthentications.LastDatabase;
                Com_driver_SelectedIndexChanged(null, null);
            }
            else
            {
                _dBAuthentications = new DBAuthentications();
                _dBAuthentications.Save(_rememberFile.FullName);
            }



            
           
        }

        public ConnectDatabaseDialog(string server, string username, string password, string database, string driver, bool includeDatabase = false)
        {
            InitializeComponent();
            _ConnectionInfo = new DBConnectionInfo();
            LoadDrivers();
            but_connect.Visible = includeDatabase;
            lab_database.Visible = includeDatabase;
            com_database.Visible = includeDatabase;

            com_driver.Sorted = true;
            dlgProcess = new DelegateProcess();
            com_driver.SelectedIndexChanged += Com_driver_SelectedIndexChanged;
            com_username.SelectedIndexChanged += Com_username_SelectedIndexChanged;
            com_server.SelectedIndexChanged += Com_server_SelectedIndexChanged;

            _rememberFile = new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "auths.xml");
            if (_rememberFile.Exists)
            {
                _dBAuthentications = new DBAuthentications(_rememberFile.FullName);
                string[] servers = _dBAuthentications.Servers;
                if (servers.Length > 0)
                {
                    com_server.Items.AddRange(servers);
                    com_server.SelectedIndex = 0;
                }
            }
            else
            {
                _dBAuthentications = new DBAuthentications();
                _dBAuthentications.Save(_rememberFile.FullName);
            }

            com_driver.Text = driver;
            com_server.Text = server;
            com_username.Text = username;
            txt_password.Text = password;
            com_database.Text = database;
        }

        void LoadDrivers()
        {
            try
            {
                Microsoft.Win32.RegistryKey reg = (Microsoft.Win32.Registry.LocalMachine).OpenSubKey("Software");
                if (reg != null)
                {
                    reg = reg.OpenSubKey("ODBC");
                    if (reg != null)
                    {
                        reg = reg.OpenSubKey("ODBCINST.INI");
                        if (reg != null)
                        {

                            reg = reg.OpenSubKey("ODBC Drivers");
                            if (reg != null)
                            {
                                foreach (string sName in reg.GetValueNames())
                                {
                                    com_driver.Items.Add(sName);
                                }
                            }
                            try
                            {
                                reg.Close();
                            }
                            catch { }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Com_server_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                com_username.Items.Clear();
                string server = com_server.Text;
                string[] usernames = _dBAuthentications[server];
                if (usernames.Length > 0)
                {
                    com_username.Items.AddRange(usernames);
                    com_username.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void Com_driver_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string driverName = com_driver.Text;
                if (driverName.IndexOf("SQL Server", StringComparison.InvariantCultureIgnoreCase) >= 0)
                {
                    txt_port.Text = "1433";
                    _databaseQuery = "select name from sys.databases where name not in ('master', 'model', 'tempdb', 'msdb', 'resource')";
                }
                else if (driverName.IndexOf("MariaDB", StringComparison.InvariantCultureIgnoreCase) >= 0 || driverName.IndexOf("MySQL", StringComparison.InvariantCultureIgnoreCase) >= 0)
                {
                    txt_port.Text = "3306";
                    _databaseQuery = "show databases where `database` not in ('mysql', 'performance_schema', 'information_schema')";
                }
                else
                {
                    txt_port.Text = "";
                    _ConnectionInfo.Driver = com_driver.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void but_connect_Click(object sender, EventArgs e)
        {
            try
            {
                string driver = com_driver.Text;
                if (string.IsNullOrEmpty(driver)) throw new Exception("Driver cannot be empty.");
                string server = com_server.Text;
                if (string.IsNullOrEmpty(server)) throw new Exception("Server cannot be empty.");
                string username = com_username.Text;
                if (string.IsNullOrEmpty(username)) throw new Exception("Username cannot be empty.");
                string password = txt_password.Text;
                int port;
                if (!int.TryParse(txt_port.Text, out port)) port = 0;
                string s_port = port == 0 ? "" : "port=" + port + ";";

                string connectionString = string.Format("server={0}; uid={1}; pwd={2}; driver={3}; {4}", server, username, password, driver, s_port);

                Thread th = new Thread(ite => Connect(connectionString));
                th.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        List<string> _databases;
        void Connect(string connectionString)
        {
            try
            {
                _databases = new List<string>();
                dlgProcess.ClearComboBoxItems(com_database);
                _connection = new OdbcConnection(connectionString);
                _connection.Open();
                DbCommand cmd = _connection.CreateCommand();
                cmd.CommandText = _databaseQuery;
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        _databases.Add(reader[0].ToString());
                        dlgProcess.AddComboBoxItem(com_database, reader[0].ToString());
                    }
                    dlgProcess.SetComboBoxIndex(com_database, 0);
                }

                reader.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (_connection != null)
                    _connection.Close();
            }
        }

        void Com_username_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string server = com_server.Text;
                string username = com_username.Text;
                txt_password.Text = _dBAuthentications[server, username];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void but_ok_Click(object sender, EventArgs e)
        {
            _ConnectionInfo = new DBConnectionInfo();
            _ConnectionInfo.Driver = com_driver.Text;
            _ConnectionInfo.Server = com_server.Text;
            _ConnectionInfo.Username = com_username.Text;
            _ConnectionInfo.Password = txt_password.Text;
            int port;
            if (!int.TryParse(txt_port.Text, out port)) port = 0;
            _ConnectionInfo.Port = port;

            if (lab_database.Visible)
            {
                _ConnectionInfo.Database = com_database.Text; 
            }

            if (chk_remember.Checked)
            {
                _dBAuthentications.Add(_ConnectionInfo.Server, _ConnectionInfo.Username, _ConnectionInfo.Password, _ConnectionInfo.Port.ToString(), _ConnectionInfo.Database, _ConnectionInfo.Driver);
            }

            DialogResult = DialogResult.OK;
        }

        private void but_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
