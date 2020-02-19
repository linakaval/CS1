using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctor_sHelper
{
    class Head
    {
        public static void askQuestion()
        {
            DialogResult head = MessageBox.Show("Does your head hurt?", "Headache Question",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (head == DialogResult.Yes)
            {
                Eyes.askQuestion();

            }

            else
            {
                Stomach.askQuestion();
            }
        }
    }
}
