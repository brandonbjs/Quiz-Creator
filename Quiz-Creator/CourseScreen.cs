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
using System.Runtime.Serialization.Formatters.Binary;

namespace Quiz_Creator
{
    public partial class CourseScreen : Form
    {
        private string courseName;

        public CourseScreen(string in_courseName)
        {
            InitializeComponent();

            courseName = in_courseName;

            labelCourse.Text = "Quizzes for " + in_courseName;
        }

        private void CourseScreen_Load(object sender, EventArgs e)
        {
            DisplayQuizzes();
        }

        private void DisplayQuizzes()
        {
            listBoxQuizzes.Items.Clear();

            foreach (string quizTitle in Database.GetCourseQuizTitles(courseName))
            {
                listBoxQuizzes.Items.Add(quizTitle);
            }
        }

        private void buttonTakeQuiz_Click(object sender, EventArgs e)
        {
            string quizName = listBoxQuizzes.SelectedItem.ToString();

            int quizID = Database.GetQuizID(quizName);

            TakerScreen takerScreen = new TakerScreen(Database.GetQuiz(quizID, quizName));

            takerScreen.Show();
        }

        private void listBoxQuizzes_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBoxQuizzes.SelectedItem != null)
            {
                buttonTakeQuiz.Enabled = true;
            }
            else
            {
                buttonTakeQuiz.Enabled = false;
            }
        }
    }
}
