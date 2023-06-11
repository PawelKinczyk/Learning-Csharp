using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6CsharpLearningObjectOrientedProgramming
{
    class Human
    {
        //// Class from first lesson
        //// Member variable
        ////public string firstName = "Michael"; // Set default value 
        //public string firstName;
        //public string lastName;

        //// Member
        //public void IntroduceMyself() { 
        //Console.WriteLine("Hi im {0},{1}", firstName, lastName);

        // Second lesson
        private string firstName;
        private string lastName;
        private string eyeColour;
        private int age;

        // Constructors
        // Constructor without parameters
        public Human()
        {
            Console.WriteLine("Human wthout parameters");
        }


        public Human(string firstName, string lastName, string eyeColour, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColour = eyeColour;
            this.age = age;
        }
        public void IntroduceMyself() { 
        Console.WriteLine("Hi im {0} {1} {2} {3}", firstName, lastName, eyeColour, age);
    }
}
}
