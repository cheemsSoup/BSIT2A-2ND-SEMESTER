using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerateAverage_Click(object sender, EventArgs e)
        {
            double english, math, science, filipino, history;

            if (!double.TryParse(txtEnglish.Text, out english) ||
                !double.TryParse(txtMath.Text, out math) ||
                !double.TryParse(txtScience.Text, out science) ||
                !double.TryParse(txtFilipino.Text, out filipino) ||
                !double.TryParse(txtHistory.Text, out history))
            {
                MessageBox.Show("Please enter valid numeric grades.", "Validation Error");
                return;
            }

            if (english < 0 || english > 100 || math < 0 || math > 100 ||
                science < 0 || science > 100 || filipino < 0 || filipino > 100 ||
                history < 0 || history > 100)
            {
                MessageBox.Show("Grades must be between 0 and 100.", "Validation Error");
                return;
            }

            double average = (english + math + science + filipino + history) / 5;

            string result = (average >= 75.00) ? "The student passed." : "The student failed.";

            lblResults.Text = result + "\nThe general average of "
                             + txtName.Text.Trim() + " is "
                             + average.ToString("F2") + ".";
        }

        private void lblResults_Click(object sender, EventArgs e)
        {

        }
    }
}
