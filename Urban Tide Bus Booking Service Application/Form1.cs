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
    public partial class Form1 : Form
    {
        public static string Password { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2Password_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // Get the username and password entered by the user
            string username = textBox1Username.Text;
            string password = textBox2Password.Text;

            // Check if the username and password are correct for either user or admin
            if (username == "user" && password == "12345")
            {
                // If correct, open the user main menu form
                Form2UserMainMenu mainMenuForm = new Form2UserMainMenu();
                mainMenuForm.Show(); // Show the user main menu
                this.Hide(); // Hide the login form so the user can't go back to it easily
            }
            else if (username == "admin" && password == "admin123")
            {
                // If correct, open the admin main menu form
                Form3AdministratorPage adminMenuForm = new Form3AdministratorPage();
                adminMenuForm.Show(); // Show the admin page
                this.Hide(); // Hide the login form
            }
            else
            {
                // Display an error message if the login fails
                MessageBox.Show("Incorrect username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1Forgotuserorpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open FormforgetPass as a new form
            FormforgetPass ffp = new FormforgetPass();
            ffp.Show(); // Show FormforgetPass
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2guest_Click(object sender, EventArgs e)
        {
            Form4CreateAccount createAccountForm = new Form4CreateAccount();

            // Show Form4CreateAccount as a new window
            createAccountForm.Show();
        }
    }
}