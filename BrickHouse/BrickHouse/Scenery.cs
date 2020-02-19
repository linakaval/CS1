using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace BrickHouse
{
    class Scenery
    {
        public void paint(Graphics scene)
        {
            Sky.paint(scene);
            Sky.paintMoon(scene);
            Grass.paint(scene);
            Tree.paintTree(scene, 70, 360, 40, 20);
            Tree.paintTree(scene, 550, 360, 40, 20);

        }
    }
}
