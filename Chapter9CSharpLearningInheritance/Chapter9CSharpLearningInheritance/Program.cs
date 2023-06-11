using System;

namespace Chapter9CSharpLearningInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Radio myRadio = new Radio(false, "Sony");
            myRadio.SwitchOn();
            myRadio.ListenRadio();
            Console.ReadLine();

        }
    }
}
