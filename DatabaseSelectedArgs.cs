using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSSystem.Forms
{
    public class DatabaseSelectedArgs : EventArgs
    {
        string _Server;
        public string Server { get { return _Server; } set { _Server = value; } }

        string _Username;
        public string Username { get { return _Username; } set { _Username = value; } }

        string _Password;
        public string Password { get { return _Password; } set { _Password = value; } }

        string _Database;
        public string Database { get { return _Database; } set { _Database = value; } }

        string _Driver;
        public string Driver { get { return _Driver; } set { _Driver = value; } }

        int _Port;
        public int Port { get { return _Port; } set { _Port = value; } }

    }
}
