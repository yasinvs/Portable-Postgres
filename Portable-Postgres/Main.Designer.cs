namespace Portable_Postgres
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            versionText = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            dbBrowse = new System.Windows.Forms.FolderBrowserDialog();
            saveSettings = new System.Windows.Forms.Timer(components);
            panel1 = new System.Windows.Forms.Panel();
            linkDebug = new System.Windows.Forms.LinkLabel();
            linkHelp = new System.Windows.Forms.LinkLabel();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            label2 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // versionText
            // 
            versionText.AutoSize = true;
            versionText.BackColor = System.Drawing.Color.Transparent;
            versionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            versionText.ForeColor = System.Drawing.Color.White;
            versionText.Location = new System.Drawing.Point(888, 186);
            versionText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            versionText.Name = "versionText";
            versionText.Size = new System.Drawing.Size(47, 17);
            versionText.TabIndex = 11;
            versionText.Text = "v0.0.0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = System.Drawing.Color.Transparent;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label11.ForeColor = System.Drawing.Color.White;
            label11.Location = new System.Drawing.Point(852, 161);
            label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(121, 17);
            label11.TabIndex = 10;
            label11.Text = "Portable Postgres";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Image = Properties.Resources.PostgreSQL_logo1;
            pictureBox1.Location = new System.Drawing.Point(847, 18);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(132, 139);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // dbBrowse
            // 
            dbBrowse.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // saveSettings
            // 
            saveSettings.Interval = 3000;
            saveSettings.Tick += saveSettings_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(linkDebug);
            panel1.Controls.Add(linkHelp);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label2);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 662);
            panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1252, 49);
            panel1.TabIndex = 9;
            // 
            // linkDebug
            // 
            linkDebug.ActiveLinkColor = System.Drawing.Color.White;
            linkDebug.AutoSize = true;
            linkDebug.Dock = System.Windows.Forms.DockStyle.Left;
            linkDebug.LinkColor = System.Drawing.Color.FromArgb(64, 64, 64);
            linkDebug.Location = new System.Drawing.Point(239, 0);
            linkDebug.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            linkDebug.Name = "linkDebug";
            linkDebug.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            linkDebug.Size = new System.Drawing.Size(157, 24);
            linkDebug.TabIndex = 14;
            linkDebug.TabStop = true;
            linkDebug.Text = "Show Debug Console";
            linkDebug.LinkClicked += linkDebug_LinkClicked;
            // 
            // linkHelp
            // 
            linkHelp.ActiveLinkColor = System.Drawing.Color.White;
            linkHelp.AutoSize = true;
            linkHelp.Dock = System.Windows.Forms.DockStyle.Left;
            linkHelp.LinkColor = System.Drawing.Color.FromArgb(64, 64, 64);
            linkHelp.Location = new System.Drawing.Point(156, 0);
            linkHelp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            linkHelp.Name = "linkHelp";
            linkHelp.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            linkHelp.Size = new System.Drawing.Size(83, 24);
            linkHelp.TabIndex = 13;
            linkHelp.TabStop = true;
            linkHelp.Text = "View Help";
            linkHelp.LinkClicked += linkHelp_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = System.Drawing.Color.White;
            linkLabel1.AutoSize = true;
            linkLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            linkLabel1.LinkColor = System.Drawing.Color.FromArgb(64, 64, 64);
            linkLabel1.Location = new System.Drawing.Point(0, 0);
            linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            linkLabel1.Size = new System.Drawing.Size(156, 24);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Contribute via Github";
            linkLabel1.LinkClicked += linkContribute_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = System.Windows.Forms.DockStyle.Right;
            label2.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            label2.Location = new System.Drawing.Point(872, 0);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            label2.Size = new System.Drawing.Size(380, 44);
            label2.TabIndex = 11;
            label2.Text = "Author: limpygnome (limpygnome@gmail.com)\r\nCreative Commons Attribution-ShareAlike 3.0 unported";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            panel2.Location = new System.Drawing.Point(9, 15);
            panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(814, 221);
            panel2.TabIndex = 12;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1252, 711);
            Controls.Add(panel2);
            Controls.Add(versionText);
            Controls.Add(panel1);
            Controls.Add(label11);
            Controls.Add(pictureBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Main";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Portable Postgres - Ubermeat.co.uk FOSS";
            FormClosing += Form1_FormClosing;
            Load += Main_Load;
            Shown += Form1_Shown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog dbBrowse;
        private System.Windows.Forms.Timer saveSettings;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label versionText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkHelp;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkDebug;
        private System.Windows.Forms.Panel panel2;
    }
}

