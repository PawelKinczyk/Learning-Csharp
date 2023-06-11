using System;

namespace Chapter7CSharpLearningCollectionsMultiDim
{
    internal class Program
    {

        static int[,] matriX =
        {
            {1,2,3 },
            {4,5,6 },
            {5,6,7}
        };

        
        static void Main(string[] args)
        {
            // 2d array
            string[,] matrix;

            // 3d array
            int[,,] threeD;

            // two dimensional array
            int[,] array2D = new int[,]
            {
                {1,2,3},
                {4,5,6},
                {6,7,8}
            };
            Console.WriteLine("Central value {0}", array2D[1, 1]);
            Console.ReadLine();

            string[,,] array3D = new string[,,]
            {
                {
                {"000", "001"},
                {"010", "011"}
                },
                {
                {"100", "101"},
                {"110", "111"}
                }
            };
            Console.WriteLine("Central value {0}", array3D[1,1,1]);
            Console.ReadLine();

            foreach (int item in matriX)
            {
                Console.WriteLine(item + " ");
            };
            Console.ReadLine();
        }
    }
}
