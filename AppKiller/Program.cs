using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AppKiller
{
    internal class Program
    {
        async static void Main(string[] args)
        {
            var processesNames = new string[]
            {
                "Steam",
                "steam"
            };
            while (true)
            {
                await KillProcessesByName(Process.GetProcesses(), processesNames);
            }
        }

        async static Task KillProcessesByName(
            IEnumerable<Process> processes,
            IEnumerable<string> processesNames)
        {


            foreach (var process in processes)
            {
                if (processesNames.Contains(process.ProcessName))
                    process.Kill();
            }
            Thread.Sleep(new TimeSpan(0, 1, 0));
        }
    }
}
