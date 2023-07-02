using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9CSharpLearningInterfaces
{
    // Base class for furnitures
    class Furniture
    {
        // Furniture color
        public string Color { get; set; }
        // Material
        public string Material { get; set; }
        
        public Furniture() 
        {
            Color = "White";
            Material = "Wood";
        }

        // Simple constructor
        public Furniture(string color, string material)
        {
            Color = color;
            Material = material;
        }
    
    }
}
