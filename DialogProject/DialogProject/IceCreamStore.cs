using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogProject
{
    class IceCreamStore
    {  
        public static void answer(string name)
        {
            Console.WriteLine("\nHey " + name + "! It's finally getting warmer out, so I guess it's ice cream season...\nI love ice cream!"
                + " Where do you go for ice cream?");
            string shop = Console.ReadLine().ToLower();

            if (shop == "menchie's")
            {
                Console.WriteLine("Cool! I have a Menchie's point card. I always have to be careful so I don't get a CPU-freeze.");
            }
            else if (shop == "orange leaf")
            {
                Console.WriteLine("Why do you even go there? Everyone knows Menchie's is better.");
            }
            else if (shop == "graeter's")
            {
                Console.WriteLine("Cincinnati pride whoop whoop! You must have lived here for a long time, right \n" + name + "?");
            }
            else if (shop == "udf")
            {
                Console.WriteLine("Cool, there's a UDF near my house that I go to sometimes.");
            }
            else
            {
                Console.WriteLine("Huh. I've never heard of that store. You should take me with you next time.");
            }
        }
    }
}
