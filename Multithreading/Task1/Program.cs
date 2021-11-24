using System;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task[] tasks = new Task[100];

            for (int i = 0; i < tasks.Length; i++)
            {
                int taskNum = i;
                tasks[i] = new Task(() => Count(taskNum));
            }

            foreach (var t in tasks) t.Start();
            Task.WaitAll(tasks);

            Console.WriteLine("Completion of the method Main.");
            Console.ReadLine();
        }

        private static void Count(int taskNum)
        {
            int count = 1;

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"Task #{taskNum} – {count++}");
            }
        }
    }
}
