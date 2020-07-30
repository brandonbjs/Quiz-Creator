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
    public partial class JoinCoursePasswordScreen : Form
    {
        private string courseName;

        private string coursePassword;

        string server = "quizcreatordb.ctvd1ztjykvr.us-east-1.rds.amazonaws.com";
        string database = "QC_database";
        string uid = "admin";
        string password = "quizcreator";

        private User currentUser;

        public JoinCoursePasswordScreen(string in_courseName, string in_pass, ref User in_User)
        {
            InitializeComponent();

            courseName = in_courseName;

            coursePassword = in_pass;

            currentUser = in_User;
        }

        private void JoinCoursePasswordScreen_Load(object sender, EventArgs e)
        {
            lblCourseName.Text = courseName;
        }

        private void btnJoinCourse_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text == coursePassword)
            {
                string connectionString = "Server=" + server + "; Port=3306; Database=" + database + "; Uid=" + uid + "; Pwd=" + password;

                MySqlConnection conn = new MySqlConnection(connectionString);

                conn.Open();

                string insertSql = "INSERT INTO course_account (account_id, course_name) ";
                insertSql += "VALUES ('" + currentUser.getID() + "', ";
                insertSql += "'" + courseName + "');";

                var insertCmd = new MySqlCommand(insertSql, conn);

                insertCmd.ExecuteNonQuery();

                MessageBox.Show("Welcome to " + courseName + "!");

                conn.Close();

                Close();
            }
            else
            {
                MessageBox.Show("Incorrect password. Try again.");
            }
        }
    }
}
