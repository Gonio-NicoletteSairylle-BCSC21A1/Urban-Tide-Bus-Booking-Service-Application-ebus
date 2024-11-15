using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urban_Tide_Bus_Booking_Service_Application
{
    public partial class FormforgetPass : Form
    {
        public FormforgetPass()
        {
            InitializeComponent();
        }

        private void label1URBAN_Click(object sender, EventArgs e)
        {
            // Optional: You can handle any event for this label here if needed.
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: Handle DataGridView events here if needed.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Close the FormforgetPass when the Cancel button is clicked
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string enteredUsername = textBox1.Text.Trim();
            DateTime selectedDate = dateTimePicker1.Value;

            // Define the correct credentials and date values
            const string correctUsername = "USER";
            const int requiredYear = 2003;
            const int requiredMonth = 1; // January
            const int requiredDay = 10;

            // Check if username is correct
            bool isUsernameCorrect = enteredUsername == correctUsername;

            // Check if the birthdate matches January 10, 2003
            bool isBirthdateCorrect = selectedDate.Year == requiredYear
                                      && selectedDate.Month == requiredMonth
                                      && selectedDate.Day == requiredDay;

            // If both credentials and birthdate are correct, proceed with login
            if (isUsernameCorrect && isBirthdateCorrect)
            {
                MessageBox.Show("Login successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open Form2UserMainMenu
                Form2UserMainMenu mainMenuForm = new Form2UserMainMenu();
                mainMenuForm.Show();

                // Close the current form (FormforgetPass) after successful login
                this.Close();
            }
            else
            {
                // Display an error message if credentials or birthdate are incorrect
                if (!isUsernameCorrect)
                {
                    MessageBox.Show("Error: Incorrect username", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error: Incorrect birthdate.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
