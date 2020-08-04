using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quiz_Creator;

namespace Quiz_Creator_Unit_Test
{
    [TestClass]
    public class QuizUnitTest
    {

        private const string defaultTitle = "Untitled Quiz";
        private const string defaultAuthor = "No Author";
        private const bool defaultProtection = false;
        private readonly List<Question> defaultQuestions = new List<Question>();


        private string title;
        private string author;
        private string date;
        private bool protection;
        private string password;

        private string prompt;

        private string fitbType;
        private string fitbAnswer;
        private Question fitbQuestion;

        private string mcType;
        private string mcAnswer;
        private string[] mcChoices;
        private MCQuestion mcQuestion;

        private List<Question> questions;

        private Quiz quiz;

        [TestInitialize]
        public void SetUp()
        {

            title = "Universe Quiz";
            author = "John Doe";
            date = DateTime.Now.ToString();
            protection = true;
            password = "1234";


            prompt = "What is The Answer to the Ultimate Question of Life, The Universe, and Everything?";

            fitbType = "FITB";
            fitbAnswer = "42";
            fitbQuestion = new Question("FITB", prompt, fitbAnswer);

            mcType = "MC";
            mcAnswer = "2";
            mcChoices = new string[] { "41", "42", "43", "44", "45" };
            mcQuestion = new MCQuestion(mcChoices, mcType, prompt, mcAnswer);

            questions = new List<Question>();

            questions.Add(fitbQuestion);
            questions.Add(mcQuestion);

            quiz = new Quiz();
        }

        #region Constructor Tests

        [TestMethod]
        public void DefaultConstructor_Test()
        {
            Assert.AreEqual(defaultTitle, quiz.GetTitle());
            Assert.AreEqual(defaultAuthor, quiz.GetAuthor());
            Assert.AreEqual(defaultProtection, quiz.IsProtected());
            Assert.AreEqual(defaultQuestions.Count, quiz.GetNumQuestions());
        }

        [TestMethod]
        public void TitleConstructor_Test()
        {
            quiz = new Quiz(title);

            Assert.AreEqual(title, quiz.GetTitle());
            Assert.AreEqual(defaultAuthor, quiz.GetAuthor());
            Assert.AreEqual(defaultProtection, quiz.IsProtected());
            Assert.AreEqual(defaultQuestions.Count, quiz.GetNumQuestions());
        }

        [TestMethod]
        public void AuthorConstructor_Test()
        {
            quiz = new Quiz(title, author);

            Assert.AreEqual(title, quiz.GetTitle());
            Assert.AreEqual(author, quiz.GetAuthor());
            Assert.AreEqual(defaultProtection, quiz.IsProtected());
            Assert.AreEqual(defaultQuestions.Count, quiz.GetNumQuestions());
        }

        [TestMethod]
        public void AllFieldsConstructor_Test()
        {
            quiz = new Quiz(title, author, date, protection, password, questions);

            Assert.AreEqual(title, quiz.GetTitle());
            Assert.AreEqual(author, quiz.GetAuthor());
            Assert.AreEqual(protection, quiz.IsProtected());
            Assert.AreEqual(questions.Count, quiz.GetNumQuestions());

            Assert.AreEqual(fitbQuestion, quiz.GetQuestion(0));
            Assert.AreEqual(mcQuestion, quiz.GetQuestion(1));
        }

        #endregion

        [TestMethod]
        public void SetTitle_Test()
        {
            quiz.SetTitle(title);
            Assert.AreEqual(title, quiz.GetTitle());
        }

        [TestMethod]
        public void AddFitbQuestion_Test()
        {
            quiz.AddQuestion(fitbQuestion);

            Assert.AreEqual(fitbQuestion, quiz.GetQuestion(0));
        }

        public void AddMcQuestion_Test()
        {
            quiz.AddQuestion(mcQuestion);
        }
    }
}
