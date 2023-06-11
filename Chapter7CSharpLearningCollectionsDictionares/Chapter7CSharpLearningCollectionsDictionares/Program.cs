using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter7CSharpLearningCollectionsDictionares
{
    internal class Program
    {
        // key - value
        // Auto - car
        static void Main(string[] args)
        {
            Employee[] employees =
            {
                new Employee("sem", "gwyn", 95, 200),
                new Employee("man", "joe", 34, 333),
                new Employee("dm", "Lora", 44, 432),
                new Employee("Secr", "John", 32, 21),
                new Employee("Lead", "Artur", 39, 25),
            };

            Dictionary<string, Employee> employeeDictionary = new Dictionary<string, Employee>();
            foreach (Employee emp in employees)
            {
                employeeDictionary.Add(emp.Role, emp);
            }
            Employee employees2 = employeeDictionary["sem"];
            Console.WriteLine("{0}, {1}", employees2.Name, employees2.Age);

            Console.ReadLine();

            Dictionary<int, string> myDictionary = new Dictionary<int, string>()
            {
                {1, "one" },
                {2, "two"},
                {3, "three"}
            };
            for (int i = 0; i < myDictionary.Count; i++)
            {
                KeyValuePair<string, Employee> keyValuePair = myDictionary.ElementAt(i);
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
    class Employee
    {
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }
        public float Salary
        {
            get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        }
        public Employee(string role, string name, int age, int rate)
        {
            this.Role = role;
            this.Name = name; 
            this.Age = age;
            this.Rate = rate;
        }
     }
}
