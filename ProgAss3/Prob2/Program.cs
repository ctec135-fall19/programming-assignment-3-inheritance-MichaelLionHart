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

namespace Prob2
{
    // here, a TigerCub instance is being created, which calls the Mammal
    // constructor, then the Tiger constructor, and builds the output
    // based on the parameters given here in main.  The output line 
    // references the Name and Age properties in the TigerCub class
    // and then prints them out
    class Program
    {
        static void Main(string[] args)
        {
            TigerCub babyTiger = new TigerCub(0, "", 0, "", 3, "Mike");            
            Console.WriteLine("The age of the Tiger Cub named {0} is {1} ", babyTiger.Name, babyTiger.Age);
        }
    }
}
