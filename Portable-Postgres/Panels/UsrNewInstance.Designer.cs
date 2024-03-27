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
            this.grpDownload = new System.Windows.Forms.Panel();
            this.pbInstallProcess = new System.Windows.Forms.ProgressBar();
            this.lblUrl = new System.Windows.Forms.Label();
            this.btnAbort = new System.Windows.Forms.Button();
            this.pbDownloadProcess = new System.Windows.Forms.ProgressBar();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.cbUrl = new System.Windows.Forms.ComboBox();
            this.grpDownload.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDownload
            // 
            this.grpDownload.BackColor = System.Drawing.Color.Transparent;
            this.grpDownload.Controls.Add(this.pbInstallProcess);
            this.grpDownload.Controls.Add(this.lblUrl);
            this.grpDownload.Controls.Add(this.btnAbort);
            this.grpDownload.Controls.Add(this.pbDownloadProcess);
            this.grpDownload.Controls.Add(this.lblTitle);
            this.grpDownload.Controls.Add(this.lblStatus);
            this.grpDownload.Controls.Add(this.btnDownload);
            this.grpDownload.Controls.Add(this.lblInfo);
            this.grpDownload.Controls.Add(this.cbUrl);
            this.grpDownload.ForeColor = System.Drawing.Color.White;
            this.grpDownload.Location = new System.Drawing.Point(4, 4);
            this.grpDownload.Margin = new System.Windows.Forms.Padding(4);
            this.grpDownload.Name = "grpDownload";
            this.grpDownload.Size = new System.Drawing.Size(808, 159);
            this.grpDownload.TabIndex = 5;
            // 
            // pbInstallProcess
            // 
            this.pbInstallProcess.Location = new System.Drawing.Point(365, 117);
            this.pbInstallProcess.Margin = new System.Windows.Forms.Padding(4);
            this.pbInstallProcess.Maximum = 30;
            this.pbInstallProcess.Name = "pbInstallProcess";
            this.pbInstallProcess.Size = new System.Drawing.Size(215, 28);
            this.pbInstallProcess.TabIndex = 7;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(17, 31);
            this.lblUrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(37, 16);
            this.lblUrl.TabIndex = 3;
            this.lblUrl.Text = "URL:";
            // 
            // btnAbort
            // 
            this.btnAbort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAbort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbort.FlatAppearance.BorderSize = 0;
            this.btnAbort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAbort.Location = new System.Drawing.Point(588, 117);
            this.btnAbort.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(100, 28);
            this.btnAbort.TabIndex = 6;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = false;
            this.btnAbort.Visible = false;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // pbDownloadProcess
            // 
            this.pbDownloadProcess.Location = new System.Drawing.Point(9, 81);
            this.pbDownloadProcess.Margin = new System.Windows.Forms.Padding(4);
            this.pbDownloadProcess.Name = "pbDownloadProcess";
            this.pbDownloadProcess.Size = new System.Drawing.Size(787, 28);
            this.pbDownloadProcess.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(9, 4);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(172, 20);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Download Postgres";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(9, 123);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(29, 16);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Idle";
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownload.FlatAppearance.BorderSize = 0;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDownload.Location = new System.Drawing.Point(696, 117);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(4);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(100, 28);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(17, 59);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(462, 16);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "-- Select the first item for 32-bit Windows or the second item for 64-bit Windows" +
    "";
            // 
            // cbUrl
            // 
            this.cbUrl.FormattingEnabled = true;
            this.cbUrl.Items.AddRange(new object[] {
            "http://get.enterprisedb.com/postgresql/postgresql-8.4.16-1-windows-binaries.zip",
            "http://get.enterprisedb.com/postgresql/postgresql-9.2.1-1-windows-binaries.zip",
            "http://get.enterprisedb.com/postgresql/postgresql-9.2.1-1-windows-x64-binaries.zi" +
                "p",
            "(enter your own)"});
            this.cbUrl.Location = new System.Drawing.Point(68, 27);
            this.cbUrl.Margin = new System.Windows.Forms.Padding(4);
            this.cbUrl.Name = "cbUrl";
            this.cbUrl.Size = new System.Drawing.Size(727, 24);
            this.cbUrl.TabIndex = 2;
            // 
            // UsrNewInstance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Portable_Postgres.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.grpDownload);
            this.Name = "UsrNewInstance";
            this.Size = new System.Drawing.Size(815, 167);
            this.Load += new System.EventHandler(this.UsrNewInstance_Load);
            this.grpDownload.ResumeLayout(false);
            this.grpDownload.PerformLayout();
            this.ResumeLayout(false);

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
