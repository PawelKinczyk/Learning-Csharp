using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6CsharpLearningObjectOrientedProgramming_Properties
{
    internal class Box
    {
        private int length;
        private int height;
        //private int width; // commented because we have property for width
        private int volume;

        public int Volume { get; }
        // Height property
        public int Height
        {
            get { return height; }
            set { this.height = value; }
        }
        
        
        // Width property
        public int Width { get; set; }

        // Allow to set lenght
        public void SetLenght(int lenght)
        {
            if(lenght < 0)
            {
                throw new Exception("Lenth should be higher that 0");
            }
            this.length = lenght;
        }
        // Allow to get lenght
        public int GetLenght()
        {
            return this.length;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Lenght is {0} and height is {1} and width is {2} and volum is {3}", length, height, Width, volume = length*height*Width);
        }
    }
}
