using System;

namespace _Chapter2CsharpLearningVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Convert numbers to string
            // implicit conversion
            int num = 123905333;
            long bigNum = num;

            float myFloat = 13.37F;
            double myNewDouble = myFloat;

            string myString = myNewDouble.ToString();
            Console.WriteLine(myString);
            string myFloatString = myFloat.ToString();
            Console.WriteLine(myFloatString);


            double myDouble = 13.77;
            int myInt;

            // explicit conversion
            // double to int
            myInt = (int)myDouble;
            Console.WriteLine(myInt);


            // change string to numbers
            myString = "14";
            string mySecondString = "13";
            int num1 = Int32.Parse(myString);
            int num2 = Int32.Parse(mySecondString);
            int results = num1 + num2;
            Console.WriteLine(results);

            // Excercise 
            string stringForFloat = "0.85"; // datatype should be float
            string stringForInt = "12345"; // datatype should be int
            myFloat = float.Parse(stringForFloat);
            myInt = Int32.Parse(stringForInt);
            Console.WriteLine(myInt);
            Console.WriteLine(myFloat);

            Console.Read();
        }
    }
}
