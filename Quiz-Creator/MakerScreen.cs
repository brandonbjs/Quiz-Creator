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
        string newQuestionLabel = "New Question";

        string answerSuggest = "";
        string MCopt1Suggest = "True";
        string MCopt2Suggest = "False";
        string MCopt5Suggest = "N/A";

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
            currentQuestionIndex = index;
            
            currentlyMakingQuiz.InsertQuestion(index, new Question("FITB", questionSuggest, answerSuggest));

            listboxQuestions.Items.Insert(index, newQuestionLabel);
            listboxQuestions.SelectedIndex = currentQuestionIndex;
            tabControlQuestionType.SelectedIndex = 0;

            textboxPromptEdit.Text = questionSuggest;
            textboxAnswerEdit.Text = answerSuggest;
        }

        private void setFITBData()
        {
            currentlyMakingQuiz.SetQuestion(currentQuestionIndex, new Question("FITB", textboxPromptEdit.Text, textboxAnswerEdit.Text));
        }

        private void setMultipleChoiceData()
        {
            int correctAnsIndex = -1;
            List<string> choices = new List<string>();

            #region Add a choice to the list from each non empty choice textbox

            if (textBoxMC1.Text != "")
            {
                choices.Add(textBoxMC1.Text);
                if (radioButtonMC1.Checked)
                {
                    correctAnsIndex = choices.Count - 1;
                }
            }

            if (textBoxMC2.Text != "")
            {
                choices.Add(textBoxMC2.Text);
                if (radioButtonMC2.Checked)
                {
                    correctAnsIndex = choices.Count - 1;
                }
            }

            if (textBoxMC3.Text != "")
            {
                choices.Add(textBoxMC3.Text);
                if (radioButtonMC3.Checked)
                {
                    correctAnsIndex = choices.Count - 1;
                }
            }

            if (textBoxMC4.Text != "")
            {
                choices.Add(textBoxMC4.Text);
                if (radioButtonMC4.Checked)
                {
                    correctAnsIndex = choices.Count - 1;
                }
            }

            if (textBoxMC5.Text != "")
            {
                choices.Add(textBoxMC5.Text);
                if (radioButtonMC5.Checked)
                {
                    correctAnsIndex = choices.Count - 1;
                }
            }

            #endregion

            string correctAns = "";

            if (correctAnsIndex > -1)
            {
                correctAns = (correctAnsIndex + 1).ToString();
            }

            string[] choicesArr = new string[choices.Count];

            #region Put the choices in a fixed length array

            for (int j = 0; j < choices.Count; j++)
            {
                choicesArr[j] = choices[j];
            }

            #endregion

            #region Error Prevention - Make sure at least two options are filled and a filled option is marked as correct

            if (choices.Count < 1)
            {
                textBoxMC1.Text = MCopt1Suggest;
                textBoxMC2.Text = MCopt2Suggest;
                radioButtonMC1.Checked = true;
            }

            else if (choices.Count < 2 && textBoxMC5.Text == "")
            {
                textBoxMC5.Text = MCopt5Suggest;
                if (correctAnsIndex == -1)
                {
                    radioButtonMC5.Checked = true;
                }
                else
                {
                    setMultipleChoiceData();
                }
            }

            else if (choices.Count < 2 && textBoxMC1.Text == "")
            {
                textBoxMC1.Text = MCopt1Suggest;
                if (correctAnsIndex == -1)
                {
                    radioButtonMC1.Checked = true;
                }
                else
                {
                    setMultipleChoiceData();
                }
            }

            if (correctAnsIndex == -1)
            {
                if (textBoxMC1.Text != "")
                {
                    radioButtonMC1.Checked = true;
                }
                else if (textBoxMC5.Text != "")
                {
                    radioButtonMC5.Checked = true;
                }
                else if (textBoxMC2.Text != "")
                {
                    radioButtonMC2.Checked = true;
                }
                else if (textBoxMC3.Text != "")
                {
                    radioButtonMC3.Checked = true;
                }
                else if (textBoxMC4.Text != "")
                {
                    radioButtonMC4.Checked = true;
                }
            }

            #endregion

            currentlyMakingQuiz.SetQuestion(currentQuestionIndex, new MCQuestion(choicesArr, "MC", textboxPromptEdit.Text, correctAns));
        }

        #endregion

        #region Windows Forum Event Methods

        #region Title and Saving

        private void buttonSaveQuiz_Click(object sender, EventArgs e)
        {
            // TODO: test saving for multiple choice questions

            // Save the quiz.  To an xml file
            // add a file location for it to save to for now

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
                if (currentlyMakingQuiz.GetQuestion(index).GetQuestionType() == "FITB")
                {
                    xmlDocument.Element("Quizzes").Elements("Quiz")
                    .First(c => (string)c.Attribute("date") == currentlyMakingQuiz.GetModifiedDate()).Add
                    (
                        new XElement("Question", new XAttribute("type", currentlyMakingQuiz.GetQuestion(index).GetQuestionType()),
                            new XElement("Prompt", currentlyMakingQuiz.GetQuestion(index).GetPrompt()),
                            new XElement("Answer", currentlyMakingQuiz.GetQuestion(index).GetAnswer())
                    ));
                }

                else if (currentlyMakingQuiz.GetQuestion(index).GetQuestionType() == "MC")
                {
                    xmlDocument.Element("Quizzes").Elements("Quiz")
                    .First(c => (string)c.Attribute("date") == currentlyMakingQuiz.GetModifiedDate()).Add
                    (
                        new XElement("Question", new XAttribute( "type", currentlyMakingQuiz.GetQuestion(index).GetQuestionType() ),
                            new XElement( "Prompt", currentlyMakingQuiz.GetQuestion(index).GetPrompt() ),
                            new XElement( "Answer", currentlyMakingQuiz.GetQuestion(index).GetAnswer() ),
                            new XElement( "Choices" )
                    ));
                    for (int j = 0; j < ((MCQuestion)currentlyMakingQuiz.GetQuestion(index)).GetNumChoices(); j++)
                    {
                        xmlDocument.Element("Quizzes").Elements("Quiz")
                        .First(c => (string)c.Attribute("date") == currentlyMakingQuiz.GetModifiedDate()).Elements("Question").ElementAt(index).Elements("Choices").FirstOrDefault().Add
                        (
                            new XElement("Choice", ( (MCQuestion) currentlyMakingQuiz.GetQuestion(index) ).GetChoice(j))
                        );
                    }
                }
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
            currentQuestionIndex++;
            addBlankQuestion(currentQuestionIndex);
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
            // TODO: switch to appropriate tab for question selected

            // A different list item has been selected
            if (listboxQuestions.SelectedIndex >= 0)
            {
                currentQuestionIndex = listboxQuestions.SelectedIndex;
                Question thisQ = currentlyMakingQuiz.GetQuestion(currentQuestionIndex);

                textboxPromptEdit.Text = thisQ.GetPrompt();

                if (thisQ.GetQuestionType() == "FITB")
                {
                    tabControlQuestionType.SelectedIndex = 0;
                    textboxAnswerEdit.Text = thisQ.GetAnswer();
                }
                else if (thisQ.GetQuestionType() == "MC")
                {
                    tabControlQuestionType.SelectedIndex = 1;

                    textBoxMC1.Text = thisQ.GetNumChoices() > 0 ? thisQ.GetChoice(0) : "";
                    textBoxMC2.Text = thisQ.GetNumChoices() > 1 ? thisQ.GetChoice(1) : "";
                    textBoxMC3.Text = thisQ.GetNumChoices() > 2 ? thisQ.GetChoice(2) : "";
                    textBoxMC4.Text = thisQ.GetNumChoices() > 3 ? thisQ.GetChoice(3) : "";
                    textBoxMC5.Text = thisQ.GetNumChoices() > 4 ? thisQ.GetChoice(4) : "";

                    #region Fill as many textboxes as there are choices
                    /*
                    if (thisQ.GetNumChoices() > 0)
                    {
                        textBoxMC1.Text = thisQ.GetChoice(0);
                    }

                    if (thisQ.GetNumChoices() > 1)
                    {
                        textBoxMC2.Text = thisQ.GetChoice(1);
                    }

                    if (thisQ.GetNumChoices() > 2)
                    {
                        textBoxMC3.Text = thisQ.GetChoice(2);
                    }
                    if (thisQ.GetNumChoices() > 3)
                    {
                        textBoxMC4.Text = thisQ.GetChoice(3);
                    }
                    if (thisQ.GetNumChoices() > 4)
                    {
                        textBoxMC5.Text = thisQ.GetChoice(4);
                    }
                    */
                    #endregion

                    #region Check the correct radio button for the answer

                    if (thisQ.GetAnswer() == "1")
                    {
                        radioButtonMC1.Checked = true;
                    }
                    if (thisQ.GetAnswer() == "2")
                    {
                        radioButtonMC2.Checked = true;
                    }
                    if (thisQ.GetAnswer() == "3")
                    {
                        radioButtonMC3.Checked = true;
                    }
                    if (thisQ.GetAnswer() == "4")
                    {
                        radioButtonMC4.Checked = true;
                    }
                    if (thisQ.GetAnswer() == "5")
                    {
                        radioButtonMC5.Checked = true;
                    }

                    #endregion


                }


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

            if (currentlyMakingQuiz.GetQuestion(currentQuestionIndex).GetQuestionType() == "FITB")
            {
                setFITBData();
            }
            else if (currentlyMakingQuiz.GetQuestion(currentQuestionIndex).GetQuestionType() == "MC")
            {
                setMultipleChoiceData();
            }

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
            if (tabControlQuestionType.SelectedIndex == 0)
            {
                setFITBData();
            }
            if (tabControlQuestionType.SelectedIndex == 1)
            {
                if (currentlyMakingQuiz.GetQuestion(currentQuestionIndex).GetQuestionType() == "FITB")
                {
                    textBoxMC5.Text = "";
                    textBoxMC4.Text = "";
                    textBoxMC3.Text = "";
                    textBoxMC2.Text = "False";
                    textBoxMC1.Text = "True";
                    radioButtonMC1.Checked = true;
                }
                setMultipleChoiceData();
            }
        }

        #endregion

        #region Fill in the Blank

        private void textboxAnswerEdit_TextChanged(object sender, EventArgs e)
        {
            // Whenever the answer is changed, save the new answer text
            setFITBData();
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
            setMultipleChoiceData();
        }

        private void radioButtonMC2_CheckedChanged(object sender, EventArgs e)
        {
            setMultipleChoiceData();
        }

        private void radioButtonMC3_CheckedChanged(object sender, EventArgs e)
        {
            setMultipleChoiceData();
        }

        private void radioButtonMC4_CheckedChanged(object sender, EventArgs e)
        {
            setMultipleChoiceData();
        }

        private void radioButtonMC5_CheckedChanged(object sender, EventArgs e)
        {
            setMultipleChoiceData();
        }

        #endregion

        #region Multiple Choice TextBoxes

        private void textBoxMC1_TextChanged(object sender, EventArgs e)
        {
            setMultipleChoiceData();
        }

        private void textBoxMC2_TextChanged(object sender, EventArgs e)
        {
            setMultipleChoiceData();
        }

        private void textBoxMC3_TextChanged(object sender, EventArgs e)
        {
            setMultipleChoiceData();
        }

        private void textBoxMC4_TextChanged(object sender, EventArgs e)
        {
            setMultipleChoiceData();
        }

        private void textBoxMC5_TextChanged(object sender, EventArgs e)
        {
            setMultipleChoiceData();
        }

        #endregion

        #endregion

        #endregion

        #endregion
    }
}
