using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Quiz_Creator
{
    public partial class TakerScreen : Form
    {
        int currentQuestionIndex;

        int lastQuestionIndex;

        Quiz currentlyTakingQuiz;

        public TakerScreen()
        {
            InitializeComponent();
        }

        public TakerScreen(string filename)
        {
            // Call this contructor with a filename to open a quiz for taking
            InitializeComponent();

            string[] fileLines = File.ReadAllLines(filename);

            string[] fields = fileLines[0].Split(new string[] { "~> " }, StringSplitOptions.None);

            string title = fields[0];

            currentlyTakingQuiz = new Quiz(title);

            currentlyTakingQuiz.DateModified = DateTime.Parse(fields[1]);

            for (int i = 2; i < fileLines.Length - 2; i++)
            {
                fields = fileLines[i].Split(new string[] { "~> " }, StringSplitOptions.None);

                currentlyTakingQuiz.Questions.Add(new Question(qType.Fill_In, fields[1], fields[2]));
            }
            currentQuestionIndex = 0;

            lastQuestionIndex = fileLines.Length - 5;

            textboxQuestion.Text = currentlyTakingQuiz.Questions[currentQuestionIndex].Prompt;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            // Back Button
            currentQuestionIndex--;

            Manage_Buttons();

            textboxQuestion.Text = currentlyTakingQuiz.Questions[currentQuestionIndex].Prompt;

            textboxAnswer.Text = currentlyTakingQuiz.Questions[currentQuestionIndex].Response;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            // Next Button
            currentQuestionIndex ++;

            Manage_Buttons();

            textboxQuestion.Text = currentlyTakingQuiz.Questions[currentQuestionIndex].Prompt;

            textboxAnswer.Text = currentlyTakingQuiz.Questions[currentQuestionIndex].Response;
        }

        private void textboxAnswer_TextChanged(object sender, EventArgs e)
        {
            // Answer Text changed
        }

        private void buttonSubmitQuestion_Click(object sender, EventArgs e)
        {
            // Submit Question (Same as Next, unless we are on the last question and/or all questions are filled out)

        }

        private void buttonSubmitQuiz_Click(object sender, EventArgs e)
        {
            // Submit Quiz (Submits all questions)

            // For implementation 1, show results as "you got x/total" in a popup/messagebox
            int numQuestions = currentlyTakingQuiz.getNumQuestions();

            MessageBox.Show("You got " + Get_Num_Correct() + " out of " + numQuestions + "!");

            // For future implementations, save quiz here
        }

        private void textboxAnswer_Leave(object sender, EventArgs e)
        {
            currentlyTakingQuiz.Questions[currentQuestionIndex].Response = textboxAnswer.Text;
        }

        private int Get_Num_Correct()
        {
            int numCorrect = 0;

            int numQuestions = currentlyTakingQuiz.getNumQuestions();

            int index;

            for (index = 0; index < numQuestions; index++)
            {
                if (currentlyTakingQuiz.Questions[index].Response.ToUpper() == currentlyTakingQuiz.Questions[index].Answer.ToUpper())
                {
                    numCorrect++;
                }
            }
            return numCorrect;
        }

        private void Manage_Buttons()
        {
            if (currentQuestionIndex == 0)
            {
                buttonBack.Enabled = false;
            }
            else
            {
                buttonBack.Enabled = true;
            }
            if (currentQuestionIndex == lastQuestionIndex)
            {
                buttonNext.Enabled = false;
            }
            else
            {
                buttonNext.Enabled = true;
            }
        }
    }
}
