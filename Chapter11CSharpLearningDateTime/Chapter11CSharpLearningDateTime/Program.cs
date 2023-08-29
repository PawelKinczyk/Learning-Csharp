using System;

namespace Chapter11CSharpLearningDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(1996,5,30);
            Console.WriteLine("Today is {0}",dateTime);

            // Write today on screen 
            Console.WriteLine(DateTime.Today);
            // Write current time on screen
            Console.WriteLine(DateTime.Now);

            DateTime tomorrow = GetTomorrow();
            Console.WriteLine("Tommorow is {0}", tomorrow);

            //Display hour and minute
            Console.WriteLine("{0} o'clock {1} minutes", DateTime.Now.Hour, DateTime.Now.Minute);
            
        }
        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }
    }
}
