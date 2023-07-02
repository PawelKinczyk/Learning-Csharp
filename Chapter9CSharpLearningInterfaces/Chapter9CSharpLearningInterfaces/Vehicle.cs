using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9CSharpLearningInterfaces
{
    // Speed of the vehicle
    class Vehicle
    {
        // Speed of the vehicle
        public float Speed { get; set; }
        // Vehicle color
        public string Color { get; set; }

        public Vehicle() 
        {
            Speed = 120f;
            Color = "White";
        }
        // Constructor
        public Vehicle(float speed, string color)
        {
            Speed = speed;
            Color = color;
        }
    }
}
