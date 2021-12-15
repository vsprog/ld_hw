using PowerStateManagement;
using System;
using System.Reflection;

namespace SimpleConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var psm = new PowerStateManager();
            DateTime lastSleepTime = psm.GetLastSleepTime();
            DateTime lastWakeTime = psm.GetLastWakeTime();
            var batteryState = psm.GetSystemBatteryState();
            var powerInfo = psm.GetSystemPowerInformation();

            Console.WriteLine($"last sleep time: {lastSleepTime}");
            Console.WriteLine($"last wake time: {lastWakeTime}\n");

            Console.WriteLine("battery information: ");
            LogStruct(batteryState);
            Console.WriteLine();

            Console.WriteLine("power information: ");
            LogStruct(powerInfo);
            Console.WriteLine();
            
            Console.ReadLine();
        }

        private static void LogStruct<T>(T structure)
        {
            foreach (var field in typeof(T).GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public))
            {
                Console.WriteLine($"{field.Name} = {field.GetValue(structure)}");
            }
        }
    }
}
