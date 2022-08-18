using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VSSystem.Forms
{
    public class DBConnectionInfo
    {

        string _Driver;
        public string Driver { get { return _Driver; } set { _Driver = value; } }

        string _Server;
        public string Server { get { return _Server; } set { _Server = value; } }

        int _Port;
        public int Port { get { return _Port; } set { _Port = value; } }

        string _Username;
        public string Username { get { return _Username; } set { _Username = value; } }

        string _Password;
        public string Password { get { return _Password; } set { _Password = value; } }

        string _Database;
        public string Database { get { return _Database; } set { _Database = value; } }
        public string GetConnectionString()
        {
            return string.Format("server={0}; uid={1}; pwd={2};{3}{4} driver={5}", _Server, _Username, _Password, _Port > 0 ? "port="+_Port +"; " : "", !string.IsNullOrEmpty(_Database) ? "database=" + _Database + "; " : "", _Driver);
        }
        public string GetVSConnectionString()
        {
            return string.Format("server={0}; uid={1}; pwd={2};{3}{4}", _Server, _Username, _Password, !string.IsNullOrEmpty(_Database) ? "database=" + _Database + "; " : "", _Driver.IndexOf("sql server",StringComparison.InvariantCultureIgnoreCase) >= 0 ? "" : "driver="+_Driver + "; ");
        }

        public string GetVSConnectionString(int numberPoolConnections)
        {
            return string.Format("server={0}; uid={1}; pwd={2};{3}{4}{5}", _Server, _Username, _Password, 
                !string.IsNullOrEmpty(_Database) ? "database=" + _Database + "; " : "", 
                _Driver.IndexOf("sql server", StringComparison.InvariantCultureIgnoreCase) >= 0 ? "" : "driver=" + _Driver + "; ",
                numberPoolConnections > 0 ? "Pooling=True; Min Pool Size=1; Max Pool Size=" + numberPoolConnections + "; " : ""
                );
        }
    }
}
