using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 'd [resource]' to download, 'c [index]' to cancel or 'q' to quit.");
            int id = 0;
            var queue = new Dictionary<int, CancellationTokenSource>();
            
            while (true)
            {
                string input = Console.ReadLine();
                string[] arguments = input.Split(' ');
                
                switch (arguments[0])
                {
                    case "d":
                        var tokenSource = new CancellationTokenSource();
                        queue.Add(++id, tokenSource);
                        DownloadAsync(arguments[1], tokenSource.Token);
                        Console.WriteLine($"process id: {id}");
                        break;
                    case "c":
                        if (arguments.Length == 2 && int.TryParse(arguments[1], out int currentId))
                        {
                            if (queue.TryGetValue(currentId, out CancellationTokenSource cts))
                            {
                                cts.Cancel();
                                queue.Remove(currentId);
                                Console.WriteLine($"process {currentId} canceled");
                            }
                            else Console.WriteLine($"process {currentId} not found");
                        }
                        break;
                    case "q":
                        return;
                    default:
                        break;
                }
            }
        }

        private static async void DownloadAsync(string url, CancellationToken token)
        {
            string fileName = url.Split('/').Last();
            var destinationFilePath = Path.GetFullPath($"C:\\projects\\{fileName}-{Guid.NewGuid()}");
            
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    Console.WriteLine($"{fileName} is downloading...");
                    var response = await client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead, token);
                    await DownloadFileFromHttpResponseMessage(response, destinationFilePath, token);
                    Console.WriteLine($"{fileName} is downloaded");
                }
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine($"{fileName} downloading is canceled");
            }
        }

        private static async Task DownloadFileFromHttpResponseMessage(HttpResponseMessage response, string outputDirectory, CancellationToken token)
        {
            response.EnsureSuccessStatusCode();

            using (var contentStream = await response.Content.ReadAsStreamAsync())
            using (var fileStream = new FileStream(outputDirectory, FileMode.Create, FileAccess.Write, FileShare.None, 8192, true))
            {
                token.ThrowIfCancellationRequested();
                await contentStream.CopyToAsync(fileStream , token);
            }
        }
    }    
}
