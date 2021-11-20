using System;
using System.Threading;

namespace Task5
{
    class Program
    {
        static Semaphore sem = new Semaphore(1, 1);

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
                sem.WaitOne();
                
                number--;
                Console.WriteLine(number);
                Console.WriteLine($"thread #{Thread.CurrentThread.ManagedThreadId}");
                ThreadPool.QueueUserWorkItem(ThreadDelegate, (number, --times));

                sem.Release();
            }
        }
    }
}
