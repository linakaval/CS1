using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASCIIAnimation
{
    public partial class Form1 : Form
    {
        private AsciiAnimator aa; //new ascii animator

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Grab the current trackbar value so that we can adjust the speed
            //while the animation is running.
            int speed = trackBar1.Maximum - trackBar1.Value + 1;
            timer1.Interval = (speed * 10);

            label1.Text = aa.getNextFrame();
            lblCurrentFrame.Text = ("" + aa.getCurrentFrameNumber());
            this.Update();
        }

        private void jJacksButton_Click(object sender, EventArgs e)
        {
            //Make a new animation using the animation file stored in the project resources.
            //The 2nd parameter is the split value that divides the frames.
            aa = new AsciiAnimator(ASCIIAnimation.Properties.Resources.JumpingJacks, "Z");

            //Take the value from the trackbar and multiply it by 10.  Use the result
            //as the delay interval for the timer.  Remember that the larger the interval
            //the slower the speed, so flip the trackbar number first by subtracting it
            //from the max value.  Add 1 to make sure it isn't zero.
            timer1.Interval = ((trackBar1.Maximum - trackBar1.Value + 1) * 10);

            timer1.Start();
        }

        private void trainButton_Click(object sender, EventArgs e)
        {
            aa = new AsciiAnimator(ASCIIAnimation.Properties.Resources.Train, "X");

            timer1.Interval = ((trackBar1.Maximum - trackBar1.Value + 1) * 10);

            timer1.Start();
        }

        private void computerAngerButton_Click(object sender, EventArgs e)
        {
            aa = new AsciiAnimator(ASCIIAnimation.Properties.Resources.ComputerAnger, "Q");

            timer1.Interval = ((trackBar1.Maximum - trackBar1.Value + 1) * 10);

            timer1.Start();
        }

        private void ballPass_Click(object sender, EventArgs e)
        {
            aa = new AsciiAnimator(ASCIIAnimation.Properties.Resources.BallPass, "B");

            timer1.Interval = ((trackBar1.Maximum - trackBar1.Value + 1) * 10);

            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
