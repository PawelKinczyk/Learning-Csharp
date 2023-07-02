using System;

namespace Chapter9CSharpLearningInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lesson 135
            Ticket t1 = new Ticket(15);
            Ticket t2 = new Ticket(15);
            Console.WriteLine(t2.Equals(t1));
            Console.ReadLine();

            // Lesson 136
            // Creating two objects of type chair
            Chair officeChair = new Chair("Brown", "Plastic");
            Chair gamingChair = new Chair("Red", "Wood");

            // Creating a new object of type car
            Car damageCar = new Car(80f, "Blue");

            // Add two chairs near car (to nearby list)
            damageCar.DestroyablesNearby.Add(officeChair);
            damageCar.DestroyablesNearby.Add(gamingChair);

            // Destroy car
            damageCar.Destroy();
            Console.ReadLine();

        }
    }
}
