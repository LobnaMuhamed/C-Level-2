using System;
using System.Diagnostics;

namespace Event_Log_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourceName = "MyApp";

            if (!EventLog.SourceExists(sourceName))
            {
                EventLog.CreateEventSource(sourceName, "Application");
                Console.WriteLine("Event source created.");
            }
            EventLog.WriteEntry(sourceName, "This is an information event.", EventLogEntryType.Information);

            Console.WriteLine("Event written to the log.");

            Console.ReadLine();
        }
    }
}
