using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BrickHouse
{
    class Name
    {
        private string myName;
        private Rectangle myBounds;
        private int dx, dy;


        public Name(string aName, Rectangle aBounds, int aSpeed)
        {
            myName = aName;
            myBounds = aBounds;
            dx = dy = aSpeed;
        }

        public void paint(Graphics n)
        {
            n.DrawString(myName, new Font("Times New Roman", 20), Brushes.AliceBlue, 10, 10);
        }
    }
}
