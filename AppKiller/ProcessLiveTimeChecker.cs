using System;
using System.Diagnostics;
using System.Linq;

namespace AppKiller
{
    public class ProcessLiveTimeChecker
    {
        public string TrackingProcessName { get; private set; }
        public TimeSpan TimeToStop { get; private set; }

        private Stopwatch _stopwatch;

        public ProcessLiveTimeChecker(TimeSpan timeToStop, string processName)
        {
            _stopwatch = new Stopwatch();
            TimeToStop = timeToStop;
            TrackingProcessName = processName;
        }

        public void CheckGameActive()
        {
            var process = Process.GetProcessesByName(TrackingProcessName).FirstOrDefault();
            if (process is null)
            {
                _stopwatch.Stop();
                return;
            }
            if (!_stopwatch.IsRunning)
            {
                _stopwatch.Start();
            }
        }

        public bool IsTimeOver()
        {
            if (_stopwatch.Elapsed > TimeToStop)
            {
                _stopwatch.Reset();
                return true;
            }
            return false;
        }

    }
}
