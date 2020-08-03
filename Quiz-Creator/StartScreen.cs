using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using System.Runtime.CompilerServices;

namespace Quiz_Creator
{
    public partial class StartScreen : Form
    {
        public User currentUser;

        public StartScreen()
        {
            InitializeComponent();

            currentUser = User.getInstance();
        }

        private void buttonMakeLocal_Click(object sender, EventArgs e)
        {
            // Launch MakerScreen to make local
            var MakerScreen1 = new MakerScreen();

            MakerScreen1.Show();
        }

        private void buttonTakeLocal_Click(object sender, EventArgs e)
        {
            if (listViewLocalQuizzes.SelectedItems.Count != 0)
            {
                new TakerScreen(GetSelectedQuizDate(), true).Show();
            }
            else
            {
                MessageBox.Show("Select a quiz to take!");
            }

        }

        private void buttonEditLocal_Click(object sender, EventArgs e)
        {
            if(listViewLocalQuizzes.SelectedItems.Count != 0)
            {
                var MakerScreen1 = new MakerScreen(GetSelectedQuizDate());

                MakerScreen1.Show();
            }
            else
            {
                MessageBox.Show("Select a quiz to edit!");
            }
        }

        private string GetSelectedQuizDate()
        {
            XmlDocument localDoc = new XmlDocument();

            localDoc.Load("LocalQuizzes.xml");

            XmlNodeList quizNodes = localDoc.GetElementsByTagName("Quiz");

            int selectedQuizListIndex = listViewLocalQuizzes.SelectedIndices[0];

            return quizNodes[selectedQuizListIndex].Attributes[1].InnerText;
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {
            LoadLocalQuizzes();
        }

        private void LoadLocalQuizzes()
        {
            listViewLocalQuizzes.Items.Clear();

            XmlDocument localDoc = new XmlDocument();

            localDoc.Load("LocalQuizzes.xml");

            XmlNodeList quizNodes = localDoc.GetElementsByTagName("Quiz");

            foreach (XmlNode node in quizNodes)
            {
                string quizName = node.Attributes[0].InnerText;

                string quizDate = node.Attributes[1].InnerText;

                AddListItem(quizName, quizDate, listViewLocalQuizzes);
            }
        }

        private void AddListItem(string in_name, string in_date, ListView in_ListView)
        {
            ListViewItem newItem = new ListViewItem(in_name);

            newItem.SubItems.Add(in_date);

            in_ListView.Items.Add(newItem);
        }

        private void StartScreen_Activated(object sender, EventArgs e)
        {
            LoadLocalQuizzes();

            labelHideCourses.Visible = true;
            buttonCourseSelect.Enabled = false;
            buttonJoinCourse.Enabled = false;

            if (currentUser.getLoginStatus())
            {
                DisplayCourses();

                buttonLoginOrSignout.Text = "Sign Out";

                labelHideCourses.Visible = false;

                buttonCourseSelect.Enabled = true;
                buttonJoinCourse.Enabled = true;
            }
        }

        private void buttonDeleteLocal_Click(object sender, EventArgs e)
        {
            if (listViewLocalQuizzes.SelectedItems.Count != 0)
            {
                string selectedQuizDate = GetSelectedQuizDate();

                if (MessageBox.Show("Are you sure you want to delete this quiz?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    XDocument xmlDoc = XDocument.Load("LocalQuizzes.xml");

                    xmlDoc.Root.Elements().Where(x => x.Attribute("date").Value == selectedQuizDate).Remove();

                    xmlDoc.Save("LocalQuizzes.xml");

                    LoadLocalQuizzes();
                }
            }
            else
            {
                MessageBox.Show("Select a quiz to delete!");
            }
        }

        private void buttonLoginOrSignout_Click(object sender, EventArgs e)
        {
            if(currentUser.getLoginStatus())
            {
                string email = currentUser.GetEmail();

                User.resetInstance();

                currentUser = User.getInstance();

                buttonLoginOrSignout.Text = "Login";

                listViewCourses.Items.Clear();

                MessageBox.Show("Signed out of " + email);
            }
            else
            {
                LoginScreen loginScreen1 = new LoginScreen();

                loginScreen1.Show(this);
            }
        }

        private void buttonJoinCourse_Click(object sender, EventArgs e)
        {
            JoinCourseScreen joinCourseScreen = new JoinCourseScreen();

            joinCourseScreen.Show();
        }

        private void DisplayCourses()
        {
            listViewCourses.Items.Clear();

            List<Course> courseList = currentUser.GetCourseList();

            foreach(Course course in courseList)
            {
                string[] row = { course.GetName(), course.GetInstructorName() };

                ListViewItem listViewItem = new ListViewItem(row);

                listViewCourses.Items.Add(listViewItem);
            }
        }

        private void buttonCourseSelect_Click(object sender, EventArgs e)
        {
            if(listViewCourses.SelectedItems.Count != 0)
            {
                CourseScreen courseScreen = new CourseScreen(listViewCourses.SelectedItems[0].Text);

                courseScreen.Show();
            }
            else
            {
                MessageBox.Show("Please select a course!");
            }
        }

        private void listViewCourses_Click(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < listViewCourses.Items.Count; i++)
            {
                var rectangle = listViewCourses.GetItemRect(i);
                if (rectangle.Contains(e.Location))
                {
                    //var CourseQuizzesListScreen1 = new CourseQuizzesList();
                    //CourseQuizzesListScreen1.Show();
                }
            }
        }
    }
}