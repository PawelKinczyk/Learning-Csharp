using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9CSharpLearningInterfaces
{
    internal interface IDestroyable
    {
        // Property to store the audio file of the destruction sound
        string DestructionSound { get; set; }
        // Method to destroy an object
        void Destroy();
    }
}
