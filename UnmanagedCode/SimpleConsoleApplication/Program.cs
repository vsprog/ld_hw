using PowerStateManagement;
using System;

namespace SimpleConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var psm = new PowerStateManager();
            var lastSleepTime = psm.GetLastSleepTime();
            var lastWakeTime = psm.GetLastWakeTime();
            var batteryState = psm.GetSystemBatteryState();
            var powerInfo = psm.GetSystemPowerInformation();

            Console.WriteLine($"last sleep time: {lastSleepTime}");
            Console.WriteLine($"last wake time: {lastWakeTime}\n");

            Console.WriteLine($"battery information: \n{batteryState}");            
            Console.WriteLine($"power information: \n{powerInfo}");
                        
            Console.ReadLine();
        }
    }
}
