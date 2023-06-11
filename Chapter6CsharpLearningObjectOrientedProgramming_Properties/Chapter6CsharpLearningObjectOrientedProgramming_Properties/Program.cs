using System;

namespace Chapter6CsharpLearningObjectOrientedProgramming_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            box.SetLenght(11);
            //box.length = 10;
            Console.WriteLine(box.GetLenght());
            box.Height = 10;
            box.Width = 10;


            box.DisplayInfo();
            Console.ReadLine();
        }
    }
}
