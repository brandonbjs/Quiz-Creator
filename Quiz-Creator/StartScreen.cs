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
using System.Xml;
using System.Xml.Linq;

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
            var TakerScreen1 = new TakerScreen(GetSelectedQuizDate(), true);

            TakerScreen1.Show();
        }

        private void buttonEditLocal_Click(object sender, EventArgs e)
        {
            var MakerScreen1 = new MakerScreen(GetSelectedQuizDate());

            MakerScreen1.Show();
        }

        private string GetSelectedQuizDate()
        {
            XmlDocument localDoc = new XmlDocument();

            localDoc.Load("LocalQuizzes.xml");

            XmlNodeList quizNodes = localDoc.GetElementsByTagName("Quiz");

            int selectedQuizListIndex = listViewLocalQuizzes.SelectedIndices[0];

            return quizNodes[selectedQuizListIndex].Attributes[1].InnerText;
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {
            LoadLocalQuizzes();
        }

        private void LoadLocalQuizzes()
        {
            listViewLocalQuizzes.Items.Clear();

            XmlDocument localDoc = new XmlDocument();

            localDoc.Load("LocalQuizzes.xml");

            XmlNodeList quizNodes = localDoc.GetElementsByTagName("Quiz");

            foreach (XmlNode node in quizNodes)
            {
                string quizName = node.Attributes[0].InnerText;

                string quizDate = node.Attributes[1].InnerText;

                AddListItem(quizName, quizDate, listViewLocalQuizzes);
            }
        }

        //Adds name and date to specified list box
        private void AddListItem(string in_name, string in_date, ListView in_ListView)
        {
            ListViewItem newItem = new ListViewItem(in_name);

            newItem.SubItems.Add(in_date);

            in_ListView.Items.Add(newItem);
        }

        private void listViewLocalQuizzes_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listViewLocalQuizzes.SelectedItems.Count > 0)
            {
                buttonEditLocal.Enabled = true;

                buttonTakeLocal.Enabled = true;

                buttonDeleteLocal.Enabled = true;
            }
            else
            {
                buttonEditLocal.Enabled = false;

                buttonTakeLocal.Enabled = false;

                buttonDeleteLocal.Enabled = false;
            }
        }

        private void StartScreen_Activated(object sender, EventArgs e)
        {
            LoadLocalQuizzes();
            buttonEditLocal.Enabled = false;
            buttonDeleteLocal.Enabled = false;
            buttonTakeLocal.Enabled = false;
        }

        private void buttonDeleteLocal_Click(object sender, EventArgs e)
        {
            XDocument xmlDoc = XDocument.Load("LocalQuizzes.xml");

            xmlDoc.Root.Elements().Where(x => x.Attribute("date").Value == GetSelectedQuizDate()).Remove();

            xmlDoc.Save("LocalQuizzes.xml");

            LoadLocalQuizzes();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}