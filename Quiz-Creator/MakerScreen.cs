using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Creator
{
    public partial class MakerScreen : Form
    {
        string titleSuggest;
        string questionSuggest;
        string answerSuggest;
        string newQuestionLabel;
        int currentQuestionIndex;

        Quiz currentlyMakingQuiz;

        public MakerScreen()
        {
            InitializeComponent();


            titleSuggest = "Untitled Quiz";
            questionSuggest = "Enter the quesition here";
            newQuestionLabel = "New Question";
            answerSuggest = "";

            currentlyMakingQuiz = new Quiz(titleSuggest);
            textboxTitle.Text = titleSuggest;

            addBlankQuestion(0);
        }

        public MakerScreen(string filename)
        {
            // Call this contructor with a filename to open a quiz for editing
            InitializeComponent();

            titleSuggest = "Untitled Quiz";
            questionSuggest = "Enter the quesition here";
            newQuestionLabel = "New Question";
            answerSuggest = "";
            if (File.Exists(filename))
            {
                currentlyMakingQuiz = readQuizFile(filename);
            }
            else
            {
                MessageBox.Show("The quiz file \"" + filename + "\" does not exist.");
                this.Close();
            }

            textboxTitle.Text = titleSuggest;

            for (int i = 0; i < currentlyMakingQuiz.Questions.Count; i++)
            {
                listboxQuestions.Items.Add(currentlyMakingQuiz.Questions[i].Prompt);
            }
            if (currentlyMakingQuiz.Questions.Count <= 0)
            {
                addBlankQuestion(0);
            }
        }

        private void addBlankQuestion(int index)
        {
            currentlyMakingQuiz.Questions.Insert(index, new Question(qType.Fill_In, questionSuggest, answerSuggest));
            listboxQuestions.Items.Insert(index, newQuestionLabel);

            currentQuestionIndex = index;
            textboxPromptEdit.Text = questionSuggest;
            listboxQuestions.SelectedIndex = currentQuestionIndex;
        }

        private Quiz readQuizFile(string filename)
        {
            Quiz openedQuiz = new Quiz("Unopened Quiz");
            string[] fields;
            string[] fileLines = System.IO.File.ReadAllLines(filename);

            fields = fileLines[0].Split(new string[] { "~>" }, StringSplitOptions.None);
            openedQuiz.Title = fields[0];
            openedQuiz.DateModified = DateTime.Parse(fields[1]);

            for (int i = 2; i < fileLines.Length-2; i++)
            {
                fields = fileLines[i].Split(new string[] { "~>" }, StringSplitOptions.None);
                openedQuiz.Questions.Add(new Question(qType.Fill_In, fields[1], fields[2]));
            }
            return openedQuiz;
        }

        private void textboxPromptEdit_TextChanged(object sender, EventArgs e)
        {
            // whenever the text in the text box is changed, save it
            currentlyMakingQuiz.Questions[currentQuestionIndex].Prompt = textboxPromptEdit.Text;

            if (textboxPromptEdit.Text != questionSuggest)
            {
                listboxQuestions.Items[currentQuestionIndex] = textboxPromptEdit.Text;
            }
        }

        private void textboxAnswerEdit_TextChanged(object sender, EventArgs e)
        {
            // Whenever the answer is changed, save the new answer text
            currentlyMakingQuiz.Questions[currentQuestionIndex].Answer = textboxAnswerEdit.Text;

        }

        private void buttonAddQuestion_Click(object sender, EventArgs e)
        {
            addBlankQuestion(currentQuestionIndex + 1);
        }

        private void buttonRemoveQuestion_Click(object sender, EventArgs e)
        {
            // Remove a Question
            listboxQuestions.Items.RemoveAt(currentQuestionIndex);
            currentlyMakingQuiz.Questions.RemoveAt(currentQuestionIndex);
            if (currentQuestionIndex > 0)
            {
                currentQuestionIndex--;
                listboxQuestions.SelectedIndex = currentQuestionIndex;
            }
            else if (currentlyMakingQuiz.Questions.Count <= 0)
            {
                addBlankQuestion(0);
            }
        }

        private void textboxTitle_TextChanged(object sender, EventArgs e)
        {
            // Whenever Title is changed, save the new title
            currentlyMakingQuiz.Title = textboxTitle.Text;
        }

        private void buttonSaveQuiz_Click(object sender, EventArgs e)
        {
            // Save the quiz.  To a text file for now.
            //add a file location for it to save to for now

            // In the future, add a blank field checker that checks the title, author, other fields, and questions and answers for blank or default values, 
            // and asks the user if they want to fill them in before saving

            currentlyMakingQuiz.DateModified = DateTime.Now;

            const string sPath = "save.txt";

            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
            // Write all fields/metadata to first line
            SaveFile.WriteLine(currentlyMakingQuiz.Title + "~>" + currentlyMakingQuiz.DateModified + "~>");
            SaveFile.WriteLine();
            // Write each question (incl. answer) to it's own line
            foreach (Question item in currentlyMakingQuiz.Questions)
            {
                SaveFile.WriteLine(item.QuestionType + "~>" + item.Prompt + "~>" + item.Answer + "~>");
            }
            SaveFile.WriteLine();
            SaveFile.WriteLine("~>END~>");
            SaveFile.Close();
            MessageBox.Show("Quiz saved!");
        }

        private void listboxQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            // A different list item has been selected
            if (listboxQuestions.SelectedIndex >= 0)
            {
                currentQuestionIndex = listboxQuestions.SelectedIndex;
                textboxPromptEdit.Text = currentlyMakingQuiz.Questions[currentQuestionIndex].Prompt;
                textboxAnswerEdit.Text = currentlyMakingQuiz.Questions[currentQuestionIndex].Answer;
            }
            else if (currentlyMakingQuiz.Questions.Count <= 0)
            {
                addBlankQuestion(0);
            }
        }

        private void textboxPromptEdit_Click(object sender, EventArgs e)
        {
            // When the Question textbox is in focus, clear any suggestion text
            if (textboxPromptEdit.Text == questionSuggest)
            {
                textboxPromptEdit.SelectAll();
                textboxPromptEdit.Focus();
            }
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
    }
}
