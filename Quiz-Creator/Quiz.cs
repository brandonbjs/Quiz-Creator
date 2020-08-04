using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using MySql.Data.MySqlClient;


namespace Quiz_Creator
{
    [Serializable]
    public class Quiz
    {
        #region Fields

        private const string defaultTitle = "Untitled Quiz";
        private const string defaultAuthor = "No Author";
        private const bool defaultProtection = false;
        private const string defaultPassword = "";
        private readonly List<Question> defaultQuestions = new List<Question>();

        private string title;
        private string author;
        private string dateModified;
        private bool protectedQuiz;
        private string password;

        private List<Question> questions;

        #endregion

        #region Constructors

        public Quiz()
        {
            setDefaults();
        }

        public Quiz(string in_title)
        {
            setDefaults();
            title = in_title;
        }

        public Quiz(string in_title, string in_author)
        {
            setDefaults();
            title = in_title;
            author = in_author;
        }

        public Quiz(string in_title, string in_author, string in_dateModified, bool in_protectedQuiz, string in_password, List<Question> in_questions)
        {
            title = in_title;
            author = in_author;
            dateModified = in_dateModified;
            protectedQuiz = in_protectedQuiz;
            password = in_password;
            questions = in_questions;
        }

        private void setDefaults()
        {
            title = defaultTitle;
            author = defaultAuthor;
            dateModified = DateTime.Now.ToString();
            protectedQuiz = defaultProtection;
            password = defaultPassword;
            questions = defaultQuestions;
        }

        #endregion 

        #region Questions

        public Question GetQuestion(int index)
        {
            if (index < questions.Count)
            {
                return questions[index];
            }
            return null;
        }

        public void SetQuestion(int index, Question in_question)
        {
            if (index < questions.Count)
            {
                questions[index] = in_question;
            }
        }

        public void AddQuestion(Question in_question)
        {
            questions.Add(in_question);
        }

        public void InsertQuestion(int index, Question in_question)
        {
            if (index <= questions.Count)
            {
                questions.Insert(index, in_question);
            }
        }

        public void RemoveQuestion(int index)
        {
            questions.RemoveAt(index);
        }

        public int GetNumQuestions()
        {
            return questions.Count;
        }

        /// <summary>
        /// searchForRelatedQuestion is intended to iterate through our 
        /// available list of questions and search for a user entered keyword
        /// in each question prompt. Storing question indexes as the keyword
        /// is found.
        /// </summary>
        /// <param name="keyword"> 
        /// string variable that holds the user entered keyword we are searching 
        /// for in our question prompts.
        /// </param>
        /// <returns>
        /// A list of integers, in which each integer represents the index of
        /// a question that contained the user entered keyword. Returns null 
        /// if the keyword is not contained in any of the available question
        /// prompts.
        /// </returns>
        public List<int> SearchForRelatedQuestion(string keyword)
        {
            List<int> relatedQuestionsFound = new List<int>();
            int indexTracker = 0;
            foreach (var q in questions)
            {
                if (q.GetPrompt().Contains(keyword))
                {
                    relatedQuestionsFound.Add(indexTracker);
                    return relatedQuestionsFound;
                }
                indexTracker++;
            }
            return null;
        }

        #endregion

        #region Responses

        public string GetResponse(int index)
        {
            if (index < questions.Count)
            {
                return questions[index].GetResponse();
            }
            return null;
        }

        public void SetResponse(int index, string in_response)
        {
            if (index < questions.Count)
            {
                questions[index].SetResponse(in_response);
            }
        }

        #endregion

        #region Protection

        public bool IsProtected()
        {
            return protectedQuiz;
        }

        public void SetProtection(bool newProtectedStatus)
        {
            protectedQuiz = newProtectedStatus;
        }
        public void ChangePassword(string newPassword)
        {
            password = newPassword;
        }


        public bool SetProtection(bool in_protection, string in_pass)
        {
            // true with new password to add protection, false with old password to remove protection
            // returns success
            if (in_protection)
            {
                if (!protectedQuiz)
                {
                    protectedQuiz = true;
                    password = in_pass;
                    return true;
                }
            }
            else
            {
                if (protectedQuiz)
                {
                    if (password == in_pass)
                    {
                        protectedQuiz = false;
                        password = "";
                        return true;
                    }
                }
            }
            return false;
        }


        public bool VerifyPassword(string in_pass)
        {
            return in_pass == password;
        }

        #endregion

        #region Author and Title

        public string GetAuthor()
        {
            return author;
        }

        public void SetAuthor(string in_author)
        {
            author = in_author;
        }

        public void SetTitle(string in_title)
        {
            title = in_title;
        }

        public string GetTitle()
        {
            return title;
        }

        #endregion

        #region Date

        public string GetModifiedDate()
        {
            return dateModified;
        }

        public void SetModifiedDate(DateTime in_date)
        {
            dateModified = in_date.ToString();
        }

        public void SetModifiedNow()
        {
            dateModified = DateTime.Now.ToString();
        }

        #endregion

        #region Saving

        public void SerializeQuiz()
        {
            Stream stream = File.Open("dbquiz.qz", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, this);
            stream.Close();
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

            title = deserializedData.title;
            author = deserializedData.author;
            dateModified = deserializedData.dateModified;
            protectedQuiz = deserializedData.protectedQuiz;
            password = deserializedData.password;
            questions = deserializedData.questions;

            return deserializedData;
        }

        public void AddDataFromFile(string filename, string quizDate)
        {
            XmlDocument localDoc = new XmlDocument();

            localDoc.Load(filename);

            XmlNodeList quizNodes = localDoc.GetElementsByTagName("Quiz");

            XmlNode selectedQuizNode = null;

            foreach (XmlNode node in quizNodes)
            {
                if (node.Attributes[1].InnerText == quizDate)
                {
                    selectedQuizNode = node;
                }
            }
            title = selectedQuizNode.Attributes[0].InnerText;

            dateModified = selectedQuizNode.Attributes[1].InnerText;

            XmlNodeList questionNodes = selectedQuizNode.ChildNodes;

            foreach (XmlNode questionNode in questionNodes)
            {
                string newQuestionType = questionNode.Attributes[0].InnerText;

                string newQuestionPrompt = questionNode.ChildNodes[0].InnerText;

                string newQuestionAnswer = questionNode.ChildNodes[1].InnerText;

                if (newQuestionType == "MC")
                {
                    XmlNodeList choicesNode = questionNode.ChildNodes[2].ChildNodes;

                    string[] questionChoices = new string[choicesNode.Count];

                    int numChoices = choicesNode.Count;

                    for (int index = 0; index < numChoices; index++)
                    {
                        questionChoices[index] = choicesNode[index].InnerText;
                    }
                    AddQuestion(new MCQuestion(questionChoices, newQuestionType, newQuestionPrompt, newQuestionAnswer));
                }
                else
                {
                    AddQuestion(new Question(newQuestionType, newQuestionPrompt, newQuestionAnswer));
                }
            }
        }

        #endregion
    }
}
