//Lina Kaval
//Period 4

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCardsTester
{
    class PlayingCard
    {
        private int mySuit;
        private int myRank;
        private string[] rankNames = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
        private string[] suitNames = { "Diamond", "Clubs", "Hearts", "Spades" };

        /// <summary>
        /// Constructs a PlayingCard object
        /// </summary>
        /// <param name="cardNumber">Number of the card</param>
        public PlayingCard(int cardNumber)
        {
            mySuit = cardNumber / 13;
            myRank = cardNumber % 13;
        }

        /// <summary>
        /// Turns the card number into a string
        /// </summary>
        /// <returns>The string version of the card number.</returns>
        public override string ToString()
        {
            return rankNames[myRank] + " of " + suitNames[mySuit];
        }

        /// <summary>
        /// Returns the number of the suit
        /// </summary>
        /// <returns>The suit name</returns>
        public int getSuit()
        {
            return mySuit;
        }

        /// <summary>
        /// Returns the number of the rank
        /// </summary>
        /// <returns>The rank name</returns>
        public int getRank()
        {
            return myRank;
        }
    }
}
