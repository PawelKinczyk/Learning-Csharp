using System;

namespace Chapter10CSharpLearningMathClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ceiling: " + Math.Ceiling(13.4));
            Console.WriteLine("Floor: " + Math.Floor(13.4));
            Console.WriteLine("The min num from 2 and 5 is " + Math.Min(2, 5));
            Console.WriteLine("2 to power of 4 is " + Math.Pow(2, 4));
            Console.WriteLine("PI is " + Math.PI);
            Console.WriteLine("Square root of 16 is " + Math.Sqrt(16));
            Console.WriteLine("Always positive " + Math.Abs(-23));
            Console.WriteLine("Cos of 1 is ", Math.Cos(1));
        
        Random dice = new Random();
            int numEyes;

            for(int i = 0; i < 10; i++)
            {
                numEyes = dice.Next(1, 7);
                Console.WriteLine(numEyes);
            }
            Console.ReadLine();
        
        }
    }
}
