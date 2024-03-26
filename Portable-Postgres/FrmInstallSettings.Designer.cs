﻿namespace Portable_Postgres
{
    partial class FrmInstallSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInstallSettings));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttInstall = new System.Windows.Forms.Button();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.lbDatabase = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.buttPassHide = new System.Windows.Forms.Button();
            this.buttPassShow = new System.Windows.Forms.Button();
            this.buttCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(796, 4);
            this.panel2.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Portable_Postgres.Properties.Resources.background;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 43);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Install Settings";
            // 
            // buttInstall
            // 
            this.buttInstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttInstall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttInstall.FlatAppearance.BorderSize = 0;
            this.buttInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttInstall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttInstall.Location = new System.Drawing.Point(668, 180);
            this.buttInstall.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttInstall.Name = "buttInstall";
            this.buttInstall.Size = new System.Drawing.Size(111, 32);
            this.buttInstall.TabIndex = 13;
            this.buttInstall.Text = "Install";
            this.buttInstall.UseVisualStyleBackColor = false;
            this.buttInstall.Click += new System.EventHandler(this.buttInstall_Click);
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(172, 60);
            this.txtDatabase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDatabase.MaxLength = 64;
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(256, 22);
            this.txtDatabase.TabIndex = 14;
            this.txtDatabase.Text = "postgres";
            // 
            // lbDatabase
            // 
            this.lbDatabase.AutoSize = true;
            this.lbDatabase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbDatabase.Location = new System.Drawing.Point(16, 64);
            this.lbDatabase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDatabase.Name = "lbDatabase";
            this.lbDatabase.Size = new System.Drawing.Size(107, 16);
            this.lbDatabase.TabIndex = 15;
            this.lbDatabase.Text = "Database name:";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbUser.Location = new System.Drawing.Point(16, 96);
            this.lbUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(39, 16);
            this.lbUser.TabIndex = 17;
            this.lbUser.Text = "User:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(172, 92);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUser.MaxLength = 64;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(256, 22);
            this.txtUser.TabIndex = 16;
            this.txtUser.Text = "User";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbPass.Location = new System.Drawing.Point(16, 128);
            this.lbPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(41, 16);
            this.lbPass.TabIndex = 19;
            this.lbPass.Text = "Pass:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(172, 124);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPass.MaxLength = 64;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(256, 22);
            this.txtPass.TabIndex = 18;
            // 
            // buttPassHide
            // 
            this.buttPassHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttPassHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttPassHide.FlatAppearance.BorderSize = 0;
            this.buttPassHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttPassHide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttPassHide.Location = new System.Drawing.Point(437, 119);
            this.buttPassHide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttPassHide.Name = "buttPassHide";
            this.buttPassHide.Size = new System.Drawing.Size(164, 32);
            this.buttPassHide.TabIndex = 20;
            this.buttPassHide.Text = "Hide password chars";
            this.buttPassHide.UseVisualStyleBackColor = false;
            this.buttPassHide.Click += new System.EventHandler(this.buttPassHide_Click);
            // 
            // buttPassShow
            // 
            this.buttPassShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttPassShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttPassShow.FlatAppearance.BorderSize = 0;
            this.buttPassShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttPassShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttPassShow.Location = new System.Drawing.Point(609, 119);
            this.buttPassShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttPassShow.Name = "buttPassShow";
            this.buttPassShow.Size = new System.Drawing.Size(169, 32);
            this.buttPassShow.TabIndex = 21;
            this.buttPassShow.Text = "Show password chars";
            this.buttPassShow.UseVisualStyleBackColor = false;
            this.buttPassShow.Visible = false;
            this.buttPassShow.Click += new System.EventHandler(this.buttPassShow_Click);
            // 
            // buttCancel
            // 
            this.buttCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttCancel.FlatAppearance.BorderSize = 0;
            this.buttCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttCancel.Location = new System.Drawing.Point(20, 180);
            this.buttCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttCancel.Name = "buttCancel";
            this.buttCancel.Size = new System.Drawing.Size(111, 32);
            this.buttCancel.TabIndex = 22;
            this.buttCancel.Text = "Cancel";
            this.buttCancel.UseVisualStyleBackColor = false;
            this.buttCancel.Click += new System.EventHandler(this.buttCancel_Click);
            // 
            // FrmInstallSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 228);
            this.Controls.Add(this.buttCancel);
            this.Controls.Add(this.buttPassShow);
            this.Controls.Add(this.buttPassHide);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lbDatabase);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.buttInstall);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmInstallSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Install Settings - Ubermeat.co.uk FOSS";
            this.Load += new System.EventHandler(this.FrmInstallSettings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttInstall;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label lbDatabase;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button buttPassHide;
        private System.Windows.Forms.Button buttPassShow;
        private System.Windows.Forms.Button buttCancel;
    }
}