using AbstractClassesC;
using System;

namespace Chapter10CSharpLearningAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // We cannot create abstract class
            //Shape shape1 = new Shape();

            Shape[] shapes = { new Sphere(4), new Cube(4) };

            foreach (Shape shape in shapes)
            {
                shape.GetInfo();
                Console.WriteLine("{0} has volume of {1}", shape.Name, shape.Volume());

                Cube iceCube = shape as Cube;
                if( iceCube == null)
                {
                    Console.WriteLine("Shape is not a cube");
                }

                if(shape is Cube)
                {
                    Console.WriteLine("This is a cube");
                }
                object cube1 = new Cube(7);
                Cube cube2 = (Cube)cube1;

                Console.WriteLine("{0} has a Volume {1}", cube2.Name, cube2.Volume());
            }
        }
    }
}
