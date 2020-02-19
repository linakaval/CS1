//Lina Kaval
//Period 4
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctor_sHelper
{
    class Pulse
    {
        public static void askQuestion()
        {
            DialogResult pulse = MessageBox.Show("Do you have a pulse?", "Pulse Question",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (pulse == DialogResult.Yes)
            {

                Head.askQuestion();
            }
            else
            {
                MessageBox.Show("You are dead. Why are you even here, this isn't the morgue. Pay $40 for wasting my time.",
                    "Diagnosis", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
