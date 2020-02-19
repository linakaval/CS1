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

namespace CricketThermometer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double chirpNumber, secondNumber, chirpsPerMinute, temperature;

            chirpNumber = Convert.ToDouble(txtChirp.Text);
            secondNumber = Convert.ToDouble(txtSeconds.Text);
            chirpsPerMinute = (60 / secondNumber)*chirpNumber;
            temperature = (chirpsPerMinute + 40)/4;

            lblAnswer.Text = temperature.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
