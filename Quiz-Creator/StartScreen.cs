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
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void buttonMakeLocal_Click(object sender, EventArgs e)
        {
            // Launch MakerScreen to make local
            var MakerScreen1 = new MakerScreen();
            MakerScreen1.Show();
        }

        private void buttonTakeLocal_Click(object sender, EventArgs e)
        {
            // Launch TakerScreen and open quiz

            // Read from file address textbox

            var TakerScreen1 = new TakerScreen();
            TakerScreen1.Show();
        }
    }
}