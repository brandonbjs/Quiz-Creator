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
        private User currentUser;

        private string courseName;

        Quiz test;
        public CourseScreen(ref User in_user, string in_courseName)
        {
            InitializeComponent();

            currentUser = in_user;

            courseName = in_courseName;

            test = DeserializeQuiz();
        }

        private void CourseScreen_Load(object sender, EventArgs e)
        {
            DisplayCourses();
        }

        public Quiz DeserializeQuiz()
        {
            string server = "quizcreatordb.ctvd1ztjykvr.us-east-1.rds.amazonaws.com";
            string database = "QC_database";
            string uid = "admin";
            string dbpassword = "quizcreator";
            string connectionString = "Server=" + server + "; Port=3306; Database=" + database + "; Uid=" + uid + "; Pwd=" + dbpassword;

            string sql = "SELECT * FROM quiz_obj WHERE quiz= '" + "test" + "';";

            MySqlConnection conn = new MySqlConnection(connectionString);

            conn.Open();

            var cmd = new MySqlCommand(sql, conn);

            MySqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();

            BinaryFormatter formatter = new BinaryFormatter();

            Quiz deserializedData = (Quiz)formatter.Deserialize(rdr.GetStream(0));

            conn.Close();

            return deserializedData;
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
