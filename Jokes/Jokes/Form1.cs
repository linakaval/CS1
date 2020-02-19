//Lina Kaval
//Period 4

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jokes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shelfies!",
                "I'm sorry.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I don't know and I don't care.",
                "I'm sorry.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You let that sink in.",
                "I'm sorry.");
        }
    }
}
