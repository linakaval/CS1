using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace BrickHouse
{
    class Sky
    {
        public static void paint(Graphics sky)
        {
            LinearGradientBrush sunset = new LinearGradientBrush(new Rectangle(0, 0, 640, 600), Color.FromArgb(240, 10, 160), Color.OrangeRed, 90); //makes the linear gradient color for the sky
            sky.FillRectangle(sunset, 0, 0, 640, 460); //fills the sky with the color made above
        }

        public static void paintMoon(Graphics sunset)
        {
            sunset.FillEllipse(Brushes.LightGoldenrodYellow, new Rectangle(50, 50, 90, 80)); //made a moon
            sunset.FillEllipse(new SolidBrush(Color.FromArgb(250, 240, 10, 155)), new Rectangle(65, 50, 90, 80)); //covered part of the moon to make it a crescent
        }
    }
}
