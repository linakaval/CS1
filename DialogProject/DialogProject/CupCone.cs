using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogProject
{
    class CupCone
    {
        public static void answer(string name)
        {
            Console.WriteLine("\nDo you usually get your ice cream in a cup or a cone?");
            string container = Console.ReadLine().ToLower();

            if (container == "cup")
            {
                Console.WriteLine("Yup! Cup is the way to go. I honestly hate waffle cones. They taste nasty.");
            }
            else if (container == "cone")
            {
                Console.WriteLine("Ew. What's wrong with you? Cones taste like someone sliced up and stacked 50 \nlayers of skin, shaped it into a cone, and put it in the oven for a while. \nSo nasty.");
            }

            else
            {
                Console.WriteLine("Huh? That's not even an answer choice, please pay attention to what I'm saying, jeez.");
            }
        }
    }
}
