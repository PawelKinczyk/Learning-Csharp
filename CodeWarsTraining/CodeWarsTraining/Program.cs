using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWarsTraining
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //var t = new Xbonacci();
            //double[] doubles = t.Tribonacci(new double[] { 1, 1, 1 }, 10);
            Count("Lllaaarrary");
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
        //Given a random non-negative number, you have to return the digits of this number within an array in reverse order.
        public static long[] Digitize(long n)
        {
            return n.ToString()
                    .Reverse()
                    .Select(t => Convert.ToInt64(t.ToString()))
                    .ToArray();
        }
//Clock shows h hours, m minutes and s seconds after midnight.
//Your task is to write a function which returns the time since midnight in milliseconds.
        public static int Past(int h, int m, int s)
        {
            return (int)(h * 3.6 * Math.Pow(10, 6) + m * 6 * Math.Pow(10,4) + s * 1000);
    }
        //Write a function which converts the input string to uppercase.
        public static string MakeUpperCase(string str)
        {
            return str.ToUpper();
        }
        //Write a function that accepts an integer n and a string s as parameters, and returns a string of s repeated exactly n times.
        public static string RepeatStr(int n, string s)
        {
            var ret = new StringBuilder(n * s.Length);
            for (int i = 0; i < n; i++)
            {
                ret.Append(s);
            }
            return ret.ToString();
        }

        //The goal of this exercise is to convert a string to a new string where each character in the new string is "(" if that character appears only once in the original string, or ")" if that character appears more than once in the original string. Ignore capitalization when determining if a character is a duplicate.
        public static string DuplicateEncode(string word)
        {
            var changedWord = new StringBuilder();
            word = word.ToLower();
            foreach (char c in word)
            {
                if (word.Count(x => x == c) == 1)
                {
                    changedWord.Append('(');
                }
                else
                {
                    changedWord.Append(')');
                }
            }
            Console.WriteLine(changedWord.ToString());
            return changedWord.ToString();
        }
        //        Well met with Fibonacci bigger brother, AKA Tribonacci.

        //As the name may already reveal, it works basically like a Fibonacci, but summing the last 3 (instead of 2) numbers of the sequence to generate the next.And, worse part of it, regrettably I won't get to hear non-native Italian speakers trying to pronounce it :(

        //So, if we are to start our Tribonacci sequence with [1, 1, 1] as a starting input (AKA signature), we have this sequence:
        public class Xbonacci
        {
            
            public double[] Tribonacci(double[] signature, int n)
            {
                List<double> result = new List<double>(signature);
                for (int i = 0; i <= n; i++)
                {
                    double newNumber = result.TakeLast(3).Sum();
                    result.Add(newNumber);
                    //Console.WriteLine(result.Last());

                }
                foreach (double number in result) { Console.WriteLine(number); }
                return result.ToArray();
            }
        }

        //There is an array with some numbers.All numbers are equal except for one.Try to find it!
        //https://www.codewars.com/kata/585d7d5adb20cf33cb000235/train/csharp
        
        public static int GetUnique(IEnumerable<int> numbers)
        {
            return numbers.GroupBy(x => x).Where(x => x.Count() == 1).Select(x => x.Key).First();
        }
        //The main idea is to count all the occurring characters in a string. If you have a string like aba, then the result should be {'a': 2, 'b': 1}.
        //What if the string is empty? Then the result should be empty object literal, {}.
        public static Dictionary<char, int> Count(string str)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            var counted = str.GroupBy(c => c).Select(g => new {g.Key, Con = g.Count()});
            foreach ( var c in counted)
            {
                Console.WriteLine(c.Key);
                dict.Add(c.Key, c.Con);
            }

            return dict;
        }

    }
}
