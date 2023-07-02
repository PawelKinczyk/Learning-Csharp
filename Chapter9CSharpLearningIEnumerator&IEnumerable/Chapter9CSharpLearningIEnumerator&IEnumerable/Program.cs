using System;
using System.Collections.Generic;

namespace Chapter9CSharpLearningIEnumerator_IEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a generic IEnumerable variable for storing returned variables
            IEnumerable<int> unknowCollection;
            // Option 1
            unknowCollection = GetCollection(1);

            Console.WriteLine("This was a List<int>");
            // Foreach number in collection iterate
            foreach (int i in unknowCollection)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine("");
            // Option 2
            unknowCollection = GetCollection(2);

            Console.WriteLine("This was a List<int>");
            // Foreach number in collection iterate
            foreach (int i in unknowCollection)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");
            // Other option
            unknowCollection = GetCollection(6);

            Console.WriteLine("This was a List<int>");
            // Foreach number in collection iterate
            foreach (int i in unknowCollection)
            {
                Console.Write(i + " ");
            }
        }
        static IEnumerable<int> GetCollection(int option)
        {
            // Create list of nubers and initialize list
            List<int> numbersList = new List<int>() { 1, 2, 3, 4, 5, 6};
            
            Queue<int> numbersQueue = new Queue<int>();
            // Add values to the queue
            numbersQueue.Enqueue(7);
            numbersQueue.Enqueue(8);
            numbersQueue.Enqueue(9);
            numbersQueue.Enqueue(10);
            numbersQueue.Enqueue(11);

            // If the option is 1
            if (option == 1)
            {
                // Return the list of type List<int>
                return numbersList;
                // If the option is 2
            }
            else if (option == 2)
            {
                // Return the queue of type<int>
                return numbersQueue;
                // Otherwise
            }
            else
            {
                // Return array of numbers initialized with some numbers
                return new int[] { 12, 13, 14, 15 };
            }
        }
    }
}
