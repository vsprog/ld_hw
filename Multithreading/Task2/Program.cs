using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Task.Run(() => {
                var result = Enumerable.Range(1, 10)
                    .Select(r => rand.Next(100))
                    .ToList();
                Print(result);
                return result;
            }).ContinueWith(nums => {
                int randomNumber = rand.Next(100);
                var result = nums.Result.Select(x => x * randomNumber);
                Print(result);
                return result;
            }).ContinueWith(nums => {
                var result = nums.Result.OrderBy(x => x);
                Print(result);
                return result;
            }).ContinueWith(nums => {
                var result = nums.Result.Average();
                Console.WriteLine($"average: {result}");
            });

            Console.ReadLine();
        }

        private static void Print(IEnumerable<int> numbers)
        {
            var last = numbers.Last();
            Console.Write("sequence: ");
            foreach (int n in numbers)
                Console.Write($"{n} {(n.Equals(last) ? "" : ", ")}");
            Console.WriteLine();
        }
    }
}
