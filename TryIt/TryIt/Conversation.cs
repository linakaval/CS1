//Name: Lina Kaval
//Period: 4

using System;

namespace TryIt
{
    class Conversation
    {
        //Declare constants that define the inout range.
        private const int MIN = 1;
        private const int MAX = 4;

        //Declare constants for the colors to be used.
        private const ConsoleColor INPUT_COLOR = ConsoleColor.Green;
        private const ConsoleColor PROMPT_COLOR = ConsoleColor.Blue;
        private const ConsoleColor ERROR_COLOR = ConsoleColor.Red;
        private const ConsoleColor MESSAGE_COLOR = ConsoleColor.DarkMagenta;
        private const ConsoleColor BACKGROUND_COLOR = ConsoleColor.DarkGray;

        private String name;

        public Conversation()
        {
            Console.Title = "See Your Fortune!";
            Console.BackgroundColor = BACKGROUND_COLOR;
            Console.Clear();
        }

        public void go()
        {
            getName();
            int number = getNumber();
            displayMessage(number);

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
        }

        private void getName()
        {
            Console.ForegroundColor = PROMPT_COLOR;
            Console.Write("Enter your name.  ");
            Console.ForegroundColor = INPUT_COLOR;

            // Computer reads input message
            name = Console.ReadLine();
        }

        private int getNumber()
        {
            int input;

            // Starts method get number
            do
            {
                Console.ForegroundColor = PROMPT_COLOR;
                Console.Write("\nEnter a number from 1 to 4.  ");
                Console.ForegroundColor = INPUT_COLOR;

                // Changes inputted number to a format the computer understands
                input = Convert.ToInt16(System.Console.ReadLine());

                // Checks if the number is between 1 and 4
                if (input < MIN || input > MAX)
                {
                    Console.ForegroundColor = ERROR_COLOR;
                    Console.WriteLine("Invalid number!");

                }
            } while (input < MIN || input > MAX);

            return input;
        }

        private void displayMessage(int choice)
        {
            String phrase = "";

            // Computer picks the phrase from the inputted number
            switch (choice)
            {
                case 1: phrase = " is hated by everyone!"; break;
                case 2: phrase = " will do great on his/her upcoming math test! (naw sike)"; break;
                case 3: phrase = " wishes he/she could die " + "and plays Minecraft all day."; break;
                case 4: phrase = " will fall down the stairs tomorrow. Watch out."; break;
            }

            Console.WriteLine();
            Console.ForegroundColor = MESSAGE_COLOR;

            // Computer outputs name and phrase 10 times
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(counter + ") " + name + phrase);
            }
        }
    }
}
