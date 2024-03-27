using Portable_Postgres.Entities;
using System;
using System.Diagnostics;
using System.Security;
using System.Windows.Forms;

namespace Portable_Postgres.Business
{
    public static class DotNetProcessStartManager
    {
        public static void ProcessStart(ProcessStart processStart)
        {
            try
            {
                var ProcessInfo = new ProcessStartInfo();
                ProcessInfo.FileName = processStart.FileName;
                ProcessInfo.Arguments = processStart.FileParameters;

                ProcessInfo.UseShellExecute = false;
                ProcessInfo.LoadUserProfile = true;
                if (processStart.HideWindow)
                {
                    ProcessInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    ProcessInfo.CreateNoWindow = true;
                }
                else
                {
                    ProcessInfo.WindowStyle = ProcessWindowStyle.Normal;
                    ProcessInfo.CreateNoWindow = false;
                }

                var ProcessStart = new Process
                {
                    StartInfo = ProcessInfo,
                };
                ProcessStart.Start();
                if (processStart.WaitProcess)
                {
                    ProcessStart.WaitForExit();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Çalıştırma esnasında aşağıdaki hata alındı.\n\n" + e, "Uygulama Çalıştırma Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}