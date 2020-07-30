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

        public Course(string in_courseName)
        {
            string server = "quizcreatordb.ctvd1ztjykvr.us-east-1.rds.amazonaws.com";
            string database = "QC_database";
            string uid = "admin";
            string dbpassword = "quizcreator";
            string connectionString = "Server=" + server + "; Port=3306; Database=" + database + "; Uid=" + uid + "; Pwd=" + dbpassword;

            string sql = "SELECT * FROM courses WHERE course_name= '" + in_courseName + "';";

            MySqlConnection conn = new MySqlConnection(connectionString);

            conn.Open();

            var cmd = new MySqlCommand(sql, conn);

            MySqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();

            courseName = rdr.GetString("course_name");

            instructorName = rdr.GetString("instructor_name");

            try
            {
                password = rdr.GetString("password");

                hasPassword = true;
            }
            catch
            {
                hasPassword = false;
            }
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

        public Boolean AddStudent(int in_userID)
        {
            string server = "quizcreatordb.ctvd1ztjykvr.us-east-1.rds.amazonaws.com";
            string database = "QC_database";
            string uid = "admin";
            string password = "quizcreator";
            string connectionString = "Server=" + server + "; Port=3306; Database=" + database + "; Uid=" + uid + "; Pwd=" + password;

            string sql = "SELECT * FROM courses WHERE course_name= '" + courseName + "';";

            MySqlConnection conn = new MySqlConnection(connectionString);

            conn.Open();

            string insertSql = "INSERT INTO course_account (account_id, course_name) ";
            insertSql += "VALUES (" + in_userID + ", ";
            insertSql += "'" + courseName + "');";

            try
            {
                var insertCmd = new MySqlCommand(insertSql, conn);

                insertCmd.ExecuteNonQuery();
            }
            catch
            {
                conn.Close();
                return false;
            }
            conn.Close();
            return true;
        }

        public string GetName()
        {
            return courseName;
        }

        public string GetPassword()
        {
            return password;
        }

        public void setName(string in_name)
        {
            courseName = in_name;
        }

        public string GetInstructorName()
        {
            return instructorName;
        }
    }
}
