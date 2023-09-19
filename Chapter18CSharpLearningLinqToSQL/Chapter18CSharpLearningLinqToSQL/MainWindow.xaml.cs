using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using Chapter18CSharpLearningLinqToSQL.CSharpDBDataSetTableAdapters;

namespace Chapter18CSharpLearningLinqToSQL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        LinqToSqlDataClassesDataContext dataContext;

        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Chapter18CSharpLearningLinqToSQL.Properties.Settings.CSharpDBConnectionString"].ConnectionString;
            dataContext = new LinqToSqlDataClassesDataContext(connectionString);

            //InsertUniversities();
            //InsertStudent();
            //InsertLectures();
            //InsertStudentLectureAssociations();
            //GetUniversityOfMate();
            //GetLecturesOfMate();
            //GetAllStudentsFromYale();
            //GetAllUniversitiesWithMales();
            //GetAllLecturesFromBeijing();
            //UpdateMat();
            DeleteRose();
        }

        public void InsertUniversities()
        {
            dataContext.ExecuteCommand("delete from University");

            University yale = new University();
            yale.Name = "Yale";
            dataContext.Universities.InsertOnSubmit(yale);

            University beijing = new University();
            beijing.Name = "Beijing";
            dataContext.Universities.InsertOnSubmit(beijing);

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Universities;
        }

        public void InsertStudent()
        {
            University yale = dataContext.Universities.First(un => un.Name.Equals("Yale"));
            University beijing = dataContext.Universities.First(un => un.Name.Equals("Beijing"));

            List<Student> students = new List<Student>();

            students.Add(new Student { Name = "Carla", Gender = "female", UniversityId = yale.Id });
            students.Add(new Student { Name = "Mat", Gender = "male", University = yale });
            students.Add(new Student { Name = "Rose", Gender = "female", University = beijing });
            students.Add(new Student { Name = "Mate", Gender = "male", University = beijing });

            dataContext.Students.InsertAllOnSubmit(students);
            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;
        }

        public void InsertLectures()
        {
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "Math" });
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "History" });

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Lectures;
        }

        public void InsertStudentLectureAssociations()
        {
            Student Carla = dataContext.Students.First(st => st.Name.Equals("Carla"));
            Student Mat = dataContext.Students.First(st => st.Name.Equals("Mat"));
            Student Rose = dataContext.Students.First(st => st.Name.Equals("Rose"));
            Student Mate = dataContext.Students.First(st => st.Name.Equals("Mate"));

            Lecture Math = dataContext.Lectures.First(lc => lc.Name.Equals("Math"));
            Lecture History = dataContext.Lectures.First(lc => lc.Name.Equals("History"));

            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Carla, Lecture = Math });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Mat, Lecture = History });


            StudentLecture slMat = new StudentLecture();
            slMat.Student = Mat;
            slMat.LectureId = History.Id;
            dataContext.StudentLectures.InsertOnSubmit(slMat);

            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Rose, Lecture = History });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Mate, Lecture = Math });

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.StudentLectures;
        }

        public void GetUniversityOfMate()
        {
            Student Mate = dataContext.Students.First(st => st.Name.Equals("Mate"));

            University MateUniversity = Mate.University;
            List<University> universities = new List<University>();
            universities.Add(MateUniversity);

            MainDataGrid.ItemsSource = universities;
        }

        public void GetLecturesOfMate()
        {
            Student Mate = dataContext.Students.First(st => st.Name.Equals("Mate"));

            var mateLectures = from sl in Mate.StudentLectures select sl.Lecture;

            MainDataGrid.ItemsSource = mateLectures;
        }

        public void GetAllStudentsFromYale()
        {
            var studentsFromYale = from student in dataContext.Students where student.University.Name == "Yale" select student;

            MainDataGrid.ItemsSource = studentsFromYale;
        }

        public void GetAllUniversitiesWithMales()
        {
            var malesUniversities = from student in dataContext.Students
                                    join university in dataContext.Universities
                                    on student.University equals university
                                    where student.Gender == "male"
                                    select university;

            MainDataGrid.ItemsSource = malesUniversities;
        }

        public void GetAllLecturesFromBeijing()
        {
            var lecturesFromBeijing = from sl in dataContext.StudentLectures
                                      join student in dataContext.Students
                                      on sl.StudentId equals student.Id
                                      where student.University.Name == "Beijing"
                                      select sl.Lecture;
            MainDataGrid.ItemsSource = lecturesFromBeijing;
        }

        public void UpdateMat()
        {
            Student Mate = dataContext.Students.FirstOrDefault(st => st.Name == "Mat");
            Mate.Name = "Antonio";
            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.Students;
        }

        public void DeleteRose()
        {
            Student Rose = dataContext.Students.FirstOrDefault(st => st.Name == "Rose");
            dataContext.Students.DeleteOnSubmit(Rose);
            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.Students;
        }

    }
}
