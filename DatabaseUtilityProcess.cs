using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace VSSystem.Forms
{
    public class DatabaseUtilityProcess
    {
        public static void Backup(DBConnectionInfo dbInfo, string mariadbDumpFilePath, string backupFilePath, Action<string> logAction = null)
        {

            try
            {
                FileInfo exeFile = new FileInfo(mariadbDumpFilePath);
                if (exeFile.Exists)
                {
                    DateTime bTime = DateTime.Now;
                    logAction?.Invoke("Begin backup database " + dbInfo.Database + " to " + backupFilePath + "...");
                    string args = string.Format("\"{5}\" -h {0} -u {1} --password=\"{2}\" {3} --routines=true > \"{4}\"", dbInfo.Server, dbInfo.Username, dbInfo.Password, dbInfo.Database, backupFilePath, exeFile.FullName);
                    ProcessStartInfo psi = new ProcessStartInfo("cmd.exe");
                    psi.Verb = "runas";
                    psi.UseShellExecute = false;
                    psi.RedirectStandardInput = true;
                    psi.CreateNoWindow = true;

                    using (Process p = Process.Start(psi))
                    {
                        p.StandardInput.WriteLine(args);
                        p.StandardInput.Close();
                        p.WaitForExit();
                        p.Close();
                    }
                    TimeSpan ts = DateTime.Now - bTime;

                    logAction?.Invoke("Backup database " + dbInfo.Database + " done. Time: " + ts.TotalSeconds + "s.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Restore(DBConnectionInfo dbInfo, string mariadbFilePath, string backupFilePath, Action<string> logAction = null)
        {

            try
            {
                FileInfo exeFile = new FileInfo(mariadbFilePath);
                if (exeFile.Exists)
                {
                    DateTime bTime = DateTime.Now;
                    logAction?.Invoke("Begin restore database " + dbInfo.Database + " from " + backupFilePath + "...");
                    string args = string.Format("\"{5}\" -h {0} -u {1} --password=\"{2}\" {3} < \"{4}\"", dbInfo.Server, dbInfo.Username, dbInfo.Password, dbInfo.Database, backupFilePath, exeFile.FullName);
                    ProcessStartInfo psi = new ProcessStartInfo("cmd.exe");
                    psi.Verb = "runas";
                    psi.UseShellExecute = false;
                    psi.RedirectStandardInput = true;
                    psi.CreateNoWindow = true;
                    using (Process p = Process.Start(psi))
                    {
                        p.StandardInput.WriteLine(args);
                        p.StandardInput.Close();
                        p.WaitForExit();
                        p.Close();
                    }
                        

                    TimeSpan ts = DateTime.Now - bTime;

                    logAction?.Invoke("Restore database " + dbInfo.Database + " done. Time: " + ts.TotalSeconds + "s.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
