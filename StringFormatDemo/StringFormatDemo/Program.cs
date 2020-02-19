using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFormatDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a 3-digit number:");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Here is your number with leading zeros.");
            Console.WriteLine(num.ToString("D8"));
        }
    }
}
