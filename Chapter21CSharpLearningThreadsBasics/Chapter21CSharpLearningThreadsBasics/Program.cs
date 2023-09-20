﻿using System;
using System.Threading;

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

            new Thread(() => 
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 1");
            }).Start();

            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 2");
            }).Start();

            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 3");
            }).Start();

        }
    }
}
