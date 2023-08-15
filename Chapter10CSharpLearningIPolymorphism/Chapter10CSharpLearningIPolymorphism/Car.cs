using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10CSharpLearningIPolymorphism
{
    class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        // Has a relationship
        protected CarIDinfo carIDInfo = new CarIDinfo();

        public void SetCarIDInfo(int idNum, string Owner)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = Owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine("The car has the ID {0} and is owned by {1}", carIDInfo.IDNum, carIDInfo.Owner);
        }

        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        public void ShowDetails()
        {
            Console.WriteLine("HP: " + HP + " color:" + Color);
        }
        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired");
        }
    }
}
