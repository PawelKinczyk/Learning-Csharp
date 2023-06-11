using System;

namespace Chapter6CsharpLearningObjectOrientedProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // First lesson
            //// Create class human 
            //Human denis = new Human();
            //// Acces public variable
            //denis.firstName = "Denis";
            //denis.lastName = "White";
            //// Call method of class
            //denis.IntroduceMyself();

            //Human michael = new Human();
            //michael.firstName = "Michael";
            //michael.lastName = "White";
            //michael.IntroduceMyself();

            // Second lesson
            Human human = new Human();
            human.IntroduceMyself();
            Human sissy = new Human("Sissy", "White", "Blue", 22);
            sissy.IntroduceMyself();

            Console.ReadLine();
        }
    }
}
