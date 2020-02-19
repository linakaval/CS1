using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BrickHouse
{
    class BrickHouse
    {
        public void paint(Graphics house)
        {
            HouseFrame.paint(house);
            Roof.paintChimney(house, 390, 110, 40, 70);
            Roof.paint(house);            
            Door.paint(house);
            Window.paint(house, Brushes.LightYellow, 180, 240, 40, 60);
            Window.paint(house, Brushes.LightYellow, 400, 240, 40, 60);
            Window.paint(house, Brushes.LightYellow, 180, 350, 80, 60);
            Window.paint(house, Brushes.LightYellow, 360, 350, 80, 60);
            Window.paintRound(house, Brushes.Linen, 290, 250, 40, 40);
        }      
    }
}
