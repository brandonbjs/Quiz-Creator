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
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpScreen signUpScreen1 = new SignUpScreen();

            signUpScreen1.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string server = "quizcreatordb.ctvd1ztjykvr.us-east-1.rds.amazonaws.com";
                string database = "QC_database";
                string uid = "admin";
                string password = "quizcreator";
                string connectionString = "Server=" + server + "; Port=3306; Database=" + database + "; Uid=" + uid + "; Pwd=" + password;

                MySqlConnection conn = new MySqlConnection(connectionString);

                conn.Open();

                string sql = "SELECT * FROM accounts WHERE acc_email= '" + txtEmail.Text + "' AND acc_password='" + txtPassword.Text + "';";

                var cmd = new MySqlCommand(sql, conn);

                MySqlDataReader rdr = cmd.ExecuteReader();

                if (!rdr.Read())
                {
                    MessageBox.Show("Account not found.");

                    return;
                }
                else
                {
                    Hide();
                }

                conn.Close();
            }
            catch
            {
                MessageBox.Show("Error connecting to database");
            }
        }
    }
}