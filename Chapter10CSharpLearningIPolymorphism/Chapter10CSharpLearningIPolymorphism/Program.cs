using System;
using System.Collections.Generic;

namespace Chapter10CSharpLearningIPolymorphism
{    
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Audi(200, "pink", "A1"),
                new BMW(180, "black", "B5"),
                
            };

            foreach (var car in cars) {
                car.Repair();
                car.ShowDetails();
            }
            Console.ReadLine();
            BMW bmw1 = new BMW(150, "red", "A23");
            bmw1.ShowDetails();
            Console.ReadLine();

            bmw1.SetCarIDInfo(2233, "PK");
            bmw1.GetCarIDInfo();

            M3 myM3 = new M3(260, "red", "supor turbo");
            myM3.Repair();
            Console.ReadKey();
        }
    }
}
