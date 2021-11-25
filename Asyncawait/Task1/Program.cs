using System;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number. To finish, type 'exit'.");

            string input = Console.ReadLine();
            CancellationTokenSource tokenSource = new CancellationTokenSource();

            Action<string, CancellationToken> CountAsync = async (input, token) =>
            {
                string result = string.Empty;

                try
                {
                    result = await Task.Run(() => {
                        if (long.TryParse(input, out long number)) 
                            return $"Result is {Count(number, token)}";
                        return "Enter number.";
                    }, token);
                }
                catch (OperationCanceledException)
                {
                    result = "Operation canceled.";
                }

                Console.WriteLine(result);
            };

            while (!input.Equals("exit", StringComparison.OrdinalIgnoreCase))
            {
                CountAsync(input, tokenSource.Token);
                input = Console.ReadLine();
                
                tokenSource.Cancel();
                tokenSource.Dispose();
                tokenSource = new CancellationTokenSource();
            }

            Console.ReadLine();
        }

        private static long Count(long max, CancellationToken token)
        {
            long result = 0;

            for (long i = 0; i <= max; i++)
            {
                token.ThrowIfCancellationRequested();
                result += i;
            }
            
            return result;
        }
    }
}
