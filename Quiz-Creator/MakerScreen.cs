using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;


namespace Quiz_Creator
{
    public partial class MakerScreen : Form
    {
        #region Fields

        private Boolean isEdit = false;

        string titleSuggest = "Untitled Quiz";
        string questionSuggest = "Enter the quesition here";
        string answerSuggest = "";
        string newQuestionLabel = "New Question";

        int currentQuestionIndex;

        Quiz currentlyMakingQuiz;

        #endregion

        #region Constructors

        public MakerScreen()
        {
            InitializeComponent();

            currentlyMakingQuiz = new Quiz(titleSuggest);

            textboxTitle.Text = titleSuggest;

            addBlankQuestion(0);
        }

        public MakerScreen(string quizDate)
        {
            // Call this contructor with a filename to open a quiz for editing
            // Note: the main functionality here should be moved to the Quiz Class for reueseability
            InitializeComponent();

            isEdit = true;

            currentlyMakingQuiz = new Quiz();

            currentlyMakingQuiz.AddDataFromFile("LocalQuizzes.xml", quizDate);

            textboxTitle.Text = currentlyMakingQuiz.GetTitle();

            for (int i = 0; i < currentlyMakingQuiz.GetNumQuestions(); i++)
            {
                listboxQuestions.Items.Add(currentlyMakingQuiz.GetQuestion(i).GetPrompt());
            }
            if (currentlyMakingQuiz.GetNumQuestions() <= 0)
            {
                addBlankQuestion(0);
            }
            else
            {
                listboxQuestions.SelectedIndex = 0;
            }
        }

        #endregion

        #region Functional Methods

        private void addBlankQuestion(int index)
        {
            currentlyMakingQuiz.InsertQuestion(index, new Question("FITB", questionSuggest, answerSuggest));
            listboxQuestions.Items.Insert(index, newQuestionLabel);

            currentQuestionIndex = index;
            textboxPromptEdit.Text = questionSuggest;
            textboxAnswerEdit.Text = answerSuggest;
            listboxQuestions.SelectedIndex = currentQuestionIndex;
        }

        #endregion

        #region Windows Forum Event Methods

        #region Title and Saving

        private void buttonSaveQuiz_Click(object sender, EventArgs e)
        {
            // Save the quiz.  To an xml file
            //add a file location for it to save to for now

            // In the future, add a blank field checker that checks the title, author, other fields, and questions and answers for blank or default values, 
            // and asks the user if they want to fill them in before saving
            if (isEdit)
            {
                XDocument xmlDoc = XDocument.Load("LocalQuizzes.xml");

                xmlDoc.Root.Elements().Where(x => x.Attribute("date").Value == currentlyMakingQuiz.GetModifiedDate()).Remove();

                currentlyMakingQuiz.SetModifiedNow();

                xmlDoc.Save("LocalQuizzes.xml");
            }

            XDocument xmlDocument = XDocument.Load("LocalQuizzes.xml");

            xmlDocument.Element("Quizzes").Add(
                new XElement("Quiz",
                new XAttribute("name", currentlyMakingQuiz.GetTitle()),
                new XAttribute("date", currentlyMakingQuiz.GetModifiedDate())
                ));

            for (int index = 0; index < currentlyMakingQuiz.GetNumQuestions(); index++)
            {
                xmlDocument.Element("Quizzes").Elements("Quiz")
                    .First(c => (string)c.Attribute("date") == currentlyMakingQuiz.GetModifiedDate()).Add
                    (
                        new XElement("Question", new XAttribute("type", currentlyMakingQuiz.GetQuestion(index).GetQuestionType()),
                            new XElement("Prompt", currentlyMakingQuiz.GetQuestion(index).GetPrompt()),
                            new XElement("Answer", currentlyMakingQuiz.GetQuestion(index).GetAnswer())
                    ));
            }
            xmlDocument.Save("LocalQuizzes.xml");

            MessageBox.Show("Quiz saved successfully!");

            Close();
        }

        private void textboxTitle_TextChanged(object sender, EventArgs e)
        {
            // Whenever Title is changed, save the new title
            currentlyMakingQuiz.SetTitle(textboxTitle.Text);
        }

        #endregion

        #region Question Management

        #region Add and Remove Questions

        private void buttonAddQuestion_Click(object sender, EventArgs e)
        {
            addBlankQuestion(currentQuestionIndex + 1);
        }

        private void buttonRemoveQuestion_Click(object sender, EventArgs e)
        {
            // Remove a Question
            listboxQuestions.Items.RemoveAt(currentQuestionIndex);
            currentlyMakingQuiz.RemoveQuestion(currentQuestionIndex);
            if (currentQuestionIndex > 0)
            {
                currentQuestionIndex--;
                listboxQuestions.SelectedIndex = currentQuestionIndex;
            }
            else if (currentlyMakingQuiz.GetNumQuestions() <= 0)
            {
                addBlankQuestion(0);
            }
            else
            {
                listboxQuestions.SelectedIndex = 0;
            }
        }

        #endregion

        private void listboxQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            // A different list item has been selected
            if (listboxQuestions.SelectedIndex >= 0)
            {
                currentQuestionIndex = listboxQuestions.SelectedIndex;
                Question thisQ = currentlyMakingQuiz.GetQuestion(currentQuestionIndex);
                textboxPromptEdit.Text = thisQ.GetPrompt();
                textboxAnswerEdit.Text = thisQ.GetAnswer();
            }
            else if (currentlyMakingQuiz.GetNumQuestions() <= 0)
            {
                addBlankQuestion(0);
            }
        }

        #endregion

        #region Prompt

        private void textboxPromptEdit_TextChanged(object sender, EventArgs e)
        {
            // whenever the text in the text box is changed, save it
            currentlyMakingQuiz.SetQuestion(currentQuestionIndex, new Question("FITB", textboxPromptEdit.Text, textboxAnswerEdit.Text));

            if (textboxPromptEdit.Text != questionSuggest)
            {
                listboxQuestions.Items[currentQuestionIndex] = textboxPromptEdit.Text;
            }
        }

        #endregion

        #region Answers

        #region Question Types and Tabs
        private void tabControlQuestionType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region Fill in the Blank

        private void textboxAnswerEdit_TextChanged(object sender, EventArgs e)
        {
            // Whenever the answer is changed, save the new answer text
            currentlyMakingQuiz.SetQuestion(currentQuestionIndex, new Question("FITB", textboxPromptEdit.Text, textboxAnswerEdit.Text));
        }

        private void textboxAnswerEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                addBlankQuestion(currentQuestionIndex + 1);
                textboxPromptEdit.SelectAll();
                textboxPromptEdit.Focus();
            }
        }

        #endregion

        #region Multiple Choice

        #region Multiple Choice Radio Buttons

        private void radioButtonMC1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonMC2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonMC3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonMC4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonMC5_CheckedChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region Multiple Choice TextBoxes

        private void textBoxMC1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMC2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMC3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMC4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMC5_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #endregion

        #endregion

        #endregion
    }
}
