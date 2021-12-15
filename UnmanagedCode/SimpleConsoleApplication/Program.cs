using PowerStateManagement;
using System;

namespace SimpleConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var psm = new PowerStateManager();
            DateTime lastSleepTime = psm.GetLastSleepTime();
            DateTime lastWakeTime = psm.GetLastWakeTime();

            Console.WriteLine("last sleep time: " + lastSleepTime);
            Console.WriteLine("last wake time: " + lastWakeTime);
            Console.ReadLine();
        }
    }
}
