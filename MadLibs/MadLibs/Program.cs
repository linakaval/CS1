//Lina Kaval
//Period 4
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Mad Libs Program";

            Console.Write("Enter a place: ");
            string first = Console.ReadLine();

            Console.Write("Enter a noun: ");
            string second = Console.ReadLine();

            Console.Write("Enter a noun: ");
            string third = Console.ReadLine();

            Console.Write("Enter a noun: ");
            string fourth = Console.ReadLine();

            Console.Write("Enter a noun: ");
            string fifth = Console.ReadLine();

            Console.Write("Enter an adjective: ");
            string sixth = Console.ReadLine();

            Console.Write("Enter an adjective: ");
            string seventh = Console.ReadLine();

            Console.Write("Enter a verb that ends in -ed: ");
            string eighth = Console.ReadLine();

            Console.Write("Enter a noun: ");
            string ninth = Console.ReadLine();

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("One day, Mr. Hume was on his way to ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(first);
            Console.ForegroundColor = ConsoleColor.White;
            
            Console.Write(". \nHe had bought a ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(second);
            Console.ForegroundColor = ConsoleColor.White;
            
            Console.Write(" and a ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(third);
            Console.ForegroundColor = ConsoleColor.White;
           
            Console.Write(". \nIt was a gift for his ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(fourth);
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write(". \nBut on the way there a ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(fifth);
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write(" appeared. \nHume took out his Gryffindor sword \nand stabbed himself instead of the ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(fifth);
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write(" \nbecause he was too ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(sixth);
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write(" to kill it. \nThen the members of Spark \ncame around him and sang ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(seventh);
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write(" songs as they ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(eighth);
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write(" his lifeless body. \nThe Spark members chanted, “We are a ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(ninth);
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(".”");
        }
    }
}
