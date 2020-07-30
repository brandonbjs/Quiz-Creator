using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Quiz_Creator
{
    public partial class CourseQuizzesList : Form
    {
        public CourseQuizzesList()
        {
            InitializeComponent();
        }

        private void DisplayQuizzes()
        {
            string server = "quizcreatordb.ctvd1ztjykvr.us-east-1.rds.amazonaws.com";
            string database = "QC_database";
            string uid = "admin";
            string password = "quizcreator";
            string connectionString = "Server=" + server + "; Port=3306; Database=" + database + "; Uid=" + uid + "; Pwd=" + password;

            MySqlConnection conn = new MySqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM QC_database.coursequizzes;";

            var cmd = new MySqlCommand(sql, conn);

            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                string[] row = { rdr.GetString("quiz_name")};

                var listViewItem = new ListViewItem(row);

                QuizList.Items.Add(listViewItem);
            }

            conn.Close();
        }
    }
}

