/*
Brad Davidson
Chris Brown
Lina Kaval
Period 4
5/5/2016
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainChart
{
    class RainChart
    {
        private double[] myData;
        private int numberofMonths;
        private double chartNumber;
        private double testDouble;

        public RainChart(int aNumberOfMonths)
        {
            numberofMonths = aNumberOfMonths;
            myData = new double[numberofMonths];
        }

        public void inputRainData()
        {
            Console.WriteLine("Enter rainfall data for " + numberofMonths + " months to the nearest tenth of an inch:");
            for (int i = 0; i < numberofMonths; i++)
            {
                do
                {
                    testDouble = Convert.ToDouble(Console.ReadLine());
                    if (!(testDouble < 5))
                    {
                        Console.WriteLine("OK... This isn't the Amazon rain forest. Enter something less than 5.");
                    }
                    else if (testDouble < 0)
                    {
                        Console.WriteLine("OK... Negative precipitation is not a thing. Try again.");
                    }
                } while (!(testDouble < 5) || testDouble < 0);
                myData[i] = testDouble;
            }
        }

        public void displayChart()
        {
            Console.Clear();
            Console.WriteLine("Rainfall Chart - Each '*' = .1 inches\n");
            for (int i = 0; i < myData.Length; i++)
            {
                chartNumber = myData[i] * 10;
                Console.Write(myData[i].ToString("F1") + ":\t\t");
                for (int lcv = 0; lcv < chartNumber; lcv++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n\n");
        }
    }
}
