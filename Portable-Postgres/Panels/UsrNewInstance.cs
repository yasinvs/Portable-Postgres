using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Ionic.Zip;
using Portable_Postgres.Entities;
using Portable_Postgres.Business;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Portable_Postgres.Helper;
using Npgsql;
using System.Net.Sockets;

namespace Portable_Postgres.Panels
{
    public partial class UsrNewInstance : UserControl
    {
        #region Task - DownloadFile
        WebClient webClient;

        private async Task DownloadFileAsync(string downloadUrl)
        {
            webClient = new WebClient();
            webClient.DownloadFileCompleted += webClient_DownloadFileCompleted;
            webClient.DownloadProgressChanged += webClient_DownloadProgressChanged;
            await webClient.DownloadFileTaskAsync(new Uri(downloadUrl), Application.StartupPath + "\\Postgres.zip");

            if (!webClient.IsBusy)
            {
                webClient.Dispose();
            }
        }

        #region WebClient Events
        private void webClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            lblInfo.Text = e.BytesReceived + " bytes / " + e.TotalBytesToReceive + " bytes (" + e.ProgressPercentage + "%)";
            pbDownloadProcess.Value = e.ProgressPercentage;
        }

        private void webClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                lblInfo.Text = "Download failed...";
                MessageBox.Show(this, "Download failed...", "Download Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (e.Error != null)
            {
                MessageBox.Show(this, $"Download failed... {e.Error.ToString()}", "Download Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #endregion
        #region Task - ExtractZipFile
        private async Task ExtractZipFileAsync(string zipPath)
        {
            await Task.Run(() =>
            {
                using (ZipFile zip = new ZipFile(zipPath))
                {
                    zip.ExtractAll(Application.StartupPath + "\\Postgres", ExtractExistingFileAction.OverwriteSilently);
                }
            });
        }
        #endregion
        #region Task - InitDb
        private void InitDb()
        {
            Business.ProcessOutput processOutput = new Business.ProcessOutput(
                $"{Application.StartupPath}\\Postgres\\pgsql\\bin\\initdb.exe",
                $"-D {Application.StartupPath}\\Postgres\\Database --locale=\"English_United States.1252\"",
                true
            );
            processOutput.start();
        }
        #endregion

        NpgsqlConnection conn = null;

        public UsrNewInstance()
        {
            InitializeComponent();
        }

        private void UsrNewInstance_Load(object sender, EventArgs e)
        {
            cbUrl.SelectedIndex = 0;
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            if (cbUrl.Text.Length == 0)
            {
                MessageBox.Show(this, "Please select a url to download...", "No Url Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            if (Directory.Exists(Application.StartupPath + "\\Postgres") && MessageBox.Show(this, "An existing installation already exists, you need to delete it to continue the download...", "Existing Installation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
            {
                return;
            }

            if (Directory.Exists(Application.StartupPath + "\\Postgres"))
            {
                Directory.Delete(Application.StartupPath + "\\Postgres", true);
            }

            FrmInstallSettings frmInstallSettings = new FrmInstallSettings();
            frmInstallSettings.ShowDialog(this);
            DbSettings dbSettings = new DbSettings();
            if (frmInstallSettings.DialogResult == DialogResult.Cancel)
            {
                return;
            }

            dbSettings = frmInstallSettings.dbSettings;

            var a = SerializerHelper.Serialize(dbSettings, SerializeFormat.JSON);
            File.WriteAllText(Application.StartupPath + "\\dbsettings.json", a);

            if (webClient != null)
            {
                webClient.CancelAsync();
                webClient.Dispose();
            }

            btnDownload.Visible = false;
            btnAbort.Visible = true;
            cbUrl.Enabled = false;

            //await DownloadFileAsync(cbUrl.Text);

            pbInstallProcess.Value = 15;
            lblStatus.Text = "Extracting Postgres...";
            await ExtractZipFileAsync(Application.StartupPath + "\\Postgres.zip");

            DotNetProcessStartManager.ProcessStart(new ProcessStart()
            {
                FileName = $"{Application.StartupPath}\\Postgres\\pgsql\\bin\\initdb.exe",
                FileParameters = $"-D {Application.StartupPath}\\Postgres\\Database --locale=\"English_United States.1252\"",
                HideWindow = true,
                WaitProcess = true
            });

            PostgresServer.KillServer();
            PostgresServer.StartServer();
            bool checkServer = PostgresServer.CheckServer();

            Socket socket = PostgresServer.ConnectServer();

            DotNetProcessStartManager.ProcessStart(new ProcessStart()
            {
                FileName = $"{Application.StartupPath}\\Postgres\\pgsql\\bin\\createuser.exe",
                FileParameters = "-s -d -r -e root",
                HideWindow = true,
                WaitProcess = true
            });

            if (checkServer)
            {
                NpgsqlCommand comm = new NpgsqlCommand($"CREATE USER root WITH PASSWORD \"\" CREATEDB", conn);
                comm.ExecuteNonQuery();
            }

            btnDownload.Visible = true;
            btnAbort.Visible = false;
            cbUrl.Enabled = true;
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Aborting download...";
            if (webClient != null)
            {
                webClient.CancelAsync();
                webClient.Dispose();

                btnAbort.Visible = false;
                btnDownload.Visible = true;
                cbUrl.Enabled = true;
                pbDownloadProcess.Value = 0;
            }
        }
    }
}
