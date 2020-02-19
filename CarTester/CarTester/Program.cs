using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Car clunker = new Car(20);

            Console.WriteLine("My car begins with " + clunker.getGas() + " gallons of gas.");

            clunker.addGas(15);

            Console.WriteLine("After adding gas, my car has " + clunker.getGas() + " gallons of gas.");

            clunker.drive(100);

            Console.WriteLine("After driving my car, it has " + clunker.getGas() + " gallons of gas.");
        }
    }
}
