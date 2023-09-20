using System;
using System.Threading;

namespace Chapter21CSharpLearningThreadsJoining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread started");
            Thread thread1 = new Thread(ThreadFunction);
            Thread thread2 = new Thread(ThreadFunction2);
            thread1.Start();
            thread2.Start();
            // "Connect" threads with main code with join
            // Print different text depends of thread time
            if (thread1.Join(1000))
            {
                Console.WriteLine("ThreadFunction done in 1 sec");
            }
            else
            {
                Console.WriteLine("Threads wasn't done in 1 sec");
            }
            thread2.Join();
            Console.WriteLine("ThreadFunction2 done");
            // Check that thread1 is still working
            for (int i = 0; i < 100; i++)
            {
                if (thread1.IsAlive)
                {
                    Console.WriteLine("Thread is still doing stuff");
                    Thread.Sleep(500);
                }
                else
                {
                    Console.WriteLine("Thread 1 completed");
                }
            }
            Console.WriteLine("Main thread ended");
        }

        public static void ThreadFunction()
        {
            Console.WriteLine("ThreadFunction started");
            Thread.Sleep(3000);
            Console.WriteLine("ThreadFunction coming back to caller");
        }

        public static void ThreadFunction2()
        {
            Console.WriteLine("ThreadFunction2 started");
        }
    }
}
