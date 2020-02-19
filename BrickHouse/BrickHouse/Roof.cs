using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BrickHouse
{
    class Roof
    {
        public static void paint(Graphics roof)
        {
            IsosTriangle.paint(roof, Brushes.Brown, 310, 80, 360, 130); //makes the roof
        }
        public static void paintChimney(Graphics chimney, int x, int y, int width, int height)
        {
            chimney.FillRectangle(Brushes.IndianRed, x, y, width, height); //makes the chimney
            chimney.FillEllipse(Brushes.WhiteSmoke, x, y - 30, 40, 20); //makes the bottom cloud
            chimney.FillEllipse(Brushes.WhiteSmoke, x + 40, y - 60, 40, 20); //makes the second cloud
            chimney.FillEllipse(Brushes.WhiteSmoke, x + 80, y - 90, 40, 20); //makes the top cloud
        }
    }
}
