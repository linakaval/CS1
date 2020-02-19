using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BrickHouse
{
    class Door
    {
        public static void paint(Graphics door)
        {
            door.FillRectangle(Brushes.LightYellow, 280, 340, 60, 120); //makes the door
            door.FillEllipse(Brushes.Gold, 325, 395, 10, 10); //makes the doorknob
        }
    }
}
