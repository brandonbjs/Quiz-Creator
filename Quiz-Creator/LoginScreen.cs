using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Xml;

namespace Quiz_Creator
{
    public partial class LoginScreen : Form
    {
        private User currentUser;
        public LoginScreen()
        {
            InitializeComponent();

            currentUser = User.getInstance();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpScreen signUpScreen1 = new SignUpScreen();

            signUpScreen1.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(Database.AddAccountToUserObject(txtEmail.Text, txtPassword.Text))
            {
                Database.AddUserCourses();

                MessageBox.Show("Welcome, " + currentUser.GetEmail() + "!");

                Close();
            }
            else
            {
                MessageBox.Show("Account not found.");
            }
        }
    }
}