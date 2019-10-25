using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2
{
    class Mammal
    {
        protected int age;
        protected string name;

        public Mammal(int MammalAgeValue, string MammalName)
        {
            this.age = MammalAgeValue;
            this.name = MammalName;
            Console.WriteLine("Executing Mammal constructor");
        }

        // Properties
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
