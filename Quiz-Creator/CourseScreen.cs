using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Creator
{
    public partial class CourseScreen : Form
    {
        private User currentUser;

        private string courseName;
        public CourseScreen(ref User in_user, string in_courseName)
        {
            InitializeComponent();

            currentUser = in_user;

            courseName = in_courseName;
        }

        private void CourseScreen_Load(object sender, EventArgs e)
        {
            DisplayCourses();
        }
        private void DisplayCourses()
        {
            listViewCourseQuizzes.Items.Clear();

            List<Quiz> quizList = currentUser.GetCourseByName(courseName).GetQuizzes();

            foreach (Quiz quiz in quizList)
            {
                string[] row = { quiz.GetTitle(), quiz.GetModifiedDate() };
                ListViewItem listViewItem = new ListViewItem(row);
                listViewCourseQuizzes.Items.Add(listViewItem);
            }
        }
    }
}
