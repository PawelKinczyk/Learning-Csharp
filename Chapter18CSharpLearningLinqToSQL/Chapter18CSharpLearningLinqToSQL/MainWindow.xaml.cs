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
            InsertStudent();
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

            students.Add(new Student { Name= "Carla", Gender = "female", UniversityId = yale.Id });
            students.Add(new Student { Name = "Mat", Gender = "male", University = yale });
            students.Add(new Student { Name = "Rose", Gender = "female", University = beijing });
            students.Add(new Student { Name = "Mat", Gender = "male", University = beijing });

            dataContext.Students.InsertAllOnSubmit(students);
            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;
        }

    }
}
