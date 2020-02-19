using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctor_sHelper
{
    class Stomach
    {
        public static void askQuestion()
        {
            DialogResult stomach = MessageBox.Show("Does your stomach hurt?", "Stomach Ache Question",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (stomach == DialogResult.Yes)
            {
                Beans.askQuestion();
            }
            else
            {
                MessageBox.Show("You are fine. Just go home and sleep it off. Your fee will be $40.",
                    "Diagnosis", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
