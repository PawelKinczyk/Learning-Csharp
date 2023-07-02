using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9CSharpLearningInterfaces
{
    class Car : Vehicle, IDestroyable
    {
        // Implementing the interface's property
        public string DestructionSound { get; set; }

        // Creating a new property to store the destroyable objects nearby
        // when car gets destroyed it should also destroy the nearby objects
        // this is of type IDestroyable which means it can store any object
        // that implements this interface and we can only access the properties and
        // methods in this interface
        public List<IDestroyable> DestroyablesNearby;
        
        public Car(float speed, string color) 
        {
        this.Speed = speed;
        this.Color = color;
        // Initialize the interface's property with a value in the constructor
        DestructionSound = "CarExplosionSound.mp3";
        // Initialize the list of destroyable objects
        DestroyablesNearby = new List<IDestroyable>();
        }

        // Implementing the interface's method
        public void Destroy()
        {
            // Ehen we gets destroyed we should play the destruction sound
            // and create fire effect
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Create fire");
            // Go through each destroyable objects nearby and call it's destroy method
            foreach (IDestroyable destroyable in DestroyablesNearby)
            {
                destroyable.Destroy();
            }
        }
    }
}
