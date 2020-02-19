using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoachTester
{
    class Program
    {
        static void Main(string[] args)
        {
            RoachPopulation nasty = new RoachPopulation(10);
            Console.Title = "Roach Invasion!!!";
            Console.WriteLine("My kitchen starts out with " + nasty.getRoaches() + " roaches.");


            for (int lcv = 0; lcv < 3; lcv++)
            {
                Console.WriteLine("\nThe roaches are growing in my kitchen...");
                nasty.waitForDoubling();
                Console.WriteLine("I'm spraying the kitchen...");
                nasty.spray();
                Console.WriteLine("There are now " + nasty.getRoaches() + " roaches in my kitchen!");
            }

            Console.WriteLine("\nRoaches win.\n\n");

        }
    }
}
