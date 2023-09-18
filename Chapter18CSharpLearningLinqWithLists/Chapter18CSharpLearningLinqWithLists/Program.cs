using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter18CSharpLearningLinqWithLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UniversityManager um = new UniversityManager();

            um.MaleStudents();

            Console.ReadKey();

            um.FemaleStudents();

            Console.ReadKey();

            um.SortStudentsByAge();

            Console.ReadKey();

            um.AllStudentsFromWarsaw();

            Console.ReadKey();

            um.StudentAndUniversityNameCollection();

            Console.ReadKey();
            
        }
    }

    class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        // Constructors
        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            // Add universities
            universities.Add(new University { Id = 1, Name ="Yale"});
            universities.Add(new University { Id = 2, Name = "Warsaw" });

            // Add students
            students.Add(new Student { Id = 1, Name = "Carl", Gender = "female", Age = 19, UniversityId = 1 });
            students.Add(new Student { Id = 2, Name = "Toni", Gender = "male", Age = 22, UniversityId = 2 });
            students.Add(new Student { Id = 3, Name = "Ley", Gender = "male", Age = 26, UniversityId = 2 });
            students.Add(new Student { Id = 4, Name = "Mark", Gender = "female", Age = 18, UniversityId = 1 });
            students.Add(new Student { Id = 5, Name = "Carl", Gender = "female", Age = 31, UniversityId = 1 });
            students.Add(new Student { Id = 6, Name = "Carl", Gender = "male", Age = 33, UniversityId = 2 });
        }

        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "male" select student;
            Console.WriteLine("Male - Students: ");

            foreach(Student student in maleStudents)
            {
                student.Print();
            }
        }

        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in students where student.Gender == "female" select student;
            Console.WriteLine("Female - Students: ");

            foreach (Student student in femaleStudents)
            {
                student.Print();
            }
        }

        public void SortStudentsByAge()
        {
            var sortedStudents = from student in students orderby student.Age select student;

            Console.WriteLine("Students sorted by age");

            foreach (Student student in sortedStudents)
            {
                student.Print();
            }
        }

        public void AllStudentsFromWarsaw()
        {
            IEnumerable<Student> wawStudents = from student in students join university in universities on student.UniversityId equals university.Id where university.Name == "Warsaw" select student;

            Console.WriteLine("Students from Warsaw");

            foreach (Student student in wawStudents)
            {
                student.Print();
            }
        }

        public void StudentAndUniversityNameCollection()
        {
            var newCollection = from student in students join university in universities on student.UniversityId equals university.Id orderby student.Name select new { StudentName = student.Name, UniversityName = university.Name };

            Console.WriteLine("New Collection: ");

            foreach (var col in newCollection)
            {
                Console.WriteLine("Student {0} from University {1}", col.StudentName, col.UniversityName);

            }
        }
    }

    class University
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine("University {0} with id {1}", Name, Id);
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        // Foreign Key
        public int UniversityId { get; set; }

        public void Print()
        {
            Console.WriteLine("Student {0} with Id {1}, Gender {2} and Age {3} from University with the Id {4}", Name, Id, Gender, Age, UniversityId);
        }
    }
}
