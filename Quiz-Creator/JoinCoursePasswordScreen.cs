using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Quiz_Creator
{
    public partial class JoinCoursePasswordScreen : Form
    {
        private string courseName;
        private User currentUser;
        private Course selectedCourse;

        public JoinCoursePasswordScreen(ref Course in_Course, ref User in_User, string in_courseName)
        {
            InitializeComponent();

            selectedCourse = in_Course;

            currentUser = in_User;

            courseName = in_courseName;
        }

        private void JoinCoursePasswordScreen_Load(object sender, EventArgs e)
        {
            lblCourseName.Text = selectedCourse.GetName();
        }

        private void btnJoinCourse_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text == selectedCourse.GetPassword())
            {
                if (Database.AddStudentToCourse(courseName, currentUser.getID()))
                {
                    currentUser.AddToCourseList(selectedCourse);

                    MessageBox.Show("Welcome to " + courseName + "!");
                }
                else
                {
                    MessageBox.Show("You are already part of this course!");
                }
                Close();
            }
            else
            {
                MessageBox.Show("Incorrect password. Try again.");
            }
        }
    }
}
