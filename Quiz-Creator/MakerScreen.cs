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
            // Note: the main functionality here should be moved to the Quiz Class for reueseability

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

            textboxTitle.Text = currentlyMakingQuiz.GetTitle();

            for (int i = 0; i < currentlyMakingQuiz.GetNumQuestions(); i++)
            {
                listboxQuestions.Items.Add(currentlyMakingQuiz.GetQuestion(i).Prompt);
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

        private void addBlankQuestion(int index)
        {
            currentlyMakingQuiz.InsertQuestion(index, new Question(qType.Fill_In, questionSuggest, answerSuggest));
            listboxQuestions.Items.Insert(index, newQuestionLabel);

            currentQuestionIndex = index;
            textboxPromptEdit.Text = questionSuggest;
            textboxAnswerEdit.Text = answerSuggest;
            listboxQuestions.SelectedIndex = currentQuestionIndex;
        }

        private Quiz readQuizFile(string filename)
        {
            Quiz openedQuiz = new Quiz("Unopened Quiz");
            string[] fields;
            string[] fileLines = System.IO.File.ReadAllLines(filename);

            fields = fileLines[0].Split(new string[] { "~>" }, StringSplitOptions.None);
            openedQuiz.SetTitle(fields[0]);
            openedQuiz.SetModifiedDate(DateTime.Parse(fields[1]));

            for (int i = 2; i < fileLines.Length-2; i++)
            {
                fields = fileLines[i].Split(new string[] { "~>" }, StringSplitOptions.None);
                openedQuiz.AddQuestion(new Question(qType.Fill_In, fields[1], fields[2]));
            }
            return openedQuiz;
        }

        private void textboxPromptEdit_TextChanged(object sender, EventArgs e)
        {
            // whenever the text in the text box is changed, save it
            currentlyMakingQuiz.SetQuestion(currentQuestionIndex, new Question(qType.Fill_In, textboxPromptEdit.Text, textboxAnswerEdit.Text));

            if (textboxPromptEdit.Text != questionSuggest)
            {
                listboxQuestions.Items[currentQuestionIndex] = textboxPromptEdit.Text;
            }
        }

        private void textboxAnswerEdit_TextChanged(object sender, EventArgs e)
        {
            // Whenever the answer is changed, save the new answer text
            currentlyMakingQuiz.SetQuestion(currentQuestionIndex, new Question(qType.Fill_In, textboxPromptEdit.Text, textboxAnswerEdit.Text));
        }

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

        private void textboxTitle_TextChanged(object sender, EventArgs e)
        {
            // Whenever Title is changed, save the new title
            currentlyMakingQuiz.SetTitle(textboxTitle.Text);
        }

        private void buttonSaveQuiz_Click(object sender, EventArgs e)
        {
            // Save the quiz.  To a text file for now.
            //add a file location for it to save to for now

            // In the future, add a blank field checker that checks the title, author, other fields, and questions and answers for blank or default values, 
            // and asks the user if they want to fill them in before saving

            currentlyMakingQuiz.SetModifiedNow();

            const string sPath = "save.txt";

            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
            // Write all fields/metadata to first line
            SaveFile.WriteLine(currentlyMakingQuiz.GetTitle() + "~>" + currentlyMakingQuiz.GetModifiedDate() + "~>");
            SaveFile.WriteLine();
            // Write each question (incl. answer) to it's own line
            for (int i = 0; i < currentlyMakingQuiz.GetNumQuestions(); i++)
            {
                Question thisQ = currentlyMakingQuiz.GetQuestion(i);
                SaveFile.WriteLine(thisQ.QuestionType + "~>" + thisQ.Prompt + "~>" + thisQ.Answer + "~>");
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
                Question thisQ = currentlyMakingQuiz.GetQuestion(currentQuestionIndex);
                textboxPromptEdit.Text = thisQ.Prompt;
                textboxAnswerEdit.Text = thisQ.Answer;
            }
            else if (currentlyMakingQuiz.GetNumQuestions() <= 0)
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
