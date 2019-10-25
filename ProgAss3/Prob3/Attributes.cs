using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    class Attributes
    {
        // properties
        public int year { get; set; }
        public string make { get; set; }
        public string model { get; set; }

        // constructors
        public Attributes() { }
        public Attributes(int year, string make, string model)
        {
            this.year = year;
            this.make = make;
            this.model = model;
        }

        // methods
        public void PrintAttributes()
        {            
            Console.WriteLine("Year:\t\t{0}", this.year);
            Console.WriteLine("Make:\t\t{0}", this.make);
            Console.WriteLine("Model:\t\t{0}", this.model);
        }
    }
}
