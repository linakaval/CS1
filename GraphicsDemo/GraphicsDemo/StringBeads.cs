using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicsDemo
{
    class StringBeads
    {
        public static void paint(Graphics g)
        {
            //create a canvas in memory
            Bitmap texture = new Bitmap(10, 10);

            //attach a graphics object to the canvas so that we can draw
            Graphics g2 = Graphics.FromImage(texture);
            //anything drawn on g2 will go not to the screen. but to the canvas

            //create a semi-transparent background
            g2.FillRectangle(
                new SolidBrush(
                    Color.FromArgb(
                        100, //transparency value
                        120, //red
                        230, //green
                        75)), //blue
                 0, 0, 10, 10);

            //draw the string
            g2.DrawLine(Pens.Magenta, 4, 0, 4, 9);

            //draw the bead
            g2.FillEllipse(Brushes.Turquoise, 3, 3, 3, 3);

            //create the brush
            TextureBrush tb = new TextureBrush(texture);
            g.FillRectangle(tb, 330, 75, 200, 300); 

        }
    }
}
