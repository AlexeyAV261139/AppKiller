using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AppKiller
{
    internal class Program
    {
        async static Task Main(string[] args)
        {          

            while (true)
            {

            }

        }



        static void KillProcessesByName(
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

    public class ProcessManager
    {        
        public Process Process { get; private set; }

        private SpendTimeChecker _timeChecker;

        public ProcessManager(Process process)
        {
            var timeLimit = new TimeSpan(2, 0, 0);
            _timeChecker = new SpendTimeChecker(timeLimit, process);
            Process = process;
        }

        public async Task StartTracking()
        {
            
                CheckGameActive()


                if (_timeChecker.TimeIsOver())
                {
                    Process.Kill();
                }  
            
        }

        private async Task CheckGameActive(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                var delay = Task.Delay(new TimeSpan(0, 1, 0));

                _timeChecker.CheckGameActive(Process);

                await Task.WhenAll(delay);
            }
        }

    public class SpendTimeChecker
    {
        public Process Process { get; private set; }

        private Stopwatch _stopwatch;
        public readonly TimeSpan timeToStop;

        public SpendTimeChecker(TimeSpan timeToStop, Process process)
        {
            this.timeToStop = timeToStop;
            Process = process;
        }

        public void CheckGameActive(Process trackingProcess)
        {
            foreach (var process in Process.GetProcesses())
            {
                if (process == trackingProcess)
                {
                    if (!_stopwatch.IsRunning)
                    {
                        _stopwatch.Start();                       
                    }
                    return;
                }
            }
            _stopwatch.Stop();
        }

        public bool TimeIsOver()
        {
            if (_stopwatch.Elapsed > timeToStop)
            {
                _stopwatch.Reset();
                return true;
            }
            return false;
        }

    }
}
