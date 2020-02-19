using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogProject
{
    class FavoriteFlavor
    {
        public static void answer(string name)
        {
            Console.WriteLine("\nSo " + name + ", what's your favorite ice cream flavor?");
            string flavor = Console.ReadLine().ToLower();

            if (flavor == "chocolate")
            {
                Console.WriteLine("Yum! You should try Nutella Ice Cream. That's when you mix Nutella in vanilla \nice cream. It's really good and chocolatey.");
            }
            else if (flavor == "vanilla")
            {
                Console.WriteLine("Ew. You're so boring. You're just like my mom, jeez.");
            }
            else if (flavor == "chocolate chip")
            {
                Console.WriteLine("Same. I love anything chocolate. But you know what's even better than Chocolate Chip? DOUBLE CHOCOLATE CHIP!!!");
            }
            else if (flavor == "raspberry chocolate chip")
            {
                Console.WriteLine("Wow, you must really be a Cincinnatian. You probably live off for Graeter's and \nSkyline haha.");
            }
            else
            {
                Console.WriteLine("Eh, I don't really like that flavor. But pistachio ice cream is even worse, \nso whatever.");
            }
        }
    }
}
