using System;
using System.Net;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Asynchronous_Programming
{
    // Here's a simple example of using Task & async/await :-) 
    internal class Program
    {
        static async Task Main()
        {
            /* Task<int> resultTask = AsyncExe.PerformAsyncOperation();

             Console.WriteLine("Doing some other work....");

             int result = await resultTask;

             Console.WriteLine($"Result: {result}");
            */

            /* Console.WriteLine("Starting Tasks...");
            Task task1 = AsyncExe.DownloadAndPrintAsync("https://www.cnn.com");
            Console.WriteLine("Task 1 started...");
            Task task2 = AsyncExe.DownloadAndPrintAsync("https://www.amazon.com");
            Console.WriteLine("Task 2 started...");
            Task task3 = AsyncExe.DownloadAndPrintAsync("https://www.ProgrammingAdvices.com");
            Console.WriteLine("Task 3 started...\n");
            await Task.WhenAll(task1, task2, task3);
            Console.WriteLine("\nDone, all tasks finished execution.");
            */


            /*
            // Subscribe to the event :-)
            AsyncExe.CallbackEvent += AsyncExe.OnCallbackReceived;

            //Create and run a Task for the asynchronous operation, passing CallbackEvent as parameter :-)
            Task performTask = AsyncExe.PerformAsyncOperation(AsyncExe.CallbackEvent);

            // Do some other work while waiting for the task to complete :-)
            Console.WriteLine("Doing some other work....");
            await performTask;

            Console.WriteLine("Done! :-O");
            */

            /*
            Task task1 = Task.Run(() => AsyncExe.DownloadFile("Download File 1"));
            Task task2 = Task.Run(() => AsyncExe.DownloadFile("Download File 2"));

            await Task.WhenAll(task1, task2);

            Console.WriteLine("Task 1 and 2 completed :-)");
            */

            // AsyncExe.ParallelForEx(10);

            // AsyncExe.ParallelForEachEx(AsyncExe.urls);

            AsyncExe.ParallelInvokeEx();
            Console.ReadKey();
        }



    }
}
