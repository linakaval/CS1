using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicsDemo
{
    class WordsAndLines
    {
        public void paint(Graphics g)
        {
            g.DrawLine(/*Pens.Chartreuse OR*/ new Pen(Color.Chartreuse, 5), 200, 200, 400, 200); //use a brush for filling, pens for drawing
            //200, 200 is the starting x and y
            //400, 200 is the ending x and y

            g.DrawString("Howdy!", new Font("wingdings", 36, FontStyle.Bold), new SolidBrush(Color.FromArgb(98, 45, 102)), 200, 100);
        }
    }
}
