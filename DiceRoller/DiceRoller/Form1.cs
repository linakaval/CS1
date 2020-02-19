//Lina Kaval

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRoller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Random diceRoll = new Random();

        private void btnRoll_Click(object sender, EventArgs e)
        {
            uint rolls;
            lblResults.Text = "";

            try
            {
                rolls = Convert.ToUInt32(txtRollCount.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("That's not a legal value, try again.");
                return;
            }
            
            int[] diceRollCount = new int[11];

            for (int i = 0; i < rolls; i++)
            {                
                int diceSum;
                diceSum = diceRoll.Next(6) + diceRoll.Next(6);
                diceRollCount[diceSum]++;
            }

            for (int i = 0; i < diceRollCount.Length; i++)
            {
                lblResults.Text += (i + 2) + ") " + diceRollCount[i] + "\n";
            }
        }
    }
}
