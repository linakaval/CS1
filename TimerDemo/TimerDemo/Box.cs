using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TimerDemo
{
    class Box
    {
        private Rectangle myRectangle;
        private Rectangle myBounds;
        private Brush myBrush;
        private int dx, dy;

        public Box(Rectangle aRectangle, Rectangle aBounds, Brush aBrush, int aSpeed)
        {
            myRectangle = aRectangle;
            myBrush = aBrush;
            dx = dy = aSpeed;
            myBounds = aBounds;
        }

        public void paint(Graphics g)
        {
            g.FillRectangle(myBrush, myRectangle);
        }

        public void move()
        {
            myRectangle.O
            myRectangle.Offset(dx, dy);
            myRectangle.X %= myBounds.Width; // or .right

            if (myRectangle.Bottom >= myBounds.Bottom || myRectangle.Top <= myBounds.Top)
            {
                dy = -dy;
            }
        }
    }
}
