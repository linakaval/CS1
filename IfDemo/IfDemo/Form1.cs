using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IfDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(textBox1.Text);

            if (temp <= 32)
            {
                MessageBox.Show("Brrrr! It's cold!", "Cold Weather", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (temp <= 55)
            {
                MessageBox.Show("It's a bit chilly.", "Meh", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if(temp <= 90)
            {
                MessageBox.Show("It's nice outside!", "Warm Weather", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                MessageBox.Show("It's too hot!", "Hot Weather", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //this is a multi branch decision structure ^^

            DialogResult answer =  MessageBox.Show("Are you having fun?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                MessageBox.Show("Great yo!");
            }
            else
            {
                MessageBox.Show("You suck!");
            }
        }
    }
}
