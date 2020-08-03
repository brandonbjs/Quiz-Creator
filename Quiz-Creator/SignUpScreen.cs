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

namespace Quiz_Creator
{
    public partial class SignUpScreen : Form
    {
        public SignUpScreen()
        {
            InitializeComponent();

            comboBoxOrg.SelectedIndex = 0;
            comboBoxType.SelectedIndex = 0;
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            if(AcceptableFields())
            {
                if (Database.AddAccount(textboxEmail.Text, textboxPassword.Text, comboBoxOrg.Text, comboBoxType.Text)
                    && Database.AddAccountToUserObject(textboxEmail.Text, textboxPassword.Text))
                {
                    Database.AddUserCourses();
                    MessageBox.Show("Account created successfully!");
                    Close();
                }
            }
        }
        private Boolean AcceptableFields()
        {
            if(textboxPassword.TextLength == 0 || textboxEmail.TextLength == 0 || comboBoxType.SelectedItem == null)
            {
                MessageBox.Show("One or more of your fields are blank");

                return false;
            }
            if(!(textboxEmail.Text.Contains(".") && textboxEmail.Text.Contains("@")))
            {
                MessageBox.Show("Invalid Email Address");

                return false;
            }
            if (textboxPassword.Text != textboxConfirm.Text)
            {
                MessageBox.Show("Your passwords do not match");

                return false;
            }
            return true;
        }
    }
}
