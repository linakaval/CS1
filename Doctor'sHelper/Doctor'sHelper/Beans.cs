using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctor_sHelper
{
    class Beans
    {
        public static void askQuestion()
        {
            DialogResult beans = MessageBox.Show("Have you eaten beans recently?", "Bean Question",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (beans == DialogResult.Yes)
            {
                MessageBox.Show("You have gas. Don't you dare even think about passing it here. Your fee will be $40.",
                    "Diagnosis", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("You have morning sickness. Congrats on the baby. Hopefully it won't be as stupid as you. Your fee will be $40.",
                    "Diagnosis", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
