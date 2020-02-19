using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctor_sHelper
{
    class Eyes
    {
        public static void askQuestion()
        {
            DialogResult eyes = MessageBox.Show("Do your eyes hurt?", "Eye Question",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (eyes == DialogResult.Yes)
            {
                MessageBox.Show("You have malaria. Unfortunately the diagnosis was too late, so you're going to die. Your fee is $40.",
                    "Diagnosis", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("You have a migraine. Go take some Advil. Your fee is $40.",
                    "Diagnosis", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}   
