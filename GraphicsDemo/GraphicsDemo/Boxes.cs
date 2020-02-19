using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; //Don't forget to do this
using System.Drawing.Drawing2D;

namespace GraphicsDemo
{
    class Boxes
    {
        public void paint(Graphics g)
        {
            g.FillRectangle(Brushes.Violet, 0, 0, 600, 400); //first 2 numbers are upper left x,y,; next two numbers are width and height

            LinearGradientBrush fade = new LinearGradientBrush(new Rectangle(0, 0, 50, 30), Color.HotPink, Color.LavenderBlush, 90);
            //we created an object in a constructor (this is an anonymous object)
            //Hot Pink is the starting color
            //Lavender Blush is the ending color
            //45 is the fade angle
            g.FillRectangle(fade, 30, 30, 540, 340);
        }
    }
}
