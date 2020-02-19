using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Boxes b = new Boxes();
            b.paint(e.Graphics);

            WordsAndLines w = new WordsAndLines();
            w.paint(e.Graphics);

            OtherShapes.paint(e.Graphics);
            StringBeads.paint(e.Graphics);
        }
    }
}
