using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicsDemoPart2
{
    class IsosTriangle
    {
        public static void paint(Graphics g, Brush aBrush, int x, int y, int width, int height)
        {
            Point[] points =
            {
                new Point(x,y), //top point
                new Point(x - width/2, y + height), //lower left
                new Point(x + width/2, y + height) //lower right
            };
            g.FillPolygon(aBrush, points);
        }
    }
}
