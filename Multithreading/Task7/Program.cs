using System;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            var parent = Task.Factory.StartNew(() => Divide(1, 0));

            var child = parent.ContinueWith(t => {
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
                    Console.WriteLine("Result: " + t.Result);
                }
            });

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
