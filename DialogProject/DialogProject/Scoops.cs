using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogProject
{
    class Scoops
    {
        public static void answer(string name)
        {
            Console.WriteLine("\nHow many scoops of ice cream do you usually get?");
            int scoops = Convert.ToInt16(Console.ReadLine());

            if (scoops == 1)
            {
                Console.WriteLine("Same. Especially when I'm out, because getting ice cream is so expensive. \nBut at home I eat about 10 scoops.");
            }
            else if (scoops == 2)
            {
                Console.WriteLine("2 scoops at Graeter's costs $4. *sigh* I could get a tub of ice cream at Meijer for that much money. Obviously it wouldn't taste as good though.");
            }
            else if (scoops >= 3)
            {
                Console.WriteLine("Dang yo, you must have a job or something cuz I would never pay for more than 2 scoops of ice cream unless I have cash to spend. Which I don't. Cuz I don't have a job. Fun times.");
            }
            else
            {
                Console.WriteLine("Do you not like ice cream??? Have I been annoying you this entire time???? I'm \nsorry. Ha no I'm not. You're dumb for not liking ice cream. It's not my \nfault. So I will annoy you with more questions. Too bad.");
            }
        }
    }
}
