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
    public partial class MakerScreen : Form
    {
        public MakerScreen()
        {
            InitializeComponent();
        }

        private void textboxPromptEdit_TextChanged(object sender, EventArgs e)
        {
            // whenever the text in the text box is changed, save it
             this.Text = textboxPromptEdit.Text;
        }

        private void textboxAnswerEdit_TextChanged(object sender, EventArgs e)
        {
            // Whenever the answer is changed, save the new answer text
            this.Text = textboxAnswerEdit.Text;
        }

        private void buttonAddQuestion_Click(object sender, EventArgs e)
        {
            if(this.textboxPromptEdit.Text != "")
                {
                    listboxQuestions.Items.Add(this.textboxPromptEdit.Text);
                    this.textBoxPromptEdit.Focus();
                    this.textboxPromptEdit.Clear();
                }
            else
                {
                    MessageBox.Show("Please Enter a Prompt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.textboxPromptEdit.Focus();
                }
        }

        private void buttonRemoveQuestion_Click(object sender, EventArgs e)
        {
            // Remove a Question
            listboxQuestions.Items.Remove(listboxQuestions.SelectedItem);  
        }

        private void textboxTitle_TextChanged(object sender, EventArgs e)
        {
            // Whenever Title is changed, save the new title
            this.Text = textboxTitle.Text;
        }

        private void buttonSaveQuiz_Click(object sender, EventArgs e)
        {
            // Save the quiz.  To a text file for now.
            //add a file location for it to save to for now
            const string sPath = "save.txt";

            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
            foreach (var item in listboxQuestions.Items)
            {
                SaveFile.WriteLine(item);
            }
            SaveFile.Close();
            MessageBox.Show("Quiz saved!");
        }
    }
}
