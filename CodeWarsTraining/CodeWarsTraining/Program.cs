﻿using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTraining
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //var t = new Xbonacci();
            //double[] doubles = t.Tribonacci(new double[] { 1, 1, 1 }, 10);
            //Count("Lllaaarrary");
            //DuplicateCount("Indivisibilities");
            //Solution(10);
            //SpinWords("Hi whats your name");
            //string[] ar1 = { "arp", "live", "strong", "to" };
            //string[] ar2 = { "lively", "alive", "harp", "sharp", "armstrong" };
            //inArray(ar1, ar2); 
            //IsPrime(1);
            //FirstNonRepeatingLetter("sdeerTdsy");
            //int a = find_it(new []{ 1,2,4,2,6,2,1,1});
            //DigitalRoot(23455);
            //ArrayDiff(new int[] { }, new int[] { 1, 2 });
            KataCountBits.CountBits(4);

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
            return (int)(h * 3.6 * Math.Pow(10, 6) + m * 6 * Math.Pow(10, 4) + s * 1000);
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
            var counted = str.GroupBy(c => c).Select(g => new { g.Key, Con = g.Count() });
            foreach (var c in counted)
            {
                Console.WriteLine(c.Key);
                dict.Add(c.Key, c.Con);
            }
            return dict;
        }

        //Write a function that will return the count of distinct case-insensitive alphabetic characters and numeric digits that occur more than once in the input string. The input string can be assumed to contain only alphabets(both uppercase and lowercase) and numeric digits.
        public static int DuplicateCount(string str)
        {
            str = str.ToLower();
            int number = 0;
            foreach (char c in str.Distinct().ToArray())
            {
                Console.WriteLine(c);

                if (str.Count(x => x == c) > 1)
                {
                    number += 1;
                }
                else
                {
                }
            }

            Console.WriteLine(number);
            return number;
        }
        //        If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

        //Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in.

        //Additionally, if the number is negative, return 0.

        //Note: If the number is a multiple of both 3 and 5, only count it once.
        public static int Solution(int value)
        {
            var numbers = new List<int>();
            for (int i = 0; i < value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine(i);
                    numbers.Add(i);
                }
            }
            return numbers.Sum();
        }
        //Write a function that takes in a string of one or more words, and returns the same string, but with all five or more letter words reversed(Just like the name of this Kata). Strings passed in will consist of only letters and spaces.Spaces will be included only when more than one word is present.
        //https://www.codewars.com/kata/5264d2b162488dc400000001/train/csharp
        //TODO 
        public static string SpinWords(string sentence)
        {
            Random random = new Random();
            string[] str = sentence.Split(' ');
            List<string> newStr = new List<string>();
            foreach (string w in str)
            {
                Console.WriteLine(w);
                int a = random.Next(0, 2);
                if (w.Length >= 5)
                {
                    char[] reverse = w.ToCharArray();
                    Array.Reverse(reverse);
                    newStr.Add(new string(reverse));
                    Console.WriteLine(new string(reverse));
                }
                else
                {
                    newStr.Add(w);
                    Console.WriteLine(w);
                }
            }
            string result = string.Join(" ", newStr);
            Console.WriteLine(result);
            return result;
        }
        //        Given two arrays of strings a1 and a2 return a sorted array r in lexicographical order of the strings of a1 which are substrings of strings of a2.
        //Example 1:

        //a1 = ["arp", "live", "strong"]

        //a2 = ["lively", "alive", "harp", "sharp", "armstrong"]

        //returns["arp", "live", "strong"]
        public static string[] inArray(string[] array1, string[] array2)
        {
            List<string> list = new List<string>();
            foreach (string s in array1)
            {
                foreach (string s2 in array2)
                {
                    if (s2.Contains(s))
                    {
                        Console.WriteLine(s);
                        list.Add(s);
                        break;
                    }
                }
            }
            list.Sort();
            return list.ToArray();
        }

        //        Define a function that takes an integer argument and returns a logical value true or false depending on if the integer is a prime.

        //Per Wikipedia, a prime number (or a prime) is a natural number greater than 1 that has no positive divisors other than 1 and itself.
        //Requirements

        //    You can assume you will be given an integer input.
        //    You can not assume that the integer will be only positive.You may be given negative numbers as well (or 0 ).
        //    NOTE on performance: There are no fancy optimizations required, but still the most trivial solutions might time out. Numbers go up to 2^31 (or similar, depending on language ). Looping all the way up to n, or n/2, will be too slow.
        //https://www.codewars.com/kata/5262119038c0985a5b00029f/train/csharp

        public static bool IsPrime(int n)
        {
            bool res = true;
            if (n == 0 || n == 1 || n < 0)
            {
                res = false;
            }
            if (n > 1)
            {
                for (int i = 2; i <= Math.Sqrt(Math.Abs(n)); i++)
                {
                    Console.WriteLine(i);
                    Console.WriteLine(Math.Abs(n));
                    if (i != Math.Abs(n) && n % i == 0)
                    {

                        res = false;
                        break;
                    }

                }
            }
            Console.WriteLine(res.ToString());
            return res;
        }

        //        Write a function named first_non_repeating_letter that takes a string input, and returns the first character that is not repeated anywhere in the string.

        //For example, if given the input 'stress', the function should return 't', since the letter t only occurs once in the string, and occurs first in the string.

        //As an added challenge, upper- and lowercase letters are considered the same character, but the function should return the correct case for the initial letter.For example, the input 'sTreSS' should return 'T'.

        //If a string contains all repeating characters, it should return an empty string ("") or None -- see sample tests.

        public static string FirstNonRepeatingLetter(string s)
        {
            string p = s;
            s = s.ToLower();
            var list = s.GroupBy(x => x).Where(x => x.Count() == 1).Select(x => x.Key);
            foreach (char c in list)
            {
                Console.WriteLine(c);
            }
            if (list.Count() == 0)
            {
                return "";
            }
            else
            {
                return p[s.IndexOf(list.First())].ToString();
            }
        }

        //        Given an array of integers, find the one that appears an odd number of times.

        //There will always be only one integer that appears an odd number of times.
        //        Examples

        //[7] should return 7, because it occurs 1 time (which is odd).
        //[0] should return 0, because it occurs 1 time(which is odd).
        //[1,1,2] should return 2, because it occurs 1 time(which is odd).
        //[0,1,0,1,0] should return 0, because it occurs 3 times(which is odd).
        //[1,2,2,3,3,3,4,3,3,3,2,2,1] should return 4, because it appears 1 time(which is odd).

        public static int find_it(int[] seq)
        {

            foreach (int i in seq)
            {
                if (seq.ToList().Count(x => x == i) % 2 == 0)
                {
                    int a = 0;
                    Console.WriteLine(i);
                    continue;
                } else
                {
                    Console.WriteLine(i);
                    return i;
                }
            }
            return 0;
        }

        //        Digital root is the recursive sum of all the digits in a number.

        //Given n, take the sum of the digits of n. If that value has more than one digit, continue reducing in this way until a single-digit number is produced.The input will be a non-negative integer.

        public static int DigitalRoot(long n)
        {
            // Your awesome code here!
            List<char> splitLong = n.ToString().ToList();
            int num = 0;

            foreach (char c in splitLong)
            {
                Console.WriteLine(c);

                int nr = int.Parse(c.ToString());
                num += nr;
            }


            while (num.ToString().Length > 1)
            {
                splitLong = num.ToString().ToList();
                num = 0;
                foreach (char c in splitLong)
                {
                    Console.WriteLine(c);

                    int nr = int.Parse(c.ToString());
                    num += nr;
                }
            }
            Console.WriteLine(num);
            return num;
        }
        //        You probably know the "like" system from Facebook and other pages.People can "like" blog posts, pictures or other items. We want to create the text that should be displayed next to such an item.

        //Implement the function which takes an array containing the names of people that like an item. It must return the display text as shown in the examples:

        public static string Likes(string[] name)
        {
            if (name.Length == 0)
            {
                return "no one likes this";
            }
            else if (name.Length == 1) {
                return $"{name[0]} likes this";
            }
            else if (name.Length == 2) {
                return $"{name[0]} and {name[1]} like this";
            }
            else if (name.Length == 3)
            {
                return $"{name[0]}, {name[1]} and {name[2]} like this";
            }
            else {
                return $"{name[0]}, {name[1]} and {name.Length - 2} others like this";
            }
        }

        //        Your goal in this kata is to implement a difference function, which subtracts one list from another and returns the result.

        //It should remove all values from list a, which are present in list b keeping their order.
        //https://www.codewars.com/kata/523f5d21c841566fde000009/train/csharp

        public static int[] ArrayDiff(int[] a, int[] b)
        {
            // Your brilliant solution goes here
            // It's possible to pass random tests in about a second ;)
            List<int> aList = a.ToList();
            List<int> bList = b.ToList();
            foreach (int i in bList)
            {
                for (int x = 0; x <= aList.Count(x => x == i); x++)
                {
                    aList.RemoveAt(aList.IndexOf(i));
                }

            }
            int[] res = aList.ToArray();
            if (res != null) {
                return res;
            }
            else
            {
                return new int[] { };
            }

        }


        public static string CreatePhoneNumber(int[] numbers)
        {
            return $"({numbers.GetValue(0)}{numbers.GetValue(1)}{numbers.GetValue(2)}) {numbers.GetValue(3)}{numbers.GetValue(4)}{numbers.GetValue(5)}-{numbers.GetValue(6)}{numbers.GetValue(7)}{numbers.GetValue(8)}{numbers.GetValue(9)}";
        }
    }
    //Write a function that takes an integer as input, and returns the number of bits that are equal to one in the binary representation of that number.You can guarantee that input is non-negative.

    //Example: The binary representation of 1234 is 10011010010, so the function should return 5 in this case

    public class KataCountBits
    {
        public static int CountBits(int n)
        {
            BitArray bits = new BitArray(new int[] { n });
            int sum = 0;
            foreach (bool b in bits)
            {
                //Console.WriteLine(b);
                if (b == true) { sum += 1; }

            }
            return sum;
        }
    }

}
