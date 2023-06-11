using System;

namespace Chapter3CsharpLearningFunctionsMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // entry point
            WriteSomething();
            WriteSomethingSpecific("Hi my specific text");
            Console.WriteLine(Add(12, 19));
            
            Console.WriteLine("Enter number");
            string userInput = Console.ReadLine();
            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException) {
                Console.WriteLine("Error format write correct next time");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Too long number");
            }
            finally { Console.WriteLine("This is anyway"); }
        
        }
        // access modifier (static return type method name (parameter1, parameter2)
        public static void WriteSomething()
        {
            Console.WriteLine("This is write something function");
            Console.Read();
                }
        public static void WriteSomethingSpecific(string text)
        {
            Console.WriteLine(text);
            Console.Read();
        }
        public static int Add(int num1,  int num2)
        {
            return num1 + num2;
        }
    }
}
