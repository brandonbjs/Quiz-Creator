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
    public partial class JoinCourseScreen : Form
    {
        private User currentUser;

        public JoinCourseScreen()
        {
            InitializeComponent();

            currentUser = User.getInstance();
        }

        private void JoinCourseScreen_Load(object sender, EventArgs e)
        {
            foreach(string[] row in Database.GetCourseInfo())
            {
                listViewCourses.Items.Add(new ListViewItem(row));
            }
        }

        private void buttonJoinCourse_Click(object sender, EventArgs e)
        {
            if(listViewCourses.SelectedItems.Count != 0 )
            {
                string courseName = listViewCourses.SelectedItems[0].Text;

                Course selectedCourse = Database.LoadCourse(courseName);

                if (selectedCourse.IsProtected())
                {
                    JoinCoursePasswordScreen joinCoursePasswordScreen1 = new JoinCoursePasswordScreen(ref selectedCourse, ref currentUser, courseName);

                    joinCoursePasswordScreen1.Show();
                }
                else
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
                }
            }
            else
            {
                MessageBox.Show("Please select a course");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
