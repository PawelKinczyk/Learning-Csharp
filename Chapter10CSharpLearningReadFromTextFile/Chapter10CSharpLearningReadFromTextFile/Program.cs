using System;
using System.IO;

namespace Chapter10CSharpLearningReadFromTextFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example 1 - read text
            string text = System.IO.File.ReadAllText(@"C:\Users\pawel\Downloads\testText.txt");
            Console.WriteLine("Text contains {0}", text);

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\pawel\Downloads\testText.txt");
            Console.WriteLine("Content in file is");
            foreach (string line in lines)
            {
                Console.WriteLine("\n" + line);
            }

            // Write text
            // Method 1
            string[] linesSave = { "21", "34", "44" };
            File.WriteAllLines(@"C:\Users\pawel\Downloads\testText2.txt", linesSave);
            // Method 2
            Console.WriteLine("Write name");
            string fileName = Console.ReadLine();
            Console.WriteLine("Please enter text for the file");
            string input = Console.ReadLine();

            File.WriteAllText(@"C:\Users\pawel\Downloads\" + fileName + ".txt", input);
            // Method 3
            using(StreamWriter file = new StreamWriter(@"C:\Users\pawel\Downloads\testText3.txt"))
            {
                foreach(string line in lines)
                {
                    file.WriteLine(line);
                }
            }
        }
    }
}
