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
    class Program
    {
        static void Main(string[] args)
        {
            RainChart rc = new RainChart(4);
            rc.inputRainData();
            rc.displayChart();
        }
    }
}
