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
        private int currentQuestionIndex = 0;

        private Quiz currentlyTakingQuiz;

        public TakerScreen(string quizDate, Boolean isLocal)
        {
            InitializeComponent();

            //load the selected quiz into the object
            if(isLocal)
            {
                currentlyTakingQuiz = new Quiz();

                currentlyTakingQuiz.AddDataFromFile("LocalQuizzes.xml", quizDate);

                currentlyTakingQuiz.SerializeQuiz();
                MessageBox.Show("worked");
            }
            else
            {
                //not yet implemented
            }
            comboBoxQuestionSelect.SelectedIndex = 0;

            labelQuizTitle.Text = currentlyTakingQuiz.GetTitle();

            groupBoxQuestion.Text = "Question " + (currentQuestionIndex+1).ToString();

            labelPrompt.Text = currentlyTakingQuiz.GetQuestion(currentQuestionIndex).GetPrompt();

            if(currentlyTakingQuiz.GetQuestion(currentQuestionIndex).GetQuestionType() == "FITB")
            {
                DisplayFITB(currentlyTakingQuiz.GetQuestion(currentQuestionIndex));
            }
            else
            {
                DisplayMC((MCQuestion)currentlyTakingQuiz.GetQuestion(currentQuestionIndex));
            }
            Manage_Buttons();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            // Back Button
            SaveResponse();

            currentQuestionIndex--;

            if (currentlyTakingQuiz.GetQuestion(currentQuestionIndex).GetQuestionType() == "FITB")
            {
                DisplayFITB(currentlyTakingQuiz.GetQuestion(currentQuestionIndex));
            }
            else
            {
                DisplayMC((MCQuestion)currentlyTakingQuiz.GetQuestion(currentQuestionIndex));
            }
            Manage_Buttons();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            // Next Button
            SaveResponse();

            currentQuestionIndex++;

            if (currentlyTakingQuiz.GetQuestion(currentQuestionIndex).GetQuestionType() == "FITB")
            {
                DisplayFITB(currentlyTakingQuiz.GetQuestion(currentQuestionIndex));
            }
            else
            {
                DisplayMC((MCQuestion)currentlyTakingQuiz.GetQuestion(currentQuestionIndex));
            }
            Manage_Buttons();
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

        private void AddFromLocal(string quizDate)
        {
            XmlDocument localDoc = new XmlDocument();

            localDoc.Load("LocalQuizzes.xml");

            XmlNodeList quizNodes = localDoc.GetElementsByTagName("Quiz");

            XmlNode selectedQuizNode = null;

            foreach (XmlNode node in quizNodes)
            {
                if (node.Attributes[1].InnerText == quizDate)
                {
                    selectedQuizNode = node;
                }
            }
            string quizTitle = selectedQuizNode.Attributes[0].InnerText;

            currentlyTakingQuiz = new Quiz(quizTitle);

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

                    for(int index = 0; index < numChoices; index++)
                    {
                        questionChoices[index] = choicesNode[index].InnerText;
                    }
                    currentlyTakingQuiz.AddQuestion(new MCQuestion(questionChoices, newQuestionType, newQuestionPrompt, newQuestionAnswer));
                }
                else
                {
                    currentlyTakingQuiz.AddQuestion(new Question(newQuestionType, newQuestionPrompt, newQuestionAnswer));
                }
            }
            currentlyTakingQuiz.SerializeQuiz();
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

        private void DisplayFITB(Question in_question)
        {
            groupBoxQuestion.Text = "Question " + (currentQuestionIndex + 1).ToString();

            //Show FITB response
            labelResponse.Visible = true;
            textBoxResponse.Visible = true;
            textBoxResponse.Text = in_question.GetResponse();
            labelPrompt.Text = in_question.GetPrompt();

            //Hide MC buttons
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
        }

        private void DisplayMC(MCQuestion in_question)
        {
            groupBoxQuestion.Text = "Question " + (currentQuestionIndex + 1).ToString();

            //Hide FITB response
            labelResponse.Visible = false;
            textBoxResponse.Visible = false;

            //Show MC
            labelPrompt.Text = in_question.GetPrompt();

            int numChoices = in_question.GetNumChoices();

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


            if (numChoices > 1)
            {
                radioButton1.Text = in_question.GetChoice(0);
                radioButton2.Text = in_question.GetChoice(1);
                radioButton1.Visible = true;
                radioButton2.Visible = true;
            }
            if(numChoices > 2)
            {
                radioButton3.Text = in_question.GetChoice(2);
                radioButton3.Visible = true;
            }
            if(numChoices > 3)
            {
                radioButton4.Text = in_question.GetChoice(3);
                radioButton4.Visible = true;

            }
            if(numChoices > 4)
            {
                radioButton5.Text = in_question.GetChoice(4);
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
            if (currentQuestionIndex == 0) { buttonBack.Enabled = false; }
            else { buttonBack.Enabled = true; }

            if (currentQuestionIndex == currentlyTakingQuiz.GetNumQuestions()-1) { buttonNext.Enabled = false; }
            else{ buttonNext.Enabled = true; }
        }
    }
}
