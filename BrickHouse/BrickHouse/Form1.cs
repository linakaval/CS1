using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickHouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Scenery scene = new Scenery();
            scene.paint(e.Graphics);

            BrickHouse house = new BrickHouse();
            house.paint(e.Graphics);

            e.Graphics.DrawString("Lina Kaval", new Font("Times New Roman", 20), Brushes.MintCream, 10, 10);
        }
    }
}
