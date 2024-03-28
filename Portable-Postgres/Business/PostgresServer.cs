using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Portable_Postgres.Entities;

namespace Portable_Postgres.Business
{
    public static class PostgresServer
    {
        public static void StartServer(bool hideWindow = true)
        {
            DotNetProcessStartManager.ProcessStart(new ProcessStart()
            {
                FileName = $"{Application.StartupPath}\\Postgres\\pgsql\\bin\\pg_ctl.exe",
                FileParameters = "start -D \"" + Application.StartupPath + "\\Postgres\\Database" + "\"",
                HideWindow = hideWindow,
                WaitProcess = false
            });
        }

        public static void StopServer()
        {
            throw new NotImplementedException();
        }

        public static void KillServer()
        {
            try
            {
                foreach (Process proc in Process.GetProcessesByName("postgres"))
                    proc.Kill();
            }
            catch { }
        }

        public static NpgsqlConnection GetNpgsqlConnection(string database, string ip, string port, string userName, string password)
        {
            NpgsqlConnection conn = new NpgsqlConnection($"Server={ip};Port={port};User Id={userName};Password={password};Database={database};");
            conn.Open();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
                return conn;
            }

            return null;
        }

        public static bool CheckServer()
        {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            int tickStart = Environment.TickCount;
            bool sConnected = false;

            while (Environment.TickCount - tickStart < 20000 && !sConnected)
            {
                try
                {
                    s.Connect("127.0.0.1", 5432);
                    sConnected = true;
                    s.Disconnect(true);
                    s = null;

                    return true;
                }
                catch { }
            }

            return false;
        }

        public static Socket ConnectServer()
        {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            int tickStart = Environment.TickCount;
            bool sConnected = false;

            while (Environment.TickCount - tickStart < 20000 && !sConnected)
            {
                try
                {
                    s.Connect("127.0.0.1", 5432);
                    sConnected = true;
                    s = null;

                    return s;
                }
                catch { }
            }

            return null;
        }
    }
}
