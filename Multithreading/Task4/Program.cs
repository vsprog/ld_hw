using System;
using System.Threading;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = 10;
            int number = 100;

            ThreadDelegate((number, times));
            Console.ReadLine();
        }

        private static void ThreadDelegate(object state)
        {
            (int number, int times) = ((int, int))state;

            if (times != 0)
            {
                number--;
                Console.WriteLine(number);
                Thread thread = new Thread(ThreadDelegate);
                Console.WriteLine($"thread #{thread.ManagedThreadId}");
                thread.Start((number, --times));
                thread.Join();
            }
        }
    }
}
