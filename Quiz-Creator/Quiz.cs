using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Creator
{
    class Quiz
    {
        #region Fields

        private string title;
        private string author;
        private DateTime dateModified;
        private bool protectedQuiz;
        private string password;

        private List<Question> questions;

        #endregion

        #region Constructors

        public Quiz()
        {
            title = "Untitled Quiz";
            author = "No Author";
            dateModified = DateTime.Now;
            protectedQuiz = false;
            password = "";
            questions = new List<Question>();
        }

        public Quiz(string in_title) {
            title = in_title;
            dateModified = DateTime.Now;
            questions = new List<Question>();
            protectedQuiz = false;
            password = "";
            questions = new List<Question>();
        }

        #endregion 

        #region Questions

        public Question GetQuestion(int index)
        {
            if(index < questions.Count)
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

        public qType GetQuestionType(int index)
        {
            if(index < questions.Count)
            {
                return questions[index].QuestionType;
            }
            return qType.Fill_In;
        }

        public int GetNumQuestions()
        {
            return questions.Count;
        }

        /// <summary>
        /// searchForRelatedQuestion is intended to iterate through our 
        /// available list of questions and search for a user entered keyword
        /// in each question prompt.If the keyword is found, the method 
        /// returns the question index, otherwise it returns -1. This first method
        /// implementation is only able to find the FIRST question in the list with
        /// the corresponding keyword.
        /// </summary>
        /// <param name="keyword"> string variable that holds the user entered
        /// keyword we are searching for in our question prompts.</param>
        /// <returns>An integer variable representing the index of the question
        /// our keyword was found in. If no such keyword is found in our questions,
        /// return -1.</returns>
        public int SearchForRelatedQuestion(string keyword)
        {
            int counter = 0;
            foreach (var q in questions)
            {
                if ( q.Prompt.Contains(keyword) )
                {
                    return counter;
                }
                counter++;
            }
            return -1;
        }

        #endregion

        #region Responses

        public string GetResponse(int index)
        {
            if (index < questions.Count)
            {
                return questions[index].Response;
            }
            return null;
        }

        public void SetResponse(int index, string in_response)
        {
            if (index < questions.Count)
            {
                questions[index].Response = in_response;
            }
        }

        #endregion

        #region Protection

        public bool IsProtected()
        {
            return protectedQuiz;
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

        public DateTime GetModifiedDate()
        {
            return dateModified;
        }

        public void SetModifiedDate(DateTime in_date)
        {
            dateModified = in_date;
        }

        public void SetModifiedNow()
        {
            dateModified = DateTime.Now;
        }

        #endregion
    }
}
