using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number, mySuit, myRank;
            number = Convert.ToInt16(Console.ReadLine());
            mySuit = number / 12;
            myRank = number % 12;
            Console.WriteLine(Convert.ToString(mySuit) + Convert.ToString(myRank));
        }
    }
}
