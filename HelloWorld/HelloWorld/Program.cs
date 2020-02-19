using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "My First Program!";
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.WriteLine("Hello World!");
            Console.WriteLine("My name is Lina.");
        }
    }
}
