using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string playAgainInput;
            bool yOrN = true;


            do
            {
                NumberGuessingGame game = new NumberGuessingGame();
                game.playGame();
                Console.WriteLine("Do you want to play again?   [y or n]");
                playAgainInput = Console.ReadLine().ToLower();
                if (playAgainInput == "y")
                {
                    Console.Clear();

                }

                else
                {
                    yOrN = false;
                    Console.WriteLine("\nWell, thanks for playing! Bye!");

                }
            } while (yOrN);
        }
    }
}
