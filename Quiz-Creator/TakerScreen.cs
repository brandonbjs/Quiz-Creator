using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Creator
{
    public partial class TakerScreen : Form
    {
        int currentQuestionIndex;

        Quiz currentlyTakingQuiz;

        public TakerScreen()
        {
            InitializeComponent();
        }

        public TakerScreen(string filename)
        {
            // Call this contructor with a filename to open a quiz for taking
            InitializeComponent();

            if (File.Exists(filename))
            {
                currentlyTakingQuiz = readQuizFile(filename);
            }
            else
            {
                MessageBox.Show("The quiz file \"" + filename + "\" does not exist.");
                this.Close();
            }
            for (int i = 0; i < currentlyTakingQuiz.Questions.Count; i++)
            {
                listboxQuestions.Items.Add(currentlyTakingQuiz.Questions[i].Prompt);
            }
            if (currentlyTakingQuiz.Questions.Count <= 0)
            {
                MessageBox.Show("There are no more questions.");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            // Back Button
            currentQuestionIndex - 1;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            // Next Button
            currentQuestionIndex + 1;
        }

        private void textboxAnswer_TextChanged(object sender, EventArgs e)
        {
            // Answer Text changed
            currentlyTakingQuiz.Questions[currentQuestionIndex].Answer = textboxAnswerEdit.Text;
        }

        private void buttonSubmitQuestion_Click(object sender, EventArgs e)
        {
            // Submit Question (Same as Next, unless we are on the last question and/or all questions are filled out)
            if (currentQuestionIndex + 1 != null)
            {
                currentQuestionIndex + 1;
            }
            else
            {
                string message = "That was the last Question, the quiz has been saved and submitted.";
                MessageBox.Show(message);
                //just save the file for now, can have it graded and submitted at later implementation
            }
        }

        private void buttonSubmitQuiz_Click(object sender, EventArgs e)
        {
            // Submit Quiz (Submits all questions)

            // For implementation 1, show results as "you got x/total" in a popup/messagebox
            string message = "You got x/total";
            string title = "Grade";
            MessageBox.Show(message, title);

            // For future implementations, save quiz here
        }
    }
}
