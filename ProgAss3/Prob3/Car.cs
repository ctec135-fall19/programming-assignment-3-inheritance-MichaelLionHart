using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    // Here, the Car class has a field reference to the Attributes class
    // This makes it possible to aggregate data and behavior by calling
    // methods from the Car class that are from the Attributes class
    class Car
    {
        // fields and properties
        public string Name { get; set; }
        public string CompositionName;
        private Attributes attributes;

        // constructor
        public Car(string name)
        {
            Name = name;
            attributes = new Attributes();
        }

        // methods
        public void UpdateAttributes(int year, string make, string model)
        {
            this.CompositionName = "Steven";  // This variable illustrates composition
            attributes.year = year;
            attributes.make = make;
            attributes.model = model;
        }

        // this method essentially just calls the PrintAttributes() method
        // in the Attributes class
        public void PrintAttributes()
        {
            attributes.PrintAttributes();
        }
    }
}
