using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BrickHouse
{
    class Window
    {
        public static void paint(Graphics rectangle, Brush r, int x, int y, int width, int height)
        {
            rectangle.FillRectangle(r, x, y, width, height); //makes the window
            rectangle.DrawRectangle(Pens.Black, x, y, width, height); //outlines the window (border)
            rectangle.DrawLine(Pens.Black, x + width / 2, y, x + width / 2, y + height); //makes vertical line through the window
            rectangle.DrawLine(Pens.Black, x, y + height / 2, x + width, y + height / 2); //makes horizontal line through the window
        }

        public static void paintRound(Graphics circle, Brush c, int x, int y, int width, int height)
        {
            circle.FillEllipse(c, x, y, width, height); //makes the round circle
            circle.DrawEllipse(Pens.Black, x, y, width, height); //outlines the window (border)
            circle.DrawLine(Pens.Black, x + width / 2, y, x + width / 2, y + height); //makes vertical line through the window
            circle.DrawLine(Pens.Black, x, y + height / 2, x + width, y + height / 2); //makes horizontal line through the window
        }
    }
}
