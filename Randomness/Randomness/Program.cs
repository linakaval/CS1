//Lina Kaval
//Period 4

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomness
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Random Number Generator";
            Random generator = new Random();
            int randomNumber;
            randomNumber = generator.Next();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nHere is a random integer: ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(randomNumber);

            int randomNumberunder100;
            randomNumberunder100 = generator.Next(100);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nHere is a random integer less than 100: ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(randomNumberunder100);

            int randomNumber10to20;
            randomNumber10to20 = generator.Next(10,20);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nHere is a random integer between 10 and 20: ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(randomNumber10to20);

            double randomNumberDecimal;
            randomNumberDecimal = generator.NextDouble();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nHere is a random double between 0.0 and 1.0: ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(randomNumberDecimal + "\n\n");

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
