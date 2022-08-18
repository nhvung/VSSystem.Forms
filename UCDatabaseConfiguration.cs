using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Data.Odbc;
using System.Threading;
using System.Data.Common;
using System.Data.SqlClient;

namespace VSSystem.Forms
{
    public partial class UCDatabaseConfiguration : UserControl
    {
        string _driver, _server, _username, _password, _database;
        int _port;
        DelegateProcess dlgProcess;

        FileInfo _rememberFile;
        DBAuthentications _dBAuthentications;
        string _databaseQuery;
        DbConnection _connection;
        public event EventHandler<DatabaseSelectedArgs> OnDatabaseSelected;

        public UCDatabaseConfiguration()
        {
            InitializeComponent();

            com_driver.Sorted = true;
            dlgProcess = new DelegateProcess();
            com_driver.SelectedIndexChanged += Com_driver_SelectedIndexChanged;
            com_username.SelectedIndexChanged += Com_username_SelectedIndexChanged;
            com_server.SelectedIndexChanged += Com_server_SelectedIndexChanged;
            com_database.SelectedIndexChanged += Com_database_SelectedIndexChanged;

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
            LoadDrivers();
        }

        private void Com_database_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _database = com_database.Text;
                OnDatabaseSelected?.Invoke(sender, new DatabaseSelectedArgs() { Server = _server, Username = _username, Password = _password, Database = _database, Driver = _driver, Port = _port });
            }
            catch
            {

            }
        }

        private void Com_server_SelectedIndexChanged(object sender, EventArgs e)
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

        private void Com_driver_SelectedIndexChanged(object sender, EventArgs e)
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
                    _driver = com_driver.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Com_username_SelectedIndexChanged(object sender, EventArgs e)
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
        private void but_connect_Click(object sender, EventArgs e)
        {
            try
            {
                _driver = com_driver.Text;
                if (string.IsNullOrEmpty(_driver)) throw new Exception("Driver cannot be empty.");
                _server = com_server.Text;
                if (string.IsNullOrEmpty(_server)) throw new Exception("Server cannot be empty.");
                _username = com_username.Text;
                if (string.IsNullOrEmpty(_username)) throw new Exception("Username cannot be empty.");
                _password = txt_password.Text;
                if (!int.TryParse(txt_port.Text, out _port)) _port = 0;
                string s_port = _port == 0 ? "" : "port=" + _port + ";";
                
                if (chk_remember.Checked)
                {
                    _dBAuthentications.Add(_server, _username, _password);
                }
                string connectionString = string.Format("server={0}; uid={1}; pwd={2}; driver={3}; {4}", _server, _username, _password,_driver, s_port);

                Thread th = new Thread(ite => Connect(connectionString));
                th.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Connect(string connectionString)
        {            
            try
            {
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
                if(_connection!=null)
                _connection.Close();
            }
        }
    }
}
