using System;
using System.Collections.Generic;
using System.Threading;

namespace Task6
{
    class Program
    {
        private static readonly List<int> shared = new List<int>();
        private static readonly object sync = new object();
        
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Add);
            Thread t2 = new Thread(Print);
            
            t1.Start();
            t2.Start();
            
            Console.ReadLine();
        }

        private static void Add()
        {

            for (int i = 0; i < 10; i++)
            {
                lock (sync)
                {
                    shared.Add(i);
                    Monitor.Pulse(sync);
                    Monitor.Wait(sync);
                }
            }
        }

        private static void Print()
        {

            for (int i = 0; i < 10; i++)
            {
                lock (sync)
                {
                    Monitor.Wait(sync, 10);
                    foreach (var d in shared) Console.Write(d + " ");
                    Console.WriteLine();
                    Monitor.Pulse(sync);
                }
            }
        }
    }
}
