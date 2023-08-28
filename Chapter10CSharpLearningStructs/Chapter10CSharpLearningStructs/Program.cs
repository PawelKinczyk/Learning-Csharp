using System;

namespace Chapter10CSharpLearningStructs
{
    struct Game
    {
        public string name;
        public string developer;
        public double rating;
        public string releaseDate;

        public void Display()
        {
            Console.WriteLine("{0}, {1}, {2}, {3}", name, developer, rating, releaseDate);
        }
    }

    enum Day { Mo, Tu, We, Th, Fr, Sa, Su };

    internal class Program
    {
        static void Main(string[] args)
        {
            Game game1;
            game1.name = "Poke";
            game1.developer = "Paw";
            game1.rating = 4.0;
            game1.releaseDate = "02.04.2023";
            game1.Display();

            Console.WriteLine("{0}, {1}, {2}, {3}", game1.name, game1.developer, game1.rating, game1.releaseDate);

            Day fr = Day.Fr;
            Day a = Day.Fr;
            Console.WriteLine(fr == a);
        
        
        }

        
    }
}
