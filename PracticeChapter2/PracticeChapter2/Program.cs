using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeChapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Practice Program";

            Console.Write("Hi! What's your favorite food? ");
            string food = Console.ReadLine();

            Console.WriteLine("\nHere's your favorite food in upper case - " + food.ToUpper());

            Console.WriteLine("\nNow I'm going to guess your favorite number between 500 and 1001.");

            Random rand = new Random();
            int randomNumber;
            randomNumber = rand.Next(500,1000);

            Console.WriteLine("I bet it's " + randomNumber + "\n\nThat's all for now.   Bye!");
        }
    }
}
