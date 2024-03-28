namespace Portable_Postgres.Panels;

partial class UsrControlPanel
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
        groupLaunch = new System.Windows.Forms.Panel();
        label12 = new System.Windows.Forms.Label();
        buttPgAdmin3 = new System.Windows.Forms.Button();
        cbAutoLaunch = new System.Windows.Forms.CheckBox();
        label8 = new System.Windows.Forms.Label();
        btnPostgres = new System.Windows.Forms.Button();
        btnStart = new System.Windows.Forms.Button();
        label10 = new System.Windows.Forms.Label();
        button4 = new System.Windows.Forms.Button();
        btnWipeDatabase = new System.Windows.Forms.Button();
        btnStop = new System.Windows.Forms.Button();
        dbPass = new System.Windows.Forms.TextBox();
        cbHideServerWindow = new System.Windows.Forms.CheckBox();
        btnRestart = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        label7 = new System.Windows.Forms.Label();
        dbUser = new System.Windows.Forms.TextBox();
        pathSQL = new System.Windows.Forms.TextBox();
        label5 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        btnLaunchClient = new System.Windows.Forms.Button();
        dbDatabase = new System.Windows.Forms.TextBox();
        groupLaunch.SuspendLayout();
        SuspendLayout();
        // 
        // groupLaunch
        // 
        groupLaunch.BackColor = System.Drawing.Color.Transparent;
        groupLaunch.Controls.Add(label12);
        groupLaunch.Controls.Add(buttPgAdmin3);
        groupLaunch.Controls.Add(cbAutoLaunch);
        groupLaunch.Controls.Add(label8);
        groupLaunch.Controls.Add(btnPostgres);
        groupLaunch.Controls.Add(btnStart);
        groupLaunch.Controls.Add(label10);
        groupLaunch.Controls.Add(button4);
        groupLaunch.Controls.Add(btnWipeDatabase);
        groupLaunch.Controls.Add(btnStop);
        groupLaunch.Controls.Add(dbPass);
        groupLaunch.Controls.Add(cbHideServerWindow);
        groupLaunch.Controls.Add(btnRestart);
        groupLaunch.Controls.Add(label1);
        groupLaunch.Controls.Add(label7);
        groupLaunch.Controls.Add(dbUser);
        groupLaunch.Controls.Add(pathSQL);
        groupLaunch.Controls.Add(label5);
        groupLaunch.Controls.Add(label6);
        groupLaunch.Controls.Add(btnLaunchClient);
        groupLaunch.Controls.Add(dbDatabase);
        groupLaunch.ForeColor = System.Drawing.Color.White;
        groupLaunch.Location = new System.Drawing.Point(0, 0);
        groupLaunch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        groupLaunch.Name = "groupLaunch";
        groupLaunch.Size = new System.Drawing.Size(820, 302);
        groupLaunch.TabIndex = 6;
        groupLaunch.Visible = false;
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.BackColor = System.Drawing.Color.Transparent;
        label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        label12.ForeColor = System.Drawing.Color.White;
        label12.Location = new System.Drawing.Point(4, 91);
        label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label12.Name = "label12";
        label12.Size = new System.Drawing.Size(125, 20);
        label12.TabIndex = 12;
        label12.Text = "Launch Client";
        // 
        // buttPgAdmin3
        // 
        buttPgAdmin3.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
        buttPgAdmin3.Cursor = System.Windows.Forms.Cursors.Hand;
        buttPgAdmin3.FlatAppearance.BorderSize = 0;
        buttPgAdmin3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        buttPgAdmin3.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
        buttPgAdmin3.Location = new System.Drawing.Point(513, 220);
        buttPgAdmin3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        buttPgAdmin3.Name = "buttPgAdmin3";
        buttPgAdmin3.Size = new System.Drawing.Size(280, 40);
        buttPgAdmin3.TabIndex = 9;
        buttPgAdmin3.Text = "Launch pgAdmin";
        buttPgAdmin3.UseVisualStyleBackColor = false;
        // 
        // cbAutoLaunch
        // 
        cbAutoLaunch.AutoSize = true;
        cbAutoLaunch.Checked = true;
        cbAutoLaunch.CheckState = System.Windows.Forms.CheckState.Checked;
        cbAutoLaunch.Location = new System.Drawing.Point(335, 61);
        cbAutoLaunch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        cbAutoLaunch.Name = "cbAutoLaunch";
        cbAutoLaunch.Size = new System.Drawing.Size(170, 24);
        cbAutoLaunch.TabIndex = 9;
        cbAutoLaunch.Text = "Automatically launch";
        cbAutoLaunch.UseVisualStyleBackColor = true;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new System.Drawing.Point(44, 268);
        label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(752, 20);
        label8.TabIndex = 11;
        label8.Text = "If the client disappears after launch, try wiping the database a few times by clicking the \"Wipe Database\" button.";
        // 
        // btnPostgres
        // 
        btnPostgres.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
        btnPostgres.Cursor = System.Windows.Forms.Cursors.Hand;
        btnPostgres.FlatAppearance.BorderSize = 0;
        btnPostgres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnPostgres.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
        btnPostgres.Location = new System.Drawing.Point(644, 34);
        btnPostgres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        btnPostgres.Name = "btnPostgres";
        btnPostgres.Size = new System.Drawing.Size(125, 40);
        btnPostgres.TabIndex = 5;
        btnPostgres.Text = "Wipe Postgres";
        btnPostgres.UseVisualStyleBackColor = false;
        // 
        // btnStart
        // 
        btnStart.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
        btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
        btnStart.FlatAppearance.BorderSize = 0;
        btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnStart.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
        btnStart.Location = new System.Drawing.Point(11, 34);
        btnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        btnStart.Name = "btnStart";
        btnStart.Size = new System.Drawing.Size(100, 40);
        btnStart.TabIndex = 0;
        btnStart.Text = "Start";
        btnStart.UseVisualStyleBackColor = false;
        btnStart.Click += btnStart_Click;
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.BackColor = System.Drawing.Color.Transparent;
        label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
        label10.ForeColor = System.Drawing.Color.White;
        label10.Location = new System.Drawing.Point(4, 5);
        label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label10.Name = "label10";
        label10.Size = new System.Drawing.Size(212, 20);
        label10.TabIndex = 8;
        label10.Text = "Control Postgres Server";
        // 
        // button4
        // 
        button4.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
        button4.Cursor = System.Windows.Forms.Cursors.Hand;
        button4.FlatAppearance.BorderSize = 0;
        button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        button4.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
        button4.Location = new System.Drawing.Point(693, 138);
        button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        button4.Name = "button4";
        button4.Size = new System.Drawing.Size(100, 35);
        button4.TabIndex = 3;
        button4.Text = "Browse";
        button4.UseVisualStyleBackColor = false;
        // 
        // btnWipeDatabase
        // 
        btnWipeDatabase.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
        btnWipeDatabase.Cursor = System.Windows.Forms.Cursors.Hand;
        btnWipeDatabase.FlatAppearance.BorderSize = 0;
        btnWipeDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnWipeDatabase.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
        btnWipeDatabase.Location = new System.Drawing.Point(501, 34);
        btnWipeDatabase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        btnWipeDatabase.Name = "btnWipeDatabase";
        btnWipeDatabase.Size = new System.Drawing.Size(135, 40);
        btnWipeDatabase.TabIndex = 4;
        btnWipeDatabase.Text = "Wipe Database";
        btnWipeDatabase.UseVisualStyleBackColor = false;
        btnWipeDatabase.Click += btnWipeDatabase_Click;
        // 
        // btnStop
        // 
        btnStop.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
        btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
        btnStop.FlatAppearance.BorderSize = 0;
        btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnStop.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
        btnStop.Location = new System.Drawing.Point(119, 34);
        btnStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        btnStop.Name = "btnStop";
        btnStop.Size = new System.Drawing.Size(100, 40);
        btnStop.TabIndex = 1;
        btnStop.Text = "Stop";
        btnStop.UseVisualStyleBackColor = false;
        btnStop.Visible = false;
        btnStop.Click += btnStop_Click;
        // 
        // dbPass
        // 
        dbPass.Location = new System.Drawing.Point(309, 180);
        dbPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        dbPass.Name = "dbPass";
        dbPass.Size = new System.Drawing.Size(195, 27);
        dbPass.TabIndex = 6;
        // 
        // cbHideServerWindow
        // 
        cbHideServerWindow.AutoSize = true;
        cbHideServerWindow.Checked = true;
        cbHideServerWindow.CheckState = System.Windows.Forms.CheckState.Checked;
        cbHideServerWindow.Location = new System.Drawing.Point(335, 34);
        cbHideServerWindow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        cbHideServerWindow.Name = "cbHideServerWindow";
        cbHideServerWindow.Size = new System.Drawing.Size(162, 24);
        cbHideServerWindow.TabIndex = 3;
        cbHideServerWindow.Text = "Hide server window";
        cbHideServerWindow.UseVisualStyleBackColor = true;
        // 
        // btnRestart
        // 
        btnRestart.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
        btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
        btnRestart.FlatAppearance.BorderSize = 0;
        btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnRestart.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
        btnRestart.Location = new System.Drawing.Point(227, 34);
        btnRestart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        btnRestart.Name = "btnRestart";
        btnRestart.Size = new System.Drawing.Size(100, 40);
        btnRestart.TabIndex = 2;
        btnRestart.Text = "Restart";
        btnRestart.UseVisualStyleBackColor = false;
        btnRestart.Click += btnRestart_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new System.Drawing.Point(7, 115);
        label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(279, 20);
        label1.TabIndex = 0;
        label1.Text = "Select the path containing your SQL files:";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new System.Drawing.Point(512, 185);
        label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(75, 20);
        label7.TabIndex = 9;
        label7.Text = "Database:";
        // 
        // dbUser
        // 
        dbUser.Location = new System.Drawing.Point(69, 180);
        dbUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        dbUser.Name = "dbUser";
        dbUser.Size = new System.Drawing.Size(179, 27);
        dbUser.TabIndex = 5;
        dbUser.Text = "root";
        // 
        // pathSQL
        // 
        pathSQL.Location = new System.Drawing.Point(11, 140);
        pathSQL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        pathSQL.Name = "pathSQL";
        pathSQL.Size = new System.Drawing.Size(673, 27);
        pathSQL.TabIndex = 1;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new System.Drawing.Point(19, 185);
        label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(41, 20);
        label5.TabIndex = 7;
        label5.Text = "User:";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new System.Drawing.Point(257, 185);
        label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(39, 20);
        label6.TabIndex = 8;
        label6.Text = "Pass:";
        // 
        // btnLaunchClient
        // 
        btnLaunchClient.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
        btnLaunchClient.Cursor = System.Windows.Forms.Cursors.Hand;
        btnLaunchClient.FlatAppearance.BorderSize = 0;
        btnLaunchClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnLaunchClient.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
        btnLaunchClient.Location = new System.Drawing.Point(7, 220);
        btnLaunchClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        btnLaunchClient.Name = "btnLaunchClient";
        btnLaunchClient.Size = new System.Drawing.Size(499, 40);
        btnLaunchClient.TabIndex = 4;
        btnLaunchClient.Text = "Launch Client (psql)";
        btnLaunchClient.UseVisualStyleBackColor = false;
        btnLaunchClient.Visible = false;
        // 
        // dbDatabase
        // 
        dbDatabase.Location = new System.Drawing.Point(595, 180);
        dbDatabase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        dbDatabase.Name = "dbDatabase";
        dbDatabase.Size = new System.Drawing.Size(197, 27);
        dbDatabase.TabIndex = 10;
        dbDatabase.Text = "postgres";
        // 
        // UsrControlPanel
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackgroundImage = Properties.Resources.background;
        BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        Controls.Add(groupLaunch);
        Name = "UsrControlPanel";
        Size = new System.Drawing.Size(821, 303);
        groupLaunch.ResumeLayout(false);
        groupLaunch.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel groupLaunch;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Button buttPgAdmin3;
    private System.Windows.Forms.CheckBox cbAutoLaunch;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Button btnPostgres;
    private System.Windows.Forms.Button btnStart;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button btnWipeDatabase;
    private System.Windows.Forms.Button btnStop;
    private System.Windows.Forms.TextBox dbPass;
    private System.Windows.Forms.CheckBox cbHideServerWindow;
    private System.Windows.Forms.Button btnRestart;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox dbUser;
    private System.Windows.Forms.TextBox pathSQL;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button btnLaunchClient;
    private System.Windows.Forms.TextBox dbDatabase;
}
