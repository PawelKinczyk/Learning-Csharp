using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter21CSharpLearningThreadsBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World 1!");
            //Thread.Sleep(1000);
            //Console.WriteLine("Hello World 2!");
            //Console.WriteLine("Hello World 3!");
            //Console.WriteLine("Hello World 4!");

            //new Thread(() => 
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Thread 1");
            //}).Start();

            //new Thread(() =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Thread 2");
            //}).Start();

            //new Thread(() =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Thread 3");
            //}).Start();

            //new Thread(() =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Thread 4");
            //}).Start();

            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 4");
            })
            { IsBackground = true }.Start();
            
            Enumerable.Range(0, 100).ToList().ForEach(f =>
            {
                new Thread(() =>
                {
                    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
                    Thread.Sleep(1000);
                }).Start();
            });

            Console.ReadLine();
        }
    }
}
