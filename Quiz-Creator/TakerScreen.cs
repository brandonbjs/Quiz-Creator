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
        public TakerScreen()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            // Back Button
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            // Next Button
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

            // For future implementations, save quiz here
        }
    }
}
