using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9CSharpLearningInheritance
{
    class Tv : ElectricalDevice
    {
        
        public Tv(bool isOn, string brand): base(isOn, brand) { }
        
        
        public void WatchTv()
        {
            if (IsOn)
            {
                Console.WriteLine("Watch Tv");
            }
            else
            {
                Console.WriteLine("Tv is off");
            }
        }
    }
}
