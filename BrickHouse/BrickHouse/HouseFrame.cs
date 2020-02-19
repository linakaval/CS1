using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BrickHouse
{
    class HouseFrame
    {
        public static void paint(Graphics frame)
        {
            frame.FillRectangle(Brushes.IndianRed, 150, 200, 320, 260); //makes the frame of the house
        }
    }
}
