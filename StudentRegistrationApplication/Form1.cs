using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadComboBoxes();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtMiddleName.Text))
            {
                MessageBox.Show("Please fill in all name fields.", "Validation Error");
                return;
            }

            if (!rbMale.Checked && !rbFemale.Checked)
            {
                MessageBox.Show("Please select a gender.", "Validation Error");
                return;
            }

            if (cboDay.SelectedIndex == 0 || cboMonth.SelectedIndex == 0 || cboYear.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a complete date of birth.", "Validation Error");
                return;
            }

            string gender = "";
            if (rbMale.Checked)
                gender = "Male";
            else if (rbFemale.Checked)
                gender = "Female";

            string dob = cboDay.SelectedItem + "/" + cboMonth.SelectedItem + "/" + cboYear.SelectedItem;

            string fullName = txtFirstName.Text.Trim() + " " + txtMiddleName.Text.Trim() + " " + txtLastName.Text.Trim();

            MessageBox.Show(
                "Student name: " + fullName + "\n" +
                "Gender: " + gender + "\n" +
                "Date of birth: " + dob,
                "Student Registration"
            );
        }

        private void LoadComboBoxes()
        {
            cboDay.Items.Add("-Day-");
            for (int d = 1; d <= 31; d++)
                cboDay.Items.Add(d);
            cboDay.SelectedIndex = 0;

            cboMonth.Items.Add("-Month-");
            for (int m = 1; m <= 12; m++)
                cboMonth.Items.Add(m);
            cboMonth.SelectedIndex = 0;

            cboYear.Items.Add("-Year-");
            for (int y = 1900; y <= DateTime.Now.Year; y++)
                cboYear.Items.Add(y);
            cboYear.SelectedIndex = 0;
        }
    }
}
