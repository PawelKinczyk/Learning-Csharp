using System;

namespace CodeWarsTraining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(basicOp('*', 3, 5));
        }
        public static string AreYouPlayingBanjo(string name)
        {
            string text = "";
            //Implement me
            if (name.StartsWith("R") || name.StartsWith("r"))
            {
                text = $"{name} plays banjo";
                return text;
            }
            else
            {
                text = $"{name} does not play banjo";
                return text;
            }
        }
        public static string Smash(string[] words)
        {

            string result = string.Join(" ", words);
            return result;
        }
        //It's pretty straightforward. Your goal is to create a function that removes the first and last characters of a string. You're given one parameter, the original string.You don't have to worry with strings with less than two characters.
        public static string Remove_char(string s)
        {

            string mystr = s.Substring(1, s.Length - 2);
            return mystr;
        }
        //Your task is to create a function that does four basic mathematical operations.
        //The function should take three arguments - operation(string/char), value1(number), value2(number).
        //The function should return result of numbers after applying the chosen operation.
        //Examples(Operator, value1, value2) --> output
        public static double basicOp(char operation, double value1, double value2)
        {
            if (operation == '+')
            {
                return value1 + value2;
            }
            else if (operation == '-')
            {
                return value1 - value2;
            }
            else if (operation == '*')
            {
                return value1 * value2;
            }
            else if (operation == '/')
            {
                return value1 / value2;
            }
            else
            {
                return 0;
            }
        }
    }
}
