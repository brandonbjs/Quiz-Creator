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
using Microsoft.VisualBasic;

namespace Quiz_Creator
{
    public partial class JoinCourseScreen : Form
    {
        string server = "quizcreatordb.ctvd1ztjykvr.us-east-1.rds.amazonaws.com";
        string database = "QC_database";
        string uid = "admin";
        string password = "quizcreator";

        private string courseName;
        private string courseInstructor;

        private User currentUser;

        public JoinCourseScreen(ref User in_User)
        {
            InitializeComponent();

            currentUser = in_User;
        }

        private void JoinCourseScreen_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=" + server + "; Port=3306; Database=" + database + "; Uid=" + uid + "; Pwd=" + password;

            MySqlConnection conn = new MySqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM QC_database.courses;";

            var cmd = new MySqlCommand(sql, conn);

            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                string passwordProtected = "no";

                if (!Convert.IsDBNull(rdr["password"]))
                {
                    passwordProtected = "yes";
                }
                string[] row = { rdr.GetString("course_name"), rdr.GetString("instructor_name"), passwordProtected };

                var listViewItem = new ListViewItem(row);

                listViewCourses.Items.Add(listViewItem);
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonJoinCourse_Click(object sender, EventArgs e)
        {
            if(listViewCourses.SelectedItems.Count != 0 )
            {
                string connectionString = "Server=" + server + "; Port=3306; Database=" + database + "; Uid=" + uid + "; Pwd=" + password;

                MySqlConnection conn = new MySqlConnection(connectionString);

                conn.Open();

                string courseName = listViewCourses.SelectedItems[0].Text;
                string courseInstructor = listViewCourses.Columns[1].Text;

                string sql = "SELECT * FROM courses WHERE course_name= '" + courseName + "';";

                var cmd = new MySqlCommand(sql, conn);

                MySqlDataReader rdr = cmd.ExecuteReader();

                rdr.Read();
                if (!Convert.IsDBNull(rdr["password"]))
                {
                    JoinCoursePasswordScreen joinCoursePasswordScreen1 = new JoinCoursePasswordScreen(courseName, courseInstructor, rdr.GetString("password"), ref currentUser);

                    joinCoursePasswordScreen1.Show();
                }
                else
                {
                    try
                    {
                        conn.Close();
                        conn.Open();

                        //build sql command
                        string insertSql = "INSERT INTO course_account (account_id, course_name) ";
                        insertSql += "VALUES (" + currentUser.getID() + ", ";
                        insertSql += "'" + courseName + "');";

                        try
                        {
                            var insertCmd = new MySqlCommand(insertSql, conn);

                            insertCmd.ExecuteNonQuery();

                        }
                        catch(MySqlException ex)
                        {
                            MessageBox.Show("You are already a member of this course!");
                            return;
                        }
                        conn.Close();

                        Course newCourse = new Course(courseName, courseInstructor);

                        currentUser.AddToCourseList(newCourse);

                        MessageBox.Show("Welcome to " + courseName + "!");
                    }
                    catch
                    {
                        MessageBox.Show("Error adding course");
                    }

                }

                conn.Close();
            }
            else
            {
                MessageBox.Show("Please select a course");
            }

        }
    }
}
