using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentTester
{
    public partial class Form1 : Form
    {
        Student kid;

        public Form1()
        {
            InitializeComponent();
        }

        string studentName;

        private void btnNew_Click(object sender, EventArgs e)
        {
            kid = new Student(studentName);
            studentName = Convert.ToString(txtStudentName);
            lblStudentName.Text = kid.getName();

            lblAvg.Text = "0";
            lblTotal.Text = "0";


        }
    }
}
