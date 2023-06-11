using System;
using System.Collections;

namespace Chapter7CSharpLearningCollectionsJaggedArrayLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring an arraylist without undefined amount of object
            ArrayList myArrayList = new ArrayList();
            // Define number of objects
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(14);
            myArrayList.Add("dddd");
            myArrayList.Add(12.1);
            myArrayList.Add(14);
            myArrayList.Add(14);
            myArrayList.Add(9);

            // Delete first element with value
            myArrayList.Remove(14);
            // Delete specific position element
            myArrayList.RemoveAt(0);

            Console.WriteLine(myArrayList.Count);
            double sum = 0;
            foreach(object i in myArrayList)
            {
                if (i is int)
                {
                    sum += Convert.ToDouble(i);
                }
                else if (i is double) 
                {
                    sum += (double)i; 
                }
                else if(i is string)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
