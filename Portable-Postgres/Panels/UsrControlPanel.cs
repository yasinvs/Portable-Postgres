using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Portable_Postgres.Business;

namespace Portable_Postgres.Panels;
public partial class UsrControlPanel : UserControl
{
    public UsrControlPanel()
    {
        InitializeComponent();
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
        PostgresServer.StartServer();

        if (PostgresServer.CheckServer())
        {
            btnStart.Visible = false;
            btnStop.Visible = true;
            btnLaunchClient.Visible = true;
        }
    }

    private void btnStop_Click(object sender, EventArgs e)
    {
        PostgresServer.StopServer();

        if (!PostgresServer.CheckServer())
        {
            btnStart.Visible = true;
            btnStop.Visible = false;
            btnLaunchClient.Visible = false;
        }
    }

    private void btnRestart_Click(object sender, EventArgs e)
    {
        PostgresServer.StopServer();
        PostgresServer.StartServer();

        if (PostgresServer.CheckServer())
        {
            btnStart.Visible = false;
            btnStop.Visible = true;
            btnLaunchClient.Visible = true;
        }
    }

    private async void btnWipeDatabase_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show(this, "Do you really want to wipe the database?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        {
            PostgresServer.StopServer();
            PostgresServer.KillServer();
            await Task.Delay(3000);
            DatabaseControl.DatabaseWipe();
        }
    }
}
