using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinInputDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int operand1, operand2, sum;

            operand1 = Convert.ToInt32(txtNum1.Text);
            operand2 = Convert.ToInt32(txtNum2.Text);
            sum = operand1 + operand2;

            lblAnswer.Text = sum.ToString();
        }
    }
}
