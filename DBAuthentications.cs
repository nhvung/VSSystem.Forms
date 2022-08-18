using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace VSSystem.Forms
{
    public class DBAuthentications
    {
        string _authFilePath;
        Dictionary<string, Dictionary<string, string>> _authentications;
        public string LastServer { get; private set; }
        public string LastUsername { get; private set; }
        public string LastPassword { get; private set; }
        public string LastPort { get; private set; }
        public string LastDatabase { get; private set; }
        public string LastDriver { get; private set; }

        public DBAuthentications()
        {
            _authentications = new Dictionary<string, Dictionary<string, string>>(StringComparer.InvariantCultureIgnoreCase);
        }
        public DBAuthentications(string xmlFileName)
        {
            _authFilePath = xmlFileName;
            try
            {
                _authentications = new Dictionary<string, Dictionary<string, string>>(StringComparer.InvariantCultureIgnoreCase);
                XmlDocument doc = new XmlDocument();
                doc.Load(xmlFileName);

                XmlNodeList authNodes = doc.GetElementsByTagName("auth");
                foreach (XmlNode authNode in authNodes)
                {
                    string server = authNode.Attributes?["server"]?.Value ?? string.Empty;
                    string username = authNode.Attributes?["username"]?.Value ?? string.Empty;
                    string password = authNode.Attributes?["password"]?.Value ?? string.Empty;
                    if (!_authentications.ContainsKey(server)) _authentications[server] = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
                    _authentications[server][username] = password;
                }

                XmlNode lastAuthNode = doc.SelectSingleNode("authentications/lastauth");
                if (lastAuthNode != null)
                {
                    LastServer = lastAuthNode.Attributes?["server"]?.Value ?? string.Empty;
                    LastUsername = lastAuthNode.Attributes?["username"]?.Value ?? string.Empty;
                    LastPassword = lastAuthNode.Attributes?["password"]?.Value ?? string.Empty;
                    LastPort = lastAuthNode.Attributes?["port"]?.Value ?? string.Empty;
                    LastDatabase = lastAuthNode.Attributes?["database"]?.Value ?? string.Empty;
                    LastDriver = lastAuthNode.Attributes?["driver"]?.Value ?? string.Empty;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string ToConnectionString()
        {
            try
            {
                string driver = LastDriver.IndexOf("sql server", StringComparison.InvariantCultureIgnoreCase) >= 0 ? "" : "driver=" + LastDriver + ";";
                string result = string.Format("server={0}; uid={1}; pwd={2}; database={3};{4}", LastServer, LastUsername, LastPassword, LastDatabase, driver);
                return result;
            }
            catch { return string.Empty; }
        }

        public void Add(string server, string username, string password)
        {
            try
            {
                bool changed = false;
                if (!_authentications.ContainsKey(server)) { _authentications[server] = new Dictionary<string, string>(); changed = true; }
                if (!_authentications[server].ContainsKey(username)) { _authentications[server][username] = password; changed = true; }
                if (_authentications[server][username] != password) { _authentications[server][username] = password; changed = true; }
                if (changed) Save();
            }
            catch
            {

            }
        }

        public void Add(string server, string username, string password, string port, string database, string driver)
        {
            try
            {
                if (!_authentications.ContainsKey(server)) { _authentications[server] = new Dictionary<string, string>(); }
                if (!_authentications[server].ContainsKey(username)) { _authentications[server][username] = password; }
                if (_authentications[server][username] != password) { _authentications[server][username] = password; }

                Save(server, username, password, port, database, driver);
            }
            catch
            {

            }
        }
        public void Remove(string server)
        {
            try
            {
                if (_authentications.ContainsKey(server)) _authentications.Remove(server);
                Save();
            }
            catch
            {

            }
        }
        public void Remove(string server, string username)
        {
            try
            {
                if (_authentications.ContainsKey(server) && _authentications[server].ContainsKey(username)) _authentications[server].Remove(username);
                Save();
            }
            catch
            {

            }
        }

        void Save()
        {
            try
            {
                List<string> lines = new List<string>() { "<?xml version=\"1.0\" encoding=\"utf-8\" ?>", "<authentications>" };
                foreach (string server in _authentications.Keys)
                {
                    foreach (KeyValuePair<string, string> userpass in _authentications[server])
                    {
                        string line = string.Format("\t<auth server=\"{0}\" username=\"{1}\" password=\"{2}\" />", server, userpass.Key, userpass.Value);
                        lines.Add(line);
                    }
                }
                lines.Add("</authentications>");
                File.WriteAllLines(_authFilePath, lines);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        void Save(string last_server, string last_username, string last_password, string last_port, string last_database, string last_driver)
        {
            try
            {
                List<string> lines = new List<string>() { "<?xml version=\"1.0\" encoding=\"utf-8\" ?>", "<authentications>" };
                foreach (string server in _authentications.Keys)
                {
                    foreach (KeyValuePair<string, string> userpass in _authentications[server])
                    {
                        string line = string.Format("\t<auth server=\"{0}\" username=\"{1}\" password=\"{2}\" />", server, userpass.Key, userpass.Value);
                        lines.Add(line);
                    }
                }

                string lastLine = string.Format("\t<lastauth server=\"{0}\" username=\"{1}\" password=\"{2}\" port=\"{3}\" database=\"{4}\" driver=\"{5}\" />", last_server, last_username, last_password, last_port, last_database, last_driver);
                lines.Add(lastLine);

                lines.Add("</authentications>");
                File.WriteAllLines(_authFilePath, lines);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Save(string fileName)
        {
            try
            {
                List<string> lines = new List<string>() { "<?xml version=\"1.0\" encoding=\"utf-8\" ?>", "<authentications>" };
                foreach (string server in _authentications.Keys)
                {
                    foreach (KeyValuePair<string, string> userpass in _authentications[server])
                    {
                        string line = string.Format("\t<auth server=\"{0}\" username=\"{1}\" password=\"{2}\" />", server, userpass.Key, userpass.Value);
                        lines.Add(line);
                    }
                }
                lines.Add("</authentications>");
                File.WriteAllLines(fileName, lines);
                _authFilePath = fileName;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public string[] Servers { get { return _authentications.Keys.ToArray(); } }
        public string[] this[string server]
        {
            get { return _authentications.ContainsKey(server) ? _authentications[server].Keys.ToArray() : new string[0]; }
        }

        public string this[string server, string username]
        {
            get { return _authentications.ContainsKey(server) && _authentications[server].ContainsKey(username) ? _authentications[server][username] : string.Empty; }
        }
    }
}
