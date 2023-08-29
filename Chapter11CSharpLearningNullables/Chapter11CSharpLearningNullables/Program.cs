using System;

namespace Chapter11CSharpLearningNullables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 1224;
            int num5;

            double? num3 = new Double?();
            double? num4 = 3.2545;

            bool? boolval = new bool?();

            Console.WriteLine("Our nullable numbers are: {0}, {1}, {2}, {3}", num1, num2, num3, num4);
            Console.WriteLine("The nullable boolean val is {0}", boolval);

            bool? isMale = null;
            if (isMale == true)
            {
                Console.WriteLine("User is male");
            }
            else if (isMale == true)
            {
                Console.WriteLine("User is female");
            }
            else
            {
                Console.WriteLine("User has no gender");
            }

            double? num6 = 13.1;
            double? num7 = null;
            double? num8;

            if(num6 ==null)
            {
                num8 = 0.0;
            }
            else
            {
                num8 = num6;
            }

            Console.WriteLine("Value of num8 is {0}", num8);

            num8 = num6 ?? 8.53;
            Console.WriteLine("Value of num8 is {0}", num8);
            num8 = num7 ?? 8.53;
            Console.WriteLine("Value of num8 is {0}", num8);


        }
    }
}
