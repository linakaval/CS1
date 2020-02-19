using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerDemo
{
    public partial class Form1 : Form
    {
        private int myCount;
        private Box myBox;

        public Form1()
        {
            InitializeComponent();

            myBox = new Box(new Rectangle(0, 0, 20, 20), pictureBox1.ClientRectangle, Brushes.Chartreuse, 1);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;          
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            myCount = 0;
            label1.Text = "0";          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            myCount++;
            label1.Text = myCount.ToString();
            myBox.move();
            Refresh();            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
            myBox.paint(e.Graphics);
            //never call refresh here
        }
    }
}
