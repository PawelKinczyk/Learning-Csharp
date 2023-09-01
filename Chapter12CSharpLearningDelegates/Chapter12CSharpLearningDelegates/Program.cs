using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Chapter12CSharpLearningDelegates
{
    internal class Program
    {
        // create delegate type called filter delegate that takes a person object and returns a bool
        public delegate bool FilterDelegate(Person p);

        static void Main(string[] args)
        {
            Person p1 = new Person() { Name = "Aid", Age = 41};
            Person p2 = new Person() { Name = "Fran", Age = 22 };
            Person p3 = new Person() { Name = "Pol", Age = 62 };
            Person p4 = new Person() { Name = "Mel", Age = 12 };

            //Add objects to a list called people
            List<Person> people = new List<Person>() { p1,p2,p3,p4};

            DisplayPeople("Kids", people, IsMinor);
            DisplayPeople("Adult", people, IsAdult);
            DisplayPeople("Senior", people, IsSenior);

            static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
            {
                Console.WriteLine(title);

                foreach (Person person in people)
                {
                    if (filter(person))
                    {
                        Console.WriteLine("{0}, {1} years old", person.Name, person.Age);
                    }
                }
            }

            DisplayPeople("exactly 12:", people, p => p.Age == 12);

            //=======Filters========
            static bool IsMinor(Person person)
            {
                return person.Age < 18;
            }

            static bool IsAdult(Person person)
            {
                return person.Age >= 18;
            }

            static bool IsSenior(Person person)
            {
                return person.Age >= 61;
            }

        }
    }
}
