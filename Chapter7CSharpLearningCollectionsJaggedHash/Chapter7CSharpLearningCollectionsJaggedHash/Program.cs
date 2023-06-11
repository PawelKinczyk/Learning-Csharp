using System;
using System.Collections;

namespace Chapter7CSharpLearningCollectionsJaggedHash
{
    internal class Program
    {
        // Key - value
        // Auto - car

        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();
            Student st1 = new Student(1, "dav", 95);
            Student st2 = new Student(2, "dan", 76);
            Student st3 = new Student(3, "puf", 44);
            Student st4 = new Student(4, "mer", 98);
            Student st5 = new Student(5, "cla", 99);

            table.Add(st1.Id, st1);
            table.Add(st2.Id, st2);
            table.Add(st3.Id, st3);
            table.Add(st4.Id, st4);
            table.Add(st5.Id, st5);

            Student storedStudent1 = (Student)table[2];

            Console.WriteLine("{0}, {1}, {2}", storedStudent1.Id, storedStudent1.Name, storedStudent1.GPA);
            Console.ReadLine();

            foreach (DictionaryEntry student in table) {
                Student temp = (Student)student.Value;

            }

        }
        class Student
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public float GPA { get; set; }

            public Student(int id, string name, float GPA)
            {
                this.Id = id;
                this.Name = name;
                this. GPA = GPA;
            }
        }
    }
}
