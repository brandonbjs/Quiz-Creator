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
using System.Xml;

namespace Quiz_Creator
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string server = "quizcreatordb.ctvd1ztjykvr.us-east-1.rds.amazonaws.com";
                string database = "login_info";
                string uid = "admin";
                string password = "quizcreator";
                string connectionString = "Server=" + server + "; Port=3306; Database=" + database + "; Uid=" + uid + "; Pwd=" + password;

                MySqlConnection conn = new MySqlConnection(connectionString);

                conn.Open();

                string sql = "SELECT * FROM `login_info` WHERE username= '" + txtUsername.Text + "' AND password='" + txtPassword.Text + "';";

                var cmd = new MySqlCommand(sql, conn);

                MySqlDataReader rdr = cmd.ExecuteReader();

                if (!rdr.Read())
                {
                    MessageBox.Show("Account not found.");
                }
                else
                {
                    MessageBox.Show("");
                }

                conn.Close();
            }
            catch
            {
                MessageBox.Show("Error connecting to database");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}