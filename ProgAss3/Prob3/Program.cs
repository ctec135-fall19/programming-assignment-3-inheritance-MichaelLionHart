/*
Contributor:  Mike Hart (assigned problems 1 - 3)
Assignment:  Programming Assignment 3
Partner:  Bogdan Livadaru (assigned problems 4 and 5)
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    class Program
    {
        // illustrating the use of aggregation and composition
        // through calling classes that have an field references
        // to other classes (aggregation) and using a varible
        // that is created inside the class itself (composition)
        static void Main(string[] args)
        {
            // Aggregation Example
            Console.WriteLine("***** Aggregation Example *****\n");
            // create car
            Car Mike = new Car("Mike");
            Mike.UpdateAttributes(2002, "Ford", "Mustang");

            // print car attributes
            Console.WriteLine("Car Name:\t{0}", Mike.Name);
            Mike.PrintAttributes();
            Console.WriteLine();

            // Composition Example - because the variable exists inside the class
            // being referenced - it only exists as long as the class instance
            // exists
            Console.WriteLine("***** Composition Example *****\n");
            Console.WriteLine("Composition Name:\t{0}", Mike.CompositionName);
            Console.WriteLine();
        }
    }
}
