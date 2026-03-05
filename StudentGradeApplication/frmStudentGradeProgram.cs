using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeApplication
{
    public partial class frmStudentGradeProgram : Form
    {
        public frmStudentGradeProgram()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                string studentName = txtName.Text;
                double english = Convert.ToDouble(txtEnglish.Text);
                double math = Convert.ToDouble(txtMath.Text);
                double science = Convert.ToDouble(txtScience.Text);
                double filipino = Convert.ToDouble(txtFilipino.Text);
                double history = Convert.ToDouble(txtHistory.Text);

                double average = (english + math + science + filipino + history) / 5;

                string passed = (average >= 75.00) ? "The student passed." : "The student failed.";

                lblPassed.Text = passed;
                lblGrade.Text = "The general average of " + studentName + " is " + average.ToString("0.00") + ".";
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter numbers only.");
            }
        }

        private void frmStudentGradeProgram_Load(object sender, EventArgs e)
        {

        }
    }
}
