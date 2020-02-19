using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Input Demo";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("What's your name? ");

            Console.ForegroundColor = ConsoleColor.Red;
            string name = Console.ReadLine();

            Console.WriteLine("Howdy " + name + "! Nice to meet you!");
        }
    }
}
