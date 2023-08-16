using AbstractClassesC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10CSharpLearningAbstract
{
    internal class Sphere : Shape
    {
        public double R { get; set; }

        public Sphere (double r)
        {
            Name = "Sphere";
            R = r;
        }
        
        public override double Volume()
        {

            return 4/3*Math.PI*Math.Pow(R, 3);
        }

        public override void GetInfo()
        {
            Console.WriteLine($"The sphere has a r = {R}");
        }
    }
}
