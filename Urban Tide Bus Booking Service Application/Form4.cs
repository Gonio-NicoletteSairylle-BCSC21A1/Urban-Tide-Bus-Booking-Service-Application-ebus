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
    public partial class Form4CreateAccount : Form
    {
        public Form4CreateAccount()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1titleusername_Click(object sender, EventArgs e)
        {

        }

        private void txtComPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string createusername = textBoxusername.Text;
            string createpassword = txtComPassword.Text;
            DateTime selectedDate = dateTimePicker1.Value;

            // Define the correct date values
            int requiredYear = 2003;
            int requiredMonth = 1; // January
            int requiredDay = 10;

            // Check if username and password are correct
            bool isCredentialsCorrect = createusername == "username" && createpassword == "123";

            // Check if the birthdate components match January 10, 2003
            bool isBirthdateCorrect = selectedDate.Year == requiredYear
                                      && selectedDate.Month == requiredMonth
                                      && selectedDate.Day == requiredDay;

            // If both credentials and birthdate are correct, proceed with login
            if (isCredentialsCorrect && isBirthdateCorrect)
            {
                MessageBox.Show("Login successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open the user main menu form
                Form2UserMainMenu mainMenuForm = new Form2UserMainMenu();
                mainMenuForm.Show(); // Show the user main menu
                this.Hide(); // Hide the login form so the user can't go back to it easily
            }
            else
            {
                // Display an error message if credentials or birthdate are incorrect
                if (!isCredentialsCorrect)
                {
                    MessageBox.Show("Error: Incorrect username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error: Incorrect birthdate.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form4CreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
