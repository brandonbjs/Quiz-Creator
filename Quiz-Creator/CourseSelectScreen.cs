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
    public partial class CourseSelectScreen : Form
    {
        public CourseSelectScreen()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //list of course names
            listBox1.Items.Add("CS 386");
            listBox1.Items.Add("CS 480");
        }
    }
}
