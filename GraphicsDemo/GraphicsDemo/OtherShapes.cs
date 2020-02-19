using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GraphicsDemo
{
    class OtherShapes
    {
        public static void paint(Graphics g)
        {
            g.FillEllipse(new HatchBrush(HatchStyle.Weave, Color.Black, Color.Cornsilk), 170, 300, 200, 50);
            //black is foreground color, cornsilk is background, using a hatchstyle
            g.FillPie(Brushes.Fuchsia, 201, 250, 80, 80, 30, 300); 
            //fuchsia is the color, 201 and 250 are xy, 80 80 makes a rectangle, 30 is the starting angle, 300 is the sweep angle
        }
    }
}
