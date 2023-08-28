using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Chapter11CSharpLearningRegularExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"name";
            Regex regex = new Regex(pattern);

            string text = "Hi there, my name is Pawel1534";

            MatchCollection matchCollection = regex.Matches(text);

            foreach (Match match in matchCollection)
            {
                GroupCollection group = match.Groups;
                Console.WriteLine("{0} found at {1}", group[0].Value, group[0].Index);
            }

            // Excercise
            string text_e = File.ReadAllText("C:\\Users\\pawel\\Documents\\GitHub\\Learning-Csharp\\Chapter11CSharpLearningRegularExpression\\Chapter11CSharpLearningRegularExpression\\TextFile1.txt");
            string pattern_e = @"\d{1,4}";
            Regex regex_e = new Regex(pattern_e);

            MatchCollection matchCollection_e = regex_e.Matches(text_e);

            foreach (Match match in matchCollection_e)
            {
                GroupCollection group = match.Groups;
                int a = Convert.ToInt32(match.Value);
                Console.WriteLine("{0}",(char)a);
            }

        }
    }
}
