//Lina Kaval
//Period 4

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCardsTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Playing Card Tester";
            Console.Write("Enter a card number from 0 to 51: ");
            int card = Convert.ToInt16(Console.ReadLine());

            PlayingCard play = new PlayingCard(card);
            
            Console.WriteLine("\n\n\nCard Rank = " + play.getRank());
            Console.WriteLine("\nCard Suit = " + play.getSuit());       
            Console.WriteLine("\n\nThat card is the " + play.ToString() + "\n\n\n");
        }
    }
}
