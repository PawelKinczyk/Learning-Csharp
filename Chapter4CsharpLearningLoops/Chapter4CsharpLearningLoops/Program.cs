using System;

namespace Chapter4CsharpLearningLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // do & while loop
            int lenghtOfText = 0;
            int counter = 0;
            do
            {
                Console.WriteLine("Please enter word");
                string word = Console.ReadLine();
                lenghtOfText = word.Length;
                counter++;
            } while (counter <= lenghtOfText);
            Console.ReadLine();
        }
    }
}
