using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogProject
{
    class WorkIceCream
    {
        public static void answer(string name)
        {
            Console.WriteLine("\nI wish I could work at an ice cream store. Do you, " + name + "?");
            string work = Console.ReadLine().ToLower();

            if (work == "yes")
            {
                Console.WriteLine("Yay! I think we are meant to be buddies for life! Well that's it for all \nof my questions, thanks for talking to me!!!");
            }
            else if (work == "no")
            {
                Console.WriteLine("No? Just go away oh my gosh I cannot stand you. I hate you. Well that's it for \nall of my questions, never talk to me ever again you freak.");
            }

            else
            {
                Console.WriteLine("Okay, I'm done. You didn't even read the question. It was a yes or no question. \nJust leave, " + name + ".");
            }
        }
    }
}
