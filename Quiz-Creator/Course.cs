using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Quiz_Creator
{
    public class Course
    {
        private string courseName;

        private string instructorName;

        private string password;

        private Boolean hasPassword; 

        List<Quiz> quizList;

        public Course()
        {
            courseName = null;

            instructorName = null;

            password = null;

            hasPassword = false;

            quizList = new List<Quiz>();
        }

        public Course(string in_name, string in_instructor)
        {
            courseName = in_name;

            instructorName = in_instructor;
        }

        public Boolean IsProtected()
        {
            return hasPassword;
        }
        public List<Quiz> GetQuizzes()
        {
            return quizList;
        }

        public string GetName()
        {
            return courseName;
        }

        public string GetPassword()
        {
            return password;
        }

        public void SetName(string in_name)
        {
            courseName = in_name;
        }

        public void SetInstructorName(string in_instructorName)
        {
            instructorName = in_instructorName;
        }

        public string GetInstructorName()
        {
            return instructorName;
        }

        public void SetPassword(string in_pass)
        {
            password = in_pass;

            hasPassword = true;
        }
    }
}
