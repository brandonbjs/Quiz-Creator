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
            // Whenever the prompt is changed, save the new prompt text

        }

        private void textboxAnswerEdit_TextChanged(object sender, EventArgs e)
        {
            // Whenever the answer is changed, save the new answer text
        }

        private void buttonAddQuestion_Click(object sender, EventArgs e)
        {
            // Add a Question
        }

        private void buttonRemoveQuestion_Click(object sender, EventArgs e)
        {
            // Remove a Question
        }

        private void textboxTitle_TextChanged(object sender, EventArgs e)
        {
            // Whenever Title is changed, save the new title
        }

        private void buttonSaveQuiz_Click(object sender, EventArgs e)
        {
            // Save the quiz.  To a text file for now.
        }
    }
}
