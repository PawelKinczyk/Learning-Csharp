using System;

namespace Chapter7CSharpLearningCollectionsJaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare a jagged array
            int[][] triangle = new int[][]
            {
            new int[] {1},
            new int[] {2, 3},
            new int[] {4, 5, 6},
            new int[] {7, 8, 9, 10},
            };

            // Print values
            foreach (int[] row in triangle) {
                foreach (int number in row)
                {
                    Console.WriteLine(number);
                }
            }

            // Declare a jagged array
            int[,] grid = new int[,]
            {
            {1, 2 }, {3, 4}, {4, 5}, {5, 6},
            };

            // Print values
            for (int i=0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    Console.WriteLine(grid[i,j]);
                }
            }

            // Average
            int[] studentsGrades = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 3, 3, 3};
            double averageResults = GetAverage(studentsGrades);
            Console.WriteLine(averageResults);
        }
        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for(int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }
            average = (double)sum / size;
            return average;
        }
    }
}
