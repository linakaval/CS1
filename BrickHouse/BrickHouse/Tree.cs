using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BrickHouse
{
    class Tree
    {
        public static void paintTree(Graphics tree, int x, int y, int width, int height)
        {
            IsosTriangle.paint(tree, Brushes.DarkGreen, x, y, width, height); //the top triangle of the tree
            IsosTriangle.paint(tree, Brushes.DarkGreen, x, y + 10, width + 20, height + 10); //the next triangle of the tree
            IsosTriangle.paint(tree, Brushes.DarkGreen, x, y + 20, width + 40, height + 20); //the 3rd triangle of the tree
            IsosTriangle.paint(tree, Brushes.DarkGreen, x, y + 30, width + 60, height + 30); //the bottom triangle of the tree
            tree.FillRectangle(Brushes.Brown, x-10, y + 80, width - 20, height); //stump of the tree
        }
    }
}
