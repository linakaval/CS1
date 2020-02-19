using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace BrickHouse
{
    class Grass
    {
        public static void paint(Graphics ground)
        {
            ground.FillRectangle(new HatchBrush(HatchStyle.DashedDownwardDiagonal, Color.Black, Color.LawnGreen), 0, 460, 640, 160); //makes grass with diagonal lines through it
        }
    }
}
