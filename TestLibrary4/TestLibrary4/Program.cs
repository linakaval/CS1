using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS1Library4;

namespace TestLibrary4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Howdy!");

            int num = Utilities.inputInt("Enter a big number:\n", -10, 10, ConsoleColor.Green, ConsoleColor.Magenta, ConsoleColor.Red);

            Console.WriteLine("The number is " + num);

            num = Utilities.inputInt();
        }
    }
}
