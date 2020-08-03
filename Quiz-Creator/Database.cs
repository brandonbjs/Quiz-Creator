using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Quiz_Creator
{
    static class Database
    {
        private static string connectionString = "Server=quizcreatordb.ctvd1ztjykvr.us-east-1.rds.amazonaws.com; " +
                                    "Port=3306; Database=QC_database; Uid=admin; Pwd=quizcreator;";

        public static Boolean AddAccount(string email, string password, string org, string accType)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connectionString);

                conn.Open();

                string sql = "INSERT INTO accounts (acc_email, acc_password, acc_org, acc_role) ";
                sql += "VALUES ('" + email + "', ";
                sql += "'" + password + "', ";
                sql += "'" + org + "', ";
                sql += "'" + accType + "');";

                var cmd = new MySqlCommand(sql, conn);

                cmd.ExecuteNonQuery();

                conn.Close();

                return true;
            }
            catch
            {
                MessageBox.Show("Error connecting to database");

                return false;
            }
        }

        public static List<string[]> GetCourseInfo()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connectionString);

                conn.Open();

                string sql = "SELECT * FROM courses;";

                var cmd = new MySqlCommand(sql, conn);

                MySqlDataReader rdr = cmd.ExecuteReader();

                List<string[]> outputList = new List<string[]>();

                while (rdr.Read())
                {
                    string passwordProtected = "no";

                    if (!Convert.IsDBNull(rdr["password"]))
                    {
                        passwordProtected = "yes";
                    }
                    string[] item = { rdr.GetString("course_name"), rdr.GetString("instructor_name"), passwordProtected };

                    outputList.Add(item);
                }
                conn.Close();

                return outputList;
            }
            catch
            {
                MessageBox.Show("Error connecting to database");

                return null;
            }
        }

        public static Course LoadCourse(string in_courseName)
        {
            try
            {
                string sql = "SELECT * FROM courses WHERE course_name= '" + in_courseName + "';";

                MySqlConnection conn = new MySqlConnection(connectionString);

                conn.Open();

                var cmd = new MySqlCommand(sql, conn);

                MySqlDataReader rdr = cmd.ExecuteReader();

                rdr.Read();

                Course course = new Course();

                course.SetName(rdr.GetString("course_name"));

                course.SetInstructorName(rdr.GetString("instructor_name"));

                string password = rdr.GetValue(3).ToString();

                if (password != "")
                {
                    course.SetPassword(password);
                }
                conn.Close();

                return course;
            }
            catch
            {
                MessageBox.Show("error");

                return null;
            }
        }

        public static Boolean AddStudentToCourse(string courseName, int studentID)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connectionString);

                conn.Open();

                string insertSql = "INSERT INTO course_account (account_id, course_name) ";
                insertSql += "VALUES (" + studentID + ", ";
                insertSql += "'" + courseName + "');";

                new MySqlCommand(insertSql, conn).ExecuteNonQuery();

                conn.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Boolean AccountExists(string email, string password)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM accounts WHERE acc_email= '" + email + "' AND acc_password='" + password + "';";

            MySqlDataReader rdr = new MySqlCommand(sql, conn).ExecuteReader();

            if (!rdr.Read())
            {
                conn.Close();

                return false;
            }
            conn.Close();

            return true;
        }

        public static Boolean AddUserCourses()
        {
            try
            {
                User user = User.getInstance();

                MySqlConnection conn = new MySqlConnection(connectionString);

                conn.Open();

                string sqlCourseSelect = "SELECT * FROM course_account WHERE account_id= " + user.getID() + ";";

                var cmdGetCourses = new MySqlCommand(sqlCourseSelect, conn);

                MySqlDataReader rdrGetCourses = cmdGetCourses.ExecuteReader();

                List<string> extractedCourses = new List<string>(0);

                while (rdrGetCourses.Read())
                {
                    extractedCourses.Add(rdrGetCourses.GetString("course_name"));
                }
                conn.Close();

                conn.Open();

                string sqlInstructorSelect = "SELECT * FROM courses WHERE course_name IN ('";

                for (int index = 0; index < extractedCourses.Count; index++)
                {
                    if (index == extractedCourses.Count - 1)
                    {
                        sqlInstructorSelect += extractedCourses[index] + "');";
                    }
                    else
                    {
                        sqlInstructorSelect += extractedCourses[index] + "', '";
                    }
                }
                if (extractedCourses.Count > 0)
                {
                    var cmdGetInstructors = new MySqlCommand(sqlInstructorSelect, conn);

                    MySqlDataReader rdrGetInstructors = cmdGetInstructors.ExecuteReader();

                    for (int i = 0; rdrGetInstructors.Read(); i++)
                    {
                        Course newCourse = new Course(extractedCourses[i], rdrGetInstructors.GetString("instructor_name"));

                        user.AddToCourseList(newCourse);
                    }
                }
                conn.Close();

                return true;
            }
            catch
            {
                return false;
            }

        }

        public static Boolean AddAccountToUserObject(string email, string password)
        {
            try
            {
                User user = User.getInstance();

                MySqlConnection conn = new MySqlConnection(connectionString);

                conn.Open();

                string sql = "SELECT * FROM accounts WHERE acc_email= '" + email + "' AND acc_password='" + password + "';";

                MySqlDataReader rdr = new MySqlCommand(sql, conn).ExecuteReader();

                rdr.Read();

                user.SetEmail(rdr.GetString("acc_email"));

                user.setLoginStatus(true);

                user.SetID(rdr.GetInt32(0));

                conn.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<string> GetCourseQuizTitles(string courseName)
        {
            string sql = "SELECT * FROM course_quiz WHERE course_name= '" + courseName + "';";

            MySqlConnection conn = new MySqlConnection(connectionString);

            conn.Open();

            MySqlDataReader rdr = new MySqlCommand(sql, conn).ExecuteReader();

            List<string> quizzes = new List<string>();

            while (rdr.Read())
            {
                quizzes.Add(rdr.GetString("quiz_name"));
            }
            conn.Close();

            return quizzes;
        }

        public static int GetQuizID(string quizName)
        {
            string sql = "SELECT * FROM course_quiz WHERE quiz_name= '" + quizName + "';";

            MySqlConnection conn = new MySqlConnection(connectionString);

            conn.Open();

            MySqlDataReader rdr = new MySqlCommand(sql, conn).ExecuteReader();

            rdr.Read();

            int id = (int)rdr.GetUInt32(2);

            conn.Close();

            return id;
        }

        public static Quiz GetQuiz(int quizID, string quizName)
        {
            string sql = "SELECT * FROM questions WHERE quiz_id= " + quizID + ";";

            MySqlConnection conn = new MySqlConnection(connectionString);

            conn.Open();

            MySqlDataReader rdr = new MySqlCommand(sql, conn).ExecuteReader();

            Quiz quiz = new Quiz(quizName);

            while(rdr.Read())
            {
                if(rdr.GetString("type") == "FITB")
                {
                    quiz.AddQuestion(new Question(rdr.GetString("type"),
                        rdr.GetString("prompt"), rdr.GetString("answer")));
                }
                else
                {
                    string[] choices = rdr.GetString("choices").Split(',');
                    quiz.AddQuestion(new MCQuestion(choices, rdr.GetString("type"),
                        rdr.GetString("prompt"), rdr.GetString("answer")));
                }
            }
            conn.Close();
            return quiz;
        }
    }
}


