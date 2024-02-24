using System;
using System.Threading.Tasks;

namespace AppKiller
{
    internal class Program
    {
        async static Task Main(string[] args)
        {
            var processManager = new ProcessManager("Steam", new TimeSpan(0, 0, 5));
            _ = processManager.StartTracking();
            Console.ReadKey();
        }
    }
}
