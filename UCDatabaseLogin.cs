using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace VSSystem.Forms
{
    public partial class UCDatabaseLogin : UserControl
    {
        string _driver, _server, _username, _password, _port;
        FileInfo _rememberFile;
        DBAuthentications _dBAuthentications;
        DelegateProcess dlgProcess;
        public UCDatabaseLogin()
        {
            InitializeComponent();
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
            LoadDrivers();
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

        private void but_ok_Click(object sender, EventArgs e)
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
                _port = string.IsNullOrEmpty(txt_port.Text) ? "" : "Port=" + txt_port.Text + ";";

                if (chk_remember.Checked)
                {
                    _dBAuthentications.Add(_server, _username, _password);
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
                }
                else if (driverName.IndexOf("MariaDB", StringComparison.InvariantCultureIgnoreCase) >= 0 || driverName.IndexOf("MySQL", StringComparison.InvariantCultureIgnoreCase) >= 0)
                {
                    txt_port.Text = "3306";
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
    }
}
