using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Asynchronous_Programming
{
    internal class AsyncExe
    {

        public static async Task<int> PerformAsyncOperation()
        {
            await Task.Delay(4000);

            return 42;
        }
        public static async Task DownloadAndPrintAsync(string url)
        {
            string content;
            using (WebClient client = new WebClient())
            {
                await Task.Delay(100);
                content = await client.DownloadStringTaskAsync(url);
            }
            Console.WriteLine($"{url}: {content.Length} character downloaded ;-)");
        }

        public class CustomeEventArgs : EventArgs
        {
            public int Parm1 { get; }
            public string Parm2 { get; }
            public CustomeEventArgs(int parm1, string parm2)
            {
                Parm1 = parm1;
                Parm2 = parm2;
            }
        }
        public delegate void CallbackEventHandler(object sender, CustomeEventArgs e);
        public static CallbackEventHandler CallbackEvent;
        public static async Task PerformAsyncOperation(CallbackEventHandler callback)
        {
            // Simulate an asynchronous operation
            await Task.Delay(2000);

            // Create event arguments with two parameters
            CustomeEventArgs eventArgs = new CustomeEventArgs(23, "Hello From Event ;-)");
            callback?.Invoke(null, eventArgs);
        }
        public static void OnCallbackReceived(object sender, CustomeEventArgs e)
        {
            Console.WriteLine($"Event received: Parameter 1 - {e.Parm1}, Parameter 2 - {e.Parm2}");
        }




        // TASK.RUN() 

        public static void DownloadFile(string TaskName)
        {
            Console.WriteLine($"{TaskName}: Started!");
            Thread.Sleep(5000);
            Console.WriteLine($"{TaskName}: Completed!");
        }

        // Parallel.For()

        public static void ParallelForEx(int numberOfIterations = 10)
        {
            Parallel.For(0, numberOfIterations, i =>
            {
                Console.WriteLine($"Executing iteration {i} on thread {Task.CurrentId}");
                Task.Delay(1000).Wait();
            });
            Console.WriteLine("All iterations completed :-)");

        }


        // Parallel.ForEach()

        public static List<string> urls = new List<string>
        {
            "https://www.cnn.com",
        "https://www.amazon.com",
        "https://www.programmingadvices.com"
        };

        static void DownloadContent(string url)
        {
            string content;
            using (WebClient client = new WebClient())
            {
                Thread.Sleep(1000);
                content = client.DownloadString(url);
            }
            Console.WriteLine($"{url}: {content.Length} characters downloaded");
        }

        public static void ParallelForEachEx(List<string> strings)
        {
            Parallel.ForEach(strings, url =>
            {
                DownloadContent(url);
            });
            Console.WriteLine("Done!");

        }
        // Parallel.Invoke()

        public static void ParallelInvokeEx()
        {
            Parallel.Invoke(
                () => Console.WriteLine($"Action 1 on thread {Task.CurrentId}"),
                () => Console.WriteLine($"Action 2 on thread {Task.CurrentId}"),
                () => Console.WriteLine($"Action 3 on thread {Task.CurrentId}")
                );

        }
    }
}
