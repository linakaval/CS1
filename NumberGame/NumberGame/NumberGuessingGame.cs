//Lina Kaval
//Period 4

using System;
using CS1Library4;

namespace NumberGame
{
    class NumberGuessingGame
    {
	    private int guessCount;
	    private int secretNumber;
        private int guess;
	    private int min;
	    private int max;
        private int range;

	    public const ConsoleColor PROMPT = ConsoleColor.Blue;
	    public const ConsoleColor INPUT = ConsoleColor.Green;
	    public const ConsoleColor ERROR = ConsoleColor.Red;

	    public void playGame()
	    {
		    Console.Title = "Number Guessing Game";
		    Console.BackgroundColor = ConsoleColor.DarkGray;
		    Console.Clear();
		    Console.ForegroundColor = PROMPT;

		    Console.WriteLine(
			    "Welcome to the number guessing game!\n\n" +
			    "You give me a range of numbers and I'll choose a number in that range.\n" +
			    "Then you can guess the number and I'll count how many tries it takes.");

		    getRange();
    	
		    Console.WriteLine("\n\nI'm now thinking of a number between " + min +
			    " and " + max + ".  See if you can guess it!\n");

		    chooseSecretNumber();

		    getGuesses();

            displayResults();

	    }

        private void getRange()
        {
            min = Utilities.inputInt("\nEnter the smallest number in the range: ", PROMPT, INPUT, ERROR);
            max = Utilities.inputInt("Enter the biggest number in the range: ", min, int.MaxValue, PROMPT, INPUT, ERROR);
        }

        private void chooseSecretNumber()
	    {
            Random generator = new Random();
            secretNumber = generator.Next(min, max + 1);
#if DEBUG
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Secret number = " + secretNumber);
#endif
        }

        private void getGuesses()
	    {
            do
            {
                guess = Utilities.inputInt("\nEnter a guess: ", min, max, PROMPT, INPUT, ERROR);
                Console.ForegroundColor = PROMPT;
                if (guess < secretNumber)
                {
                    Console.WriteLine("You're too low!");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("You're too high!");
                }
                guessCount++;
            } while (guess != secretNumber);
	    }

	    private void displayResults()
	    {
            Console.ForegroundColor = PROMPT;
            Console.WriteLine("You got it in " + guessCount + " guesses.");
            range = max - min;


            if ((range / guessCount) <= (5))
            {
                Console.WriteLine("That was pathetic.");
            }
            else if ((range / guessCount) <= (10))
            {
                Console.WriteLine("Not bad. But not good either. Actually, you suck.");
            }
            else if ((range / guessCount) <= (25))
            {
                Console.WriteLine("I guess that was pretty good.");
            }
            else if ((range / guessCount) <= (50))
            {
                Console.WriteLine("Amazing! You must be some kind of wizard.");
            }
            else
            {
                Console.WriteLine("Did you cheat? How did you even guess it?????????");
            }
        }
    }
}