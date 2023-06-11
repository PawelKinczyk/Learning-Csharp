using System;

namespace Chapter4CsharpLearningDecisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string temperature = Console.ReadLine();
            int number;
            int numberTemp;

            if(int.TryParse(temperature, out number))
            {
                numberTemp = number;
            }
            else
            {
                numberTemp = 0;
            }
            Console.WriteLine(numberTemp);
            CheckTemp(numberTemp);
            Console.ReadLine();
        }
        public static void Check(int number)
        {
            // TODO
            // string number;
            // number = Console.ReadLine();
            int restOfDivision;

            restOfDivision = number % 2;
            if (restOfDivision == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

        }
        public static void CheckTemp(int temp)
        {
            switch (temp)
            {
                case <= 15:
                    Console.WriteLine("it is too cold here");
                    break;
                case >= 16 and <= 28:
                    Console.WriteLine("it is ok");
                    break;
                case > 28:
                    Console.WriteLine("it is hot here");
                    break;
            }
        }
    }
}
