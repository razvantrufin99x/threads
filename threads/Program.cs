using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace threads
{
    class Program
    {
        private static void ThreadFunc()
        {
            Console.WriteLine("Hello from new thread {0}!",
            Thread.CurrentThread.GetHashCode());
        }

        static void Main(string[] args)
        {
            // Create the new thread.
            Thread newThread = new Thread(new ThreadStart(Program.ThreadFunc));
            Console.WriteLine("Main Thread is {0}",
            Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Starting new thread...");
            // Start the new thread.
            newThread.Start();
            // Wait for new thread to finish.
            newThread.Join();
            Console.WriteLine("New thread has finished");
            Console.ReadKey();
        }
    }
}
