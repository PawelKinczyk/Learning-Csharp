using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9CSharpLearningInterfaces
{
    class Chair : Furniture, IDestroyable
    {
        // Implement the inference property
        public string DestructionSound { get; set; }

        public Chair(string color, string material)
        {
            this.Color = color;
            this.Material = material;
            // Initialize the interface's property with a value in the constructor
            DestructionSound = "ChairExplosionSound.mp3";

        }
        public void Destroy()
        {
            // When a chair gets destroyed we should play the destruction sound and spawn the destroyed chair parts
            Console.WriteLine($"The {Color} was destroyed");
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Spawn chair parts");

        }
    }
}