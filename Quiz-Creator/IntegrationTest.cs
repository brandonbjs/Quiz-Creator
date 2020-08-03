using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Quiz_Creator
{
    [TestFixture]
    class IntegrationTest
    {
        [TestCase]
        public void test()
        {
            Course actualCourse =  Database.LoadCourse("Software Engineering");

            Assert.AreEqual("Ana Paula Chaves Steinmacher", actualCourse.GetInstructorName());
        }
        [TestCase]
        public void test2()
        {
            string connectionString = "Server=quizcreatordb.ctvd1ztjykvr.us-east-1.rds.amazonaws.com; " +
                                      "Port=3306; Database=QC_database; Uid=admin; Pwd=quizcreator;";

            string quizName = "Quiz 1.2 - Intro to Software Eng.";

            int quizID = Database.GetQuizID(quizName);

            string sql = "SELECT * FROM questions WHERE quiz_id= " + quizID + ";";

            MySqlConnection conn = new MySqlConnection(connectionString);

            conn.Open();

            MySqlDataReader rdr = new MySqlCommand(sql, conn).ExecuteReader();

            Quiz expectedQuiz = new Quiz(quizName);

            while (rdr.Read())
            {
                if (rdr.GetString("type") == "FITB")
                {
                    expectedQuiz.AddQuestion(new Question(rdr.GetString("type"),
                        rdr.GetString("prompt"), rdr.GetString("answer")));
                }
                else
                {
                    string[] choices = rdr.GetString("choices").Split(',');

                    expectedQuiz.AddQuestion(new MCQuestion(choices, rdr.GetString("type"),
                        rdr.GetString("prompt"), rdr.GetString("answer")));
                }
            }
            conn.Close();

            Quiz actualQuiz = Database.GetQuiz(quizID, quizName);

            for(int questionIndex = 0; questionIndex < expectedQuiz.GetNumQuestions(); questionIndex++)
            {
                string actual = actualQuiz.GetQuestion(questionIndex).GetPrompt();
                string expected = expectedQuiz.GetQuestion(questionIndex).GetPrompt();

                Assert.AreEqual(expected, actual);

                actual = actualQuiz.GetQuestion(questionIndex).GetAnswer();
                expected = expectedQuiz.GetQuestion(questionIndex).GetAnswer();

                Assert.AreEqual(expected, actual);
            }

        }
    }
}
