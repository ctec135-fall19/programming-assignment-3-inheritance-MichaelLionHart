using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2
{
    class TigerCub : Tiger
    {
        // Fields
        protected int TigerCubAge;
        protected string TigerCubName;

        // Constructors        
        public TigerCub(int MammalAgeValue, string MammalName, int TigerAgeValue, 
            string TigerNameValue, int TigerCubAgeValue, string TigerCubNameValue)
            : base(MammalAgeValue, MammalName, TigerAgeValue, TigerNameValue)
        {
            this.TigerCubAge = TigerCubAgeValue;
            this.TigerCubName = TigerCubNameValue;
            Console.WriteLine("Executing TigerCub constructor\n");
        }

        // Properties
        public int Age
        {
            get { return TigerCubAge; }
            set { TigerCubAge = value; }
        }

        public string Name
        {
            get { return TigerCubName; }
            set { TigerCubName = value; }
        }


    }
}
