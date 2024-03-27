using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portable_Postgres.Business
{
    public class ProcessOutput
    {
        public Process proc;
        public ProcessOutput(string filename, string args, bool wait = false)
        {
            proc = new Process();
            proc.StartInfo.FileName = filename;
            proc.StartInfo.Arguments = args;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.RedirectStandardOutput = true;

            if (wait)
            {
                proc.WaitForExit();
            }
        }

        public void start()
        {
            proc.Start();
        }
    }
}
