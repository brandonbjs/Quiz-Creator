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
        public LoginScreen(ref User refCurrentUser)
        {
            InitializeComponent();

            currentUser = refCurrentUser;
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
                    currentUser.SetEmail(rdr.GetString("acc_email"));

                    currentUser.setLoginStatus(true);

                    currentUser.SetID(rdr.GetInt32(0));

                    conn.Close();

                    conn.Open();

                    string sqlCourseSelect = "SELECT * FROM QC_database.course_account WHERE account_id= " + currentUser.getID() + ";";

                    var cmdGetCourses = new MySqlCommand(sqlCourseSelect, conn);

                    MySqlDataReader rdrGetCourses = cmdGetCourses.ExecuteReader();

                    List<string> extractedCourses = new List<string>();

                    while (rdrGetCourses.Read())
                    {
                        extractedCourses.Add(rdrGetCourses.GetString("course_name"));
                    }
                    conn.Close();

                    conn.Open();
                    string sqlInstructorSelect = "SELECT * FROM courses WHERE course_name IN ('";

                    for(int index = 0; index < extractedCourses.Count; index++)
                    {
                        if (index == extractedCourses.Count -1)
                        {
                            sqlInstructorSelect += extractedCourses[index] + "');";
                        }
                        else
                        {
                            sqlInstructorSelect += extractedCourses[index] + "', '";
                        }
                    }

                    var cmdGetInstructors = new MySqlCommand(sqlInstructorSelect, conn);

                    MySqlDataReader rdrGetInstructors = cmdGetInstructors.ExecuteReader();

                    for(int i = 0; rdrGetInstructors.Read(); i++)
                    {
                        Course newCourse = new Course(extractedCourses[i], rdrGetInstructors.GetString("instructor_name"));

                        currentUser.AddToCourseList(newCourse);
                    }

                    MessageBox.Show("Welcome, " + currentUser.GetEmail() + "!");
                }
                conn.Close();

                Close();

            }
            catch
            {
                MessageBox.Show("Error connecting to database");
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }
    }
}