using System;
using System.Threading;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            var parent = Task.Factory.StartNew(() =>
            {
                Console.WriteLine($"parent thread #{Thread.CurrentThread.ManagedThreadId}, task: {Task.CurrentId}");
                return Divide(1, 0);
            });

            var child = parent.ContinueWith(t => {
                Console.WriteLine($"child thread #{Thread.CurrentThread.ManagedThreadId}, task: {Task.CurrentId}");
                if (t.IsFaulted)
                {
                    Exception ex = t.Exception;
                    while (ex is AggregateException && ex.InnerException != null)
                        ex = ex.InnerException;
                    Console.WriteLine("Error: " + ex.Message);
                }
                else if (t.IsCanceled)
                {
                    Console.WriteLine("Canceled");
                }
                else
                {
                    //Console.WriteLine($"child thread #{Thread.CurrentThread.ManagedThreadId}, task: {Task.CurrentId}");
                    Console.WriteLine("Result: " + t.Result);
                }
            }, TaskContinuationOptions.ExecuteSynchronously); // TaskScheduler.FromCurrentSynchronizationContext()

            child.Wait();

            Console.ReadLine();
        }

        private static Double Divide(int x, int y)
        {
            if (y == 0) throw new ArgumentException("Exception happened");
            return x / y;
        }
    }
}
