using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2
{
    class Tiger : Mammal
    {
        protected int TigerAge;
        protected string TigerName;

        public Tiger(int MammalAgeValue, string MammalName, int TigerAgeValue, 
            string TigerNameValue) : base(MammalAgeValue, MammalName)
        {
            this.TigerAge = TigerAgeValue;
            this.TigerName = TigerNameValue;
            Console.WriteLine("Executing Tiger constructor");
        }

        // properties
        public int Age
        {
            get { return TigerAge; }
            set { TigerAge = value; }
        }

        public string Name
        {
            get { return TigerName; }
            set { TigerName = value; }
        }
    }
}
