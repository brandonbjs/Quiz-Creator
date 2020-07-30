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

            currentUser = new User();
        }

        public StartScreen(User in_User)
        {
        }

        private void buttonMakeLocal_Click(object sender, EventArgs e)
        {
            // Launch MakerScreen to make local
            var MakerScreen1 = new MakerScreen();

            MakerScreen1.Show();
        }

        private void buttonTakeLocal_Click(object sender, EventArgs e)
        {
            // Launch TakerScreen and open quiz
            var TakerScreen1 = new TakerScreen(GetSelectedQuizDate(), true);

            TakerScreen1.Show();
        }

        private void buttonEditLocal_Click(object sender, EventArgs e)
        {
            var MakerScreen1 = new MakerScreen(GetSelectedQuizDate());

            MakerScreen1.Show();
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

            buttonJoinCourse.Enabled = false;
            buttonCourseSelect.Enabled = false;
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

        //Adds name and date to specified list box
        private void AddListItem(string in_name, string in_date, ListView in_ListView)
        {
            ListViewItem newItem = new ListViewItem(in_name);

            newItem.SubItems.Add(in_date);

            in_ListView.Items.Add(newItem);
        }

        private void listViewLocalQuizzes_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listViewLocalQuizzes.SelectedItems.Count > 0)
            {
                buttonEditLocal.Enabled = true;

                buttonTakeLocal.Enabled = true;

                buttonDeleteLocal.Enabled = true;
            }
            else
            {
                buttonEditLocal.Enabled = false;

                buttonTakeLocal.Enabled = false;

                buttonDeleteLocal.Enabled = false;
            }
        }

        private void StartScreen_Activated(object sender, EventArgs e)
        {
            LoadLocalQuizzes();

            buttonEditLocal.Enabled = false;

            buttonDeleteLocal.Enabled = false;

            buttonTakeLocal.Enabled = false;

            if(currentUser.getLoginStatus())
            {
                DisplayCourses();

                buttonJoinCourse.Enabled = true;

                buttonCourseSelect.Enabled = true;
            }
        }

        private void buttonDeleteLocal_Click(object sender, EventArgs e)
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

        private void buttonLoginOrSignout_Click(object sender, EventArgs e)
        {
            if(currentUser.getLoginStatus())
            {
                MessageBox.Show("You are already logged in!");

                return;
            }

            LoginScreen loginScreen1 = new LoginScreen(ref currentUser);

            loginScreen1.Show(this);
        }

        private void CourseSelectButton_Click(object sender, EventArgs e)
        {
            // Launch MakerScreen to make local
            var CourseSelectScreen1 = new CourseSelectScreen();

            CourseSelectScreen1.Show();
        }

        private void buttonJoinCourse_Click(object sender, EventArgs e)
        {
            JoinCourseScreen joinCourseScreen = new JoinCourseScreen(ref currentUser);

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
            CourseScreen courseScreen = new CourseScreen(ref currentUser, listViewCourses.SelectedItems[0].Text);

            courseScreen.Show();
        }

        private void listViewCourses_Click(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < listViewCourses.Items.Count; i++)
            {
                var rectangle = listViewCourses.GetItemRect(i);
                if (rectangle.Contains(e.Location))
                {
                    var CourseQuizzesListScreen1 = new CourseQuizzesList();
                    CourseQuizzesListScreen1.Show();
                }
            }
        }

    }
}