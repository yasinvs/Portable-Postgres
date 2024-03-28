namespace Portable_Postgres.Panels
{
    partial class UsrNewInstance
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpDownload = new System.Windows.Forms.Panel();
            pbInstallProcess = new System.Windows.Forms.ProgressBar();
            lblUrl = new System.Windows.Forms.Label();
            btnAbort = new System.Windows.Forms.Button();
            pbDownloadProcess = new System.Windows.Forms.ProgressBar();
            lblTitle = new System.Windows.Forms.Label();
            lblStatus = new System.Windows.Forms.Label();
            btnDownload = new System.Windows.Forms.Button();
            lblInfo = new System.Windows.Forms.Label();
            cbUrl = new System.Windows.Forms.ComboBox();
            grpDownload.SuspendLayout();
            SuspendLayout();
            // 
            // grpDownload
            // 
            grpDownload.BackColor = System.Drawing.Color.Transparent;
            grpDownload.Controls.Add(pbInstallProcess);
            grpDownload.Controls.Add(lblUrl);
            grpDownload.Controls.Add(btnAbort);
            grpDownload.Controls.Add(pbDownloadProcess);
            grpDownload.Controls.Add(lblTitle);
            grpDownload.Controls.Add(lblStatus);
            grpDownload.Controls.Add(btnDownload);
            grpDownload.Controls.Add(lblInfo);
            grpDownload.Controls.Add(cbUrl);
            grpDownload.ForeColor = System.Drawing.Color.White;
            grpDownload.Location = new System.Drawing.Point(4, 5);
            grpDownload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            grpDownload.Name = "grpDownload";
            grpDownload.Size = new System.Drawing.Size(808, 199);
            grpDownload.TabIndex = 5;
            // 
            // pbInstallProcess
            // 
            pbInstallProcess.Location = new System.Drawing.Point(365, 146);
            pbInstallProcess.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pbInstallProcess.Name = "pbInstallProcess";
            pbInstallProcess.Size = new System.Drawing.Size(215, 35);
            pbInstallProcess.TabIndex = 7;
            // 
            // lblUrl
            // 
            lblUrl.AutoSize = true;
            lblUrl.Location = new System.Drawing.Point(17, 39);
            lblUrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblUrl.Name = "lblUrl";
            lblUrl.Size = new System.Drawing.Size(38, 20);
            lblUrl.TabIndex = 3;
            lblUrl.Text = "URL:";
            // 
            // btnAbort
            // 
            btnAbort.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            btnAbort.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAbort.FlatAppearance.BorderSize = 0;
            btnAbort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAbort.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnAbort.Location = new System.Drawing.Point(588, 146);
            btnAbort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnAbort.Name = "btnAbort";
            btnAbort.Size = new System.Drawing.Size(100, 35);
            btnAbort.TabIndex = 6;
            btnAbort.Text = "Abort";
            btnAbort.UseVisualStyleBackColor = false;
            btnAbort.Visible = false;
            btnAbort.Click += btnAbort_Click;
            // 
            // pbDownloadProcess
            // 
            pbDownloadProcess.Location = new System.Drawing.Point(9, 101);
            pbDownloadProcess.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pbDownloadProcess.Name = "pbDownloadProcess";
            pbDownloadProcess.Size = new System.Drawing.Size(787, 35);
            pbDownloadProcess.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = System.Drawing.Color.Transparent;
            lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(9, 5);
            lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(172, 20);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "Download Postgres";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new System.Drawing.Point(9, 154);
            lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(34, 20);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Idle";
            // 
            // btnDownload
            // 
            btnDownload.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            btnDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDownload.FlatAppearance.BorderSize = 0;
            btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDownload.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            btnDownload.Location = new System.Drawing.Point(696, 146);
            btnDownload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new System.Drawing.Size(100, 35);
            btnDownload.TabIndex = 1;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = false;
            btnDownload.Click += btnDownload_Click;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new System.Drawing.Point(17, 74);
            lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new System.Drawing.Size(545, 20);
            lblInfo.TabIndex = 4;
            lblInfo.Text = "-- Select the first item for 32-bit Windows or the second item for 64-bit Windows";
            // 
            // cbUrl
            // 
            cbUrl.FormattingEnabled = true;
            cbUrl.Items.AddRange(new object[] { "http://get.enterprisedb.com/postgresql/postgresql-8.4.16-1-windows-binaries.zip", "http://get.enterprisedb.com/postgresql/postgresql-9.2.1-1-windows-binaries.zip", "http://get.enterprisedb.com/postgresql/postgresql-9.2.1-1-windows-x64-binaries.zip", "(enter your own)" });
            cbUrl.Location = new System.Drawing.Point(68, 34);
            cbUrl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cbUrl.Name = "cbUrl";
            cbUrl.Size = new System.Drawing.Size(727, 28);
            cbUrl.TabIndex = 2;
            // 
            // UsrNewInstance
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Controls.Add(grpDownload);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "UsrNewInstance";
            Size = new System.Drawing.Size(815, 209);
            Load += UsrNewInstance_Load;
            grpDownload.ResumeLayout(false);
            grpDownload.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel grpDownload;
        private System.Windows.Forms.ProgressBar pbInstallProcess;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.ProgressBar pbDownloadProcess;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ComboBox cbUrl;
    }
}
