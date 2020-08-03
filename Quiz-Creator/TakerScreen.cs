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
using System.Threading;
using System.Xml;

namespace Quiz_Creator
{
    public partial class TakerScreen : Form
    {
        private int currentQuestionIndex;

        private Quiz currentlyTakingQuiz;

        public TakerScreen(string quizDate, Boolean isLocal)
        {
            InitializeComponent();

            //load the selected quiz into the object
            if(isLocal)
            {
                currentlyTakingQuiz = new Quiz();

                currentlyTakingQuiz.AddDataFromFile("LocalQuizzes.xml", quizDate);
            }
            else
            {
                //not yet implemented
            }

        }
        public TakerScreen(Quiz courseQuiz)
        {
            InitializeComponent();

            currentlyTakingQuiz = courseQuiz;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            SaveResponse();

            currentQuestionIndex--;

            DisplayQuestion();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            // Next Button
            SaveResponse();

            currentQuestionIndex++;

            DisplayQuestion();
        }

        private void DisplayQuestion()
        {
            if (currentlyTakingQuiz.GetQuestion(currentQuestionIndex).GetQuestionType() == "FITB")
            {
                DisplayFITB();
            }
            else
            {
                DisplayMC();
            }
            Manage_Buttons();

            comboBoxQuestionSelect.SelectedIndex = currentQuestionIndex;
        }

        private void buttonSubmitQuiz_Click(object sender, EventArgs e)
        {
            // For implementation 1, show results as "you got x/total" in a popup/messagebox
            SaveResponse();

            int numQuestions = currentlyTakingQuiz.GetNumQuestions();

            string summaryString = "";

            for(int index = 0; index < numQuestions; index++)
            {
                summaryString += "\nQuestion #" + (index + 1) + ": ";

                if(currentlyTakingQuiz.GetQuestion(index).CorrectResponse())
                {
                    summaryString += "Correct";
                }
                else
                {
                    summaryString += "Incorrect";
                }
            }
            MessageBox.Show(summaryString);

            // For future implementations, save quiz here
        }

        private void SaveResponse()
        {
            if (currentlyTakingQuiz.GetQuestion(currentQuestionIndex).GetQuestionType() == "FITB")
            {
                currentlyTakingQuiz.GetQuestion(currentQuestionIndex).SetResponse(textBoxResponse.Text);
            }
            else
            {
                string userResponse = "";

                if(radioButton1.Checked) { userResponse = "1"; }
                if(radioButton2.Checked) { userResponse = "2"; }
                if(radioButton3.Checked) { userResponse = "3"; }
                if(radioButton4.Checked) { userResponse = "4"; }
                if(radioButton5.Checked) { userResponse = "5"; }

                currentlyTakingQuiz.GetQuestion(currentQuestionIndex).SetResponse(userResponse);
            }
        }

        private void DisplayFITB()
        {
            Question selectedQuestion = currentlyTakingQuiz.GetQuestion(currentQuestionIndex);

            groupBoxQuestion.Text = "Question " + (currentQuestionIndex + 1).ToString();

            //Show FITB response
            labelResponse.Visible = true;
            textBoxResponse.Visible = true;
            textBoxResponse.Text = selectedQuestion.GetResponse();
            labelPrompt.Text = selectedQuestion.GetPrompt();

            //Hide MC buttons
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
        }

        private void DisplayMC()
        {
            Question selectedQuestion = currentlyTakingQuiz.GetQuestion(currentQuestionIndex);

            groupBoxQuestion.Text = "Question " + (currentQuestionIndex + 1).ToString();

            //Hide FITB response
            labelResponse.Visible = false;
            textBoxResponse.Visible = false;

            //Show MC
            labelPrompt.Text = selectedQuestion.GetPrompt();

            int numChoices = selectedQuestion.GetNumChoices();

            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;

            radioButton1.Text = selectedQuestion.GetChoice(0);
            radioButton2.Text = selectedQuestion.GetChoice(1);
            radioButton1.Visible = true;
            radioButton2.Visible = true;

            if(numChoices > 2)
            {
                radioButton3.Text = selectedQuestion.GetChoice(2);
                radioButton3.Visible = true;
            }
            if(numChoices > 3)
            {
                radioButton4.Text = selectedQuestion.GetChoice(3);
                radioButton4.Visible = true;

            }
            if(numChoices > 4)
            {
                radioButton5.Text = selectedQuestion.GetChoice(4);
                radioButton5.Visible = true;
            }
            switch(currentlyTakingQuiz.GetResponse(currentQuestionIndex))
            {
                case "1": radioButton1.Checked = true; break;
                case "2": radioButton2.Checked = true; break;
                case "3": radioButton3.Checked = true; break;
                case "4": radioButton4.Checked = true; break;
                case "5": radioButton5.Checked = true; break;
            }
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

            if (currentQuestionIndex == currentlyTakingQuiz.GetNumQuestions() - 1) 
            { 
                buttonNext.Enabled = false; 
            }
            else
            { 
                buttonNext.Enabled = true;
            }
        }

        private void comboBoxQuestionSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveResponse();

            currentQuestionIndex = comboBoxQuestionSelect.SelectedIndex;

            DisplayQuestion();
        }

        private void TakerScreen_Load(object sender, EventArgs e)
        {
            labelQuizTitle.Text = currentlyTakingQuiz.GetTitle();

            for ( int iter = 1; iter < currentlyTakingQuiz.GetNumQuestions() + 1; iter++ )
            {
                comboBoxQuestionSelect.Items.Add("Question #" + iter);
            }
            currentQuestionIndex = 0;

            DisplayQuestion();
        }
    }
}
