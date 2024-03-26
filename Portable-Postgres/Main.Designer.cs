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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lsWipe = new System.Windows.Forms.Button();
            this.lsHide = new System.Windows.Forms.CheckBox();
            this.lsRestart = new System.Windows.Forms.Button();
            this.lsStop = new System.Windows.Forms.Button();
            this.lsStart = new System.Windows.Forms.Button();
            this.dbDatabase = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dbPass = new System.Windows.Forms.TextBox();
            this.dbUser = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pathSQL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.versionText = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupLaunch = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.buttPgAdmin3 = new System.Windows.Forms.Button();
            this.lsAutoLaunch = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dbBrowse = new System.Windows.Forms.FolderBrowserDialog();
            this.saveSettings = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkDebug = new System.Windows.Forms.LinkLabel();
            this.linkHelp = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupLaunch.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsWipe
            // 
            this.lsWipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lsWipe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lsWipe.FlatAppearance.BorderSize = 0;
            this.lsWipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lsWipe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lsWipe.Location = new System.Drawing.Point(501, 27);
            this.lsWipe.Margin = new System.Windows.Forms.Padding(4);
            this.lsWipe.Name = "lsWipe";
            this.lsWipe.Size = new System.Drawing.Size(135, 32);
            this.lsWipe.TabIndex = 4;
            this.lsWipe.Text = "Wipe Database";
            this.lsWipe.UseVisualStyleBackColor = false;
            this.lsWipe.Click += new System.EventHandler(this.lsWipe_Click);
            // 
            // lsHide
            // 
            this.lsHide.AutoSize = true;
            this.lsHide.Checked = true;
            this.lsHide.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lsHide.Location = new System.Drawing.Point(335, 27);
            this.lsHide.Margin = new System.Windows.Forms.Padding(4);
            this.lsHide.Name = "lsHide";
            this.lsHide.Size = new System.Drawing.Size(146, 20);
            this.lsHide.TabIndex = 3;
            this.lsHide.Text = "Hide server window";
            this.lsHide.UseVisualStyleBackColor = true;
            this.lsHide.CheckedChanged += new System.EventHandler(this.lsHide_CheckedChanged);
            // 
            // lsRestart
            // 
            this.lsRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lsRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lsRestart.FlatAppearance.BorderSize = 0;
            this.lsRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lsRestart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lsRestart.Location = new System.Drawing.Point(227, 27);
            this.lsRestart.Margin = new System.Windows.Forms.Padding(4);
            this.lsRestart.Name = "lsRestart";
            this.lsRestart.Size = new System.Drawing.Size(100, 32);
            this.lsRestart.TabIndex = 2;
            this.lsRestart.Text = "Restart";
            this.lsRestart.UseVisualStyleBackColor = false;
            this.lsRestart.Click += new System.EventHandler(this.lsRestart_Click);
            // 
            // lsStop
            // 
            this.lsStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lsStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lsStop.FlatAppearance.BorderSize = 0;
            this.lsStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lsStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lsStop.Location = new System.Drawing.Point(119, 27);
            this.lsStop.Margin = new System.Windows.Forms.Padding(4);
            this.lsStop.Name = "lsStop";
            this.lsStop.Size = new System.Drawing.Size(100, 32);
            this.lsStop.TabIndex = 1;
            this.lsStop.Text = "Stop";
            this.lsStop.UseVisualStyleBackColor = false;
            this.lsStop.Visible = false;
            this.lsStop.Click += new System.EventHandler(this.lsStop_Click);
            // 
            // lsStart
            // 
            this.lsStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lsStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lsStart.FlatAppearance.BorderSize = 0;
            this.lsStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lsStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lsStart.Location = new System.Drawing.Point(11, 27);
            this.lsStart.Margin = new System.Windows.Forms.Padding(4);
            this.lsStart.Name = "lsStart";
            this.lsStart.Size = new System.Drawing.Size(100, 32);
            this.lsStart.TabIndex = 0;
            this.lsStart.Text = "Start";
            this.lsStart.UseVisualStyleBackColor = false;
            this.lsStart.Click += new System.EventHandler(this.lsStart_Click);
            // 
            // dbDatabase
            // 
            this.dbDatabase.Location = new System.Drawing.Point(595, 144);
            this.dbDatabase.Margin = new System.Windows.Forms.Padding(4);
            this.dbDatabase.Name = "dbDatabase";
            this.dbDatabase.Size = new System.Drawing.Size(197, 22);
            this.dbDatabase.TabIndex = 10;
            this.dbDatabase.Text = "postgres";
            this.dbDatabase.TextChanged += new System.EventHandler(this.dbDatabase_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(512, 148);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Database:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 148);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Pass:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "User:";
            // 
            // dbPass
            // 
            this.dbPass.Location = new System.Drawing.Point(309, 144);
            this.dbPass.Margin = new System.Windows.Forms.Padding(4);
            this.dbPass.Name = "dbPass";
            this.dbPass.Size = new System.Drawing.Size(195, 22);
            this.dbPass.TabIndex = 6;
            this.dbPass.TextChanged += new System.EventHandler(this.dbPass_TextChanged);
            // 
            // dbUser
            // 
            this.dbUser.Location = new System.Drawing.Point(69, 144);
            this.dbUser.Margin = new System.Windows.Forms.Padding(4);
            this.dbUser.Name = "dbUser";
            this.dbUser.Size = new System.Drawing.Size(179, 22);
            this.dbUser.TabIndex = 5;
            this.dbUser.Text = "root";
            this.dbUser.TextChanged += new System.EventHandler(this.dbUser_TextChanged);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.Location = new System.Drawing.Point(7, 176);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(499, 32);
            this.button5.TabIndex = 4;
            this.button5.Text = "Launch Client (psql)";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.Location = new System.Drawing.Point(693, 110);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 3;
            this.button4.Text = "Browse";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pathSQL
            // 
            this.pathSQL.Location = new System.Drawing.Point(11, 112);
            this.pathSQL.Margin = new System.Windows.Forms.Padding(4);
            this.pathSQL.Name = "pathSQL";
            this.pathSQL.Size = new System.Drawing.Size(673, 22);
            this.pathSQL.TabIndex = 1;
            this.pathSQL.TextChanged += new System.EventHandler(this.pathSQL_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the path containing your SQL files:";
            // 
            // versionText
            // 
            this.versionText.AutoSize = true;
            this.versionText.BackColor = System.Drawing.Color.Transparent;
            this.versionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionText.ForeColor = System.Drawing.Color.White;
            this.versionText.Location = new System.Drawing.Point(888, 149);
            this.versionText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.versionText.Name = "versionText";
            this.versionText.Size = new System.Drawing.Size(47, 17);
            this.versionText.TabIndex = 11;
            this.versionText.Text = "v0.0.0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(852, 129);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Portable Postgres";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Portable_Postgres.Properties.Resources.PostgreSQL_logo1;
            this.pictureBox1.Location = new System.Drawing.Point(847, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // groupLaunch
            // 
            this.groupLaunch.BackColor = System.Drawing.Color.Transparent;
            this.groupLaunch.Controls.Add(this.label12);
            this.groupLaunch.Controls.Add(this.buttPgAdmin3);
            this.groupLaunch.Controls.Add(this.lsAutoLaunch);
            this.groupLaunch.Controls.Add(this.label8);
            this.groupLaunch.Controls.Add(this.button1);
            this.groupLaunch.Controls.Add(this.lsStart);
            this.groupLaunch.Controls.Add(this.label10);
            this.groupLaunch.Controls.Add(this.button4);
            this.groupLaunch.Controls.Add(this.lsWipe);
            this.groupLaunch.Controls.Add(this.lsStop);
            this.groupLaunch.Controls.Add(this.dbPass);
            this.groupLaunch.Controls.Add(this.lsHide);
            this.groupLaunch.Controls.Add(this.lsRestart);
            this.groupLaunch.Controls.Add(this.label1);
            this.groupLaunch.Controls.Add(this.label7);
            this.groupLaunch.Controls.Add(this.dbUser);
            this.groupLaunch.Controls.Add(this.pathSQL);
            this.groupLaunch.Controls.Add(this.label5);
            this.groupLaunch.Controls.Add(this.label6);
            this.groupLaunch.Controls.Add(this.button5);
            this.groupLaunch.Controls.Add(this.dbDatabase);
            this.groupLaunch.ForeColor = System.Drawing.Color.White;
            this.groupLaunch.Location = new System.Drawing.Point(267, 249);
            this.groupLaunch.Margin = new System.Windows.Forms.Padding(4);
            this.groupLaunch.Name = "groupLaunch";
            this.groupLaunch.Size = new System.Drawing.Size(820, 242);
            this.groupLaunch.TabIndex = 5;
            this.groupLaunch.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(4, 73);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "Launch Client";
            // 
            // buttPgAdmin3
            // 
            this.buttPgAdmin3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttPgAdmin3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttPgAdmin3.FlatAppearance.BorderSize = 0;
            this.buttPgAdmin3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttPgAdmin3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttPgAdmin3.Location = new System.Drawing.Point(513, 176);
            this.buttPgAdmin3.Margin = new System.Windows.Forms.Padding(4);
            this.buttPgAdmin3.Name = "buttPgAdmin3";
            this.buttPgAdmin3.Size = new System.Drawing.Size(280, 32);
            this.buttPgAdmin3.TabIndex = 9;
            this.buttPgAdmin3.Text = "Launch pgAdmin";
            this.buttPgAdmin3.UseVisualStyleBackColor = false;
            this.buttPgAdmin3.Click += new System.EventHandler(this.buttPgAdmin3_Click);
            // 
            // lsAutoLaunch
            // 
            this.lsAutoLaunch.AutoSize = true;
            this.lsAutoLaunch.Checked = true;
            this.lsAutoLaunch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lsAutoLaunch.Location = new System.Drawing.Point(335, 49);
            this.lsAutoLaunch.Margin = new System.Windows.Forms.Padding(4);
            this.lsAutoLaunch.Name = "lsAutoLaunch";
            this.lsAutoLaunch.Size = new System.Drawing.Size(151, 20);
            this.lsAutoLaunch.TabIndex = 9;
            this.lsAutoLaunch.Text = "Automatically launch";
            this.lsAutoLaunch.UseVisualStyleBackColor = true;
            this.lsAutoLaunch.CheckedChanged += new System.EventHandler(this.lsAutoLaunch_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 214);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(660, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "If the client disappears after launch, try wiping the database a few times by cli" +
    "cking the \"Wipe Database\" button.";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(644, 27);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Wipe Postgres";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(4, 4);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(212, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Control Postgres Server";
            // 
            // dbBrowse
            // 
            this.dbBrowse.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // saveSettings
            // 
            this.saveSettings.Interval = 3000;
            this.saveSettings.Tick += new System.EventHandler(this.saveSettings_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.linkDebug);
            this.panel1.Controls.Add(this.linkHelp);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 530);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1252, 39);
            this.panel1.TabIndex = 9;
            // 
            // linkDebug
            // 
            this.linkDebug.ActiveLinkColor = System.Drawing.Color.White;
            this.linkDebug.AutoSize = true;
            this.linkDebug.Dock = System.Windows.Forms.DockStyle.Left;
            this.linkDebug.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkDebug.Location = new System.Drawing.Point(209, 0);
            this.linkDebug.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkDebug.Name = "linkDebug";
            this.linkDebug.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.linkDebug.Size = new System.Drawing.Size(143, 20);
            this.linkDebug.TabIndex = 14;
            this.linkDebug.TabStop = true;
            this.linkDebug.Text = "Show Debug Console";
            this.linkDebug.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDebug_LinkClicked);
            // 
            // linkHelp
            // 
            this.linkHelp.ActiveLinkColor = System.Drawing.Color.White;
            this.linkHelp.AutoSize = true;
            this.linkHelp.Dock = System.Windows.Forms.DockStyle.Left;
            this.linkHelp.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkHelp.Location = new System.Drawing.Point(135, 0);
            this.linkHelp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkHelp.Name = "linkHelp";
            this.linkHelp.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.linkHelp.Size = new System.Drawing.Size(74, 20);
            this.linkHelp.TabIndex = 13;
            this.linkHelp.TabStop = true;
            this.linkHelp.Text = "View Help";
            this.linkHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHelp_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel1.Location = new System.Drawing.Point(0, 0);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.linkLabel1.Size = new System.Drawing.Size(135, 20);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Contribute via Github";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkContribute_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(918, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label2.Size = new System.Drawing.Size(334, 36);
            this.label2.TabIndex = 11;
            this.label2.Text = "Author: limpygnome (limpygnome@gmail.com)\r\nCreative Commons Attribution-ShareAlik" +
    "e 3.0 unported";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Portable_Postgres.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1252, 569);
            this.Controls.Add(this.groupLaunch);
            this.Controls.Add(this.versionText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Portable Postgres - Ubermeat.co.uk FOSS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupLaunch.ResumeLayout(false);
            this.groupLaunch.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lsRestart;
        private System.Windows.Forms.Button lsStop;
        private System.Windows.Forms.Button lsStart;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox pathSQL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox lsHide;
        private System.Windows.Forms.Button lsWipe;
        private System.Windows.Forms.TextBox dbDatabase;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dbPass;
        private System.Windows.Forms.TextBox dbUser;
        private System.Windows.Forms.FolderBrowserDialog dbBrowse;
        private System.Windows.Forms.Timer saveSettings;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel groupLaunch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label versionText;
        private System.Windows.Forms.CheckBox lsAutoLaunch;
        private System.Windows.Forms.Button buttPgAdmin3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkHelp;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkDebug;
        private System.Windows.Forms.Label label12;
    }
}

