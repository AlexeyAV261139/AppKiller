using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AppKiller
{
    public class ProcessManager
    {
        public string ProcessName { get; private set; }

        private ProcessLiveTimeChecker _timeChecker;
        private TimeSpan _optimalCheckDelay;

        public ProcessManager(string processName, TimeSpan timeLimit)
        {
            ProcessName = processName;
            _timeChecker = new ProcessLiveTimeChecker(timeLimit, processName);
            _optimalCheckDelay = GetOptimalDelay(timeLimit);
        }

        public async Task StartTracking()
        {
            try
            {
                while (true)
                {
                    _timeChecker.CheckGameActive();
                    if (_timeChecker.IsTimeOver())
                        Process.GetProcessesByName(ProcessName).FirstOrDefault()?.Kill();

                    await Task.Delay(_optimalCheckDelay);
                }
               
            }
            catch { }
        }

        private TimeSpan GetOptimalDelay(TimeSpan processLifeTimeLimit)
        {
            if (processLifeTimeLimit <= new TimeSpan(0, 1, 0))
            {
                return new TimeSpan(0, 0, 15);
            }
            return new TimeSpan(0, 1, 0);
        }
    }
}
