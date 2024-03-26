using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Ionic.Zip;
using Portable_Postgres.Entities;

namespace Portable_Postgres.Panels
{
    public partial class UsrNewInstance : UserControl
    {
        WebClient webClient = new WebClient();

        public UsrNewInstance()
        {
            InitializeComponent();
        }

        private void UsrNewInstance_Load(object sender, EventArgs e)
        {
            cbUrl.SelectedIndex = 0;
        }

        private void btnDownload_Click(object sender, EventArgs e)
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

            Directory.Delete(Application.StartupPath + "\\Postgres", true);

            FrmInstallSettings frmInstallSettings = new FrmInstallSettings();
            frmInstallSettings.ShowDialog(this);
            DbSettings dbSettings = new DbSettings();

            if (frmInstallSettings.DialogResult == DialogResult.Cancel)
            {
                return;
            }

            dbSettings = frmInstallSettings.dbSettings;

            if (webClient != null)
            {
                webClient.CancelAsync();
                webClient.Dispose();
            }

            webClient.DownloadProgressChanged += webClient_DownloadProgressChanged;
            webClient.DownloadFileCompleted += webClient_DownloadFileCompleted;
            webClient.DownloadFileAsync(new Uri(cbUrl.Text), Application.StartupPath + "\\Postgres.zip");

            if (!webClient.IsBusy)
            {
                ZipFile zip = new ZipFile(Application.StartupPath + "\\Postgres.zip");
                zip.ExtractAll(Application.StartupPath + "\\Postgres", ExtractExistingFileAction.OverwriteSilently);
                zip.Dispose();
            }

            // DATABASE STURCTURE - NOT COMPLETED

            btnDownload.Visible = false;
            btnAbort.Visible = true;
            cbUrl.Enabled = false;
        }

        private void webClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            lblInfo.Text = e.BytesReceived + " bytes / " + e.TotalBytesToReceive + " bytes (" + e.ProgressPercentage + "%)";
            pbDownloadProcess.Value = e.ProgressPercentage;
        }

        private void webClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            btnAbort.Visible = false;
            pbDownloadProcess.Value = 0;

            if (e.Cancelled || e.Error != null)
            {
                lblInfo.Text = "Download failed...";
                MessageBox.Show(this, "Download failed...", "Download Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
