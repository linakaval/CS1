using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value for x: ");
            int x = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter a value for y: ");
            int y = Convert.ToInt16(Console.ReadLine());

            if (x >= 100 && x <= 200 && y >= 150 && y <= 250)
            {
                Console.WriteLine("That point is in rectangle 1. \nBye!");
            }

            else if (x >= 300 && x <= 400 && y >= 350 && y <= 450)
            {
                Console.WriteLine("That point is in rectangle 2. \nBye!");
            }

            else
            {
                Console.WriteLine("That point is not in either rectangle. \nBye!");
            }
        }
    }
}
