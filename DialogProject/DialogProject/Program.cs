//Lina Kaval
//Period 4

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Heyyyyyy what's your name, yo?");
            string name = Console.ReadLine();

            IceCreamStore.answer(name);
            FavoriteFlavor.answer(name);
            Scoops.answer(name);
            CupCone.answer(name);
            WorkIceCream.answer(name);
        }
    }
}
