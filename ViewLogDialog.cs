using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace VSSystem.Forms
{
    public partial class ViewLogDialog : Form
    {
        DirectoryInfo _folder;
        DelegateProcess dlgProcess;
        public ViewLogDialog(string folderPath)
        {
            InitializeComponent();
            if (!SystemInformation.TerminalServerSession)
            {
                Type dgvType = rtxt_log.GetType();
                PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
                pi.SetValue(rtxt_log, true, null);
            }
            dlgProcess = new DelegateProcess();

            tv_log.NodeMouseClick += Tv_log_NodeMouseClick;
            tv_log.AfterSelect += Tv_log_AfterSelect;

            try
            {
                _folder = new DirectoryInfo(folderPath);
                new Thread(Init).Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Tv_log_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                dlgProcess.SetText(rtxt_log, "");
                tv_log.SelectedNode = e.Node;
                if (e.Node.Nodes.Count == 0)
                {
                    FileInfo logFile = new FileInfo(e.Node.Name);
                    if (logFile.Exists)
                    {
                        new Thread(() => InitLog(logFile)).Start();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Tv_log_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            try
            {
                dlgProcess.SetText(rtxt_log, "");
                tv_log.SelectedNode = e.Node;
                if (e.Node.Nodes.Count == 0)
                {
                    FileInfo logFile = new FileInfo(e.Node.Name);
                    if (logFile.Exists)
                    {
                        new Thread(() => InitLog(logFile)).Start();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        object _lockObj = new object();
        void InitLog(FileInfo logFile)
        {
            
            try
            {
                dlgProcess.SetText(rtxt_log, "Loading...");
                lock (_lockObj)
                {
                    using (FileStream fs = new FileStream(logFile.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        using (StreamReader reader = new StreamReader(fs))
                        {
                            string line = reader.ReadToEnd();
                            dlgProcess.AppendText(rtxt_log, line);
                            reader.Close();
                        }
                        fs.Close();
                    } 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Init()
        {
            try
            {
                if (_folder.Exists)
                {
                    TreeNode node = new TreeNode(_folder.Name);
                    DirectoryInfo[] logFolders = _folder.GetDirectories("Log*");
                    foreach (DirectoryInfo logFolder in logFolders)
                    {

                        AddFolderToTree(logFolder, node);
                    }
                    dlgProcess.Execute(tv_log, () => tv_log.Nodes.Add(node));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void AddFolderToTree(DirectoryInfo folder, TreeNode node)
        {
            try
            {
                TreeNode folderNode = new TreeNode(folder.Name);
                DirectoryInfo[] folders = folder.GetDirectories();
                foreach (var sFolder in folders)
                {
                    AddFolderToTree(sFolder, folderNode);
                }
                FileInfo[] files = folder.GetFiles();
                foreach (FileInfo file in files)
                {
                    TreeNode cNode = folderNode.Nodes.Add(file.FullName, file.Name);
                }
                node.Nodes.Add(folderNode);
            }
            catch
            {

            }
        }

        private void but_close_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
    }
}
