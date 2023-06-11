using System;

namespace Chapter7CSharpLearningCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // First method of creating array
            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 30;
            grades[2] = 35;
            grades[3] = 50;
            grades[4] = 100;

            Console.WriteLine("Grades {0}", grades[2]);

            // Second
            int[] gradesOfMathStudentB = new int[] { 1, 2, 3, 4 };

            Console.WriteLine("Grades {0}", gradesOfMathStudentB[2]);

            // Third
            int[] gradesOfMathStudentA = new int[] { 12, 14, 22, 34, 31 };

            Console.WriteLine("Grades {0}", gradesOfMathStudentA[2]); 
            Console.ReadLine();

            // Input 
            int[] nums = new int[10];

            for(int i = 0; i < 10; i++)
            {
                nums[i] = i;
            }

            for(int j = 0; j < 10; j++)
            {
                Console.WriteLine(nums[j]);
            }
            Console.ReadLine();

            // Foreach

        }
    }
}
