using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Portable_Postgres.Entities;

namespace Portable_Postgres
{
    public partial class FrmInstallSettings : Form
    {
        public DbSettings dbSettings = new DbSettings();
        #region "Constants"
        /// <summary>
        /// The maximum length of names; derived from:
        /// http://doxygen.postgresql.org/pg__config__manual_8h_source.html
        /// </summary>
        public const int NAMEDATALEN = 64;
        #endregion
        #region "Methods - Variables"
        public string settingsDatabase = null, settingsUser = null, settingsPass = null;
        #endregion
        #region "Methods - Properties"
        public string Settings_Database
        {
            get
            {
                return settingsDatabase;
            }
        }
        public string Settings_User
        {
            get
            {
                return settingsUser;
            }
        }
        public string Settings_Pass
        {
            get
            {
                return settingsPass;
            }
        }
        #endregion
        #region "Methods - Constructors"
        public FrmInstallSettings()
        {
            InitializeComponent();
        }
        #endregion
        #region "Methods - Event Handlers"
        private void buttCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void buttInstall_Click(object sender, EventArgs e)
        {
            if (txtDatabase.TextLength < 1 || txtDatabase.TextLength > NAMEDATALEN)
                MessageBox.Show("Database length must be between 1 to " + NAMEDATALEN + " characters in length!", "Invalid Length", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if(txtUser.TextLength < 1 || txtUser.TextLength > NAMEDATALEN)
                MessageBox.Show("Username length must be between 1 to " + NAMEDATALEN + " characters in length!", "Invalid Length", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txtPass.TextLength > NAMEDATALEN)
                MessageBox.Show("Password length must be between 1 to " + NAMEDATALEN + " characters in length!", "Invalid Length", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if(txtUser.Text == "root" && txtPass.TextLength > 0)
                MessageBox.Show("User 'root' cannot have a password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txtDatabase.Text.Length == 0 || txtUser.Text.Length == 0 || txtPass.Text.Length == 0)
            {
                MessageBox.Show(this, "Please enter all the required fields...", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dbSettings.Database = txtDatabase.Text;
                dbSettings.Username = txtUser.Text; 
                dbSettings.Password = txtPass.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void FrmInstallSettings_Load(object sender, EventArgs e)
        {

        }

        private void buttPassHide_Click(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
            buttPassHide.Visible = false;
            buttPassShow.Visible = true;
        }
        private void buttPassShow_Click(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '\0';
            buttPassShow.Visible = false;
            buttPassHide.Visible = true;
        }
        #endregion
    }
}
