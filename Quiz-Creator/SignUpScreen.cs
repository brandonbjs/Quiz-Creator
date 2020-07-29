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
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            if(AcceptableFields())
            {
                try
                {
                    //Build connection string to remote database
                    string server = "quizcreatordb.ctvd1ztjykvr.us-east-1.rds.amazonaws.com";
                    string database = "QC_database";
                    string uid = "admin";
                    string password = "quizcreator";
                    string connectionString = "Server=" + server + "; Port=3306; Database=" + database + "; Uid=" + uid + "; Pwd=" + password;

                    MySqlConnection conn = new MySqlConnection(connectionString);

                    conn.Open();

                    //build sql command
                    string sql = "INSERT INTO acc_info (acc_email, acc_password, acc_org, acc_role) ";
                    sql += "VALUES ('" + textboxEmail.Text + "', ";
                    sql += "'" + textboxPassword.Text + "', ";
                    sql += "'" + comboBoxOrg.Text + "', ";
                    sql += "'" + comboBoxType.Text + "');";

                    var cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    conn.Close();

                    MessageBox.Show("Account created successfully!");
                    Close();
                }
                catch
                {
                    MessageBox.Show("Error connecting to database");
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
