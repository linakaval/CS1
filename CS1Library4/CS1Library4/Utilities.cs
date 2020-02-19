using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS1Library4
{
    public class Utilities
    {
        /// <summary>
        /// method where you don't want anything back
        /// </summary>
        /// <returns></returns>
        public static int inputInt()
        {
            return inputInt("", int.MinValue, int.MaxValue, Console.ForegroundColor, 
                Console.ForegroundColor, Console.ForegroundColor);
        }

        public static int inputInt(string prompt, ConsoleColor promptColor, ConsoleColor inputColor, ConsoleColor errorColor)
        {
            return inputInt(prompt, int.MinValue, int.MaxValue, promptColor, inputColor, errorColor);
        }


        public static int inputInt(string prompt, int min, int max, ConsoleColor promptColor, 
            ConsoleColor inputColor, ConsoleColor errorColor)
        {
            int number = -1;   //just to make the compiler happy
            bool bad = true;
            ConsoleColor saveColor = Console.ForegroundColor;
            do
            {
                try
                {
                    Console.ForegroundColor = promptColor;
                    Console.Write(prompt);

                    Console.ForegroundColor = inputColor;
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number < min || number > max)
                    {
                        Console.ForegroundColor = errorColor;
                        Console.WriteLine("Range error [" + min + " - " + max + "]");
                    }
                    else
                    {
                        bad = false;
                    }
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = errorColor;
                    Console.WriteLine("That's not a number");
                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = errorColor;
                    Console.WriteLine("That's not a legal number");
                }
                } while (bad);

            Console.ForegroundColor = saveColor;
            return number;
        }
    }
}
