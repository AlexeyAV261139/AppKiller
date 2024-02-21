using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace AppKiller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var processesNames = new string[]
            {
                "Steam",
                "steam"
            };
            while (true)
            {                
                foreach (var process in Process.GetProcesses())
                {
                    if (processesNames.Contains(process.ProcessName))
                    {
                        process.Kill();

                    }
                }
                Thread.Sleep(new TimeSpan(0, 1, 0));
            }
        }
    }
}
