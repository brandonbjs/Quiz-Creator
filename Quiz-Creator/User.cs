using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Creator
{
    public class User
    {
        private string email;

        private string password;

        private string userType;

        private int id;

        private string org;

        public User(string in_email, string in_pass, string in_userType, string in_org, int in_id)
        {
            email = in_email;

            password = in_pass;

            userType = in_userType;

            org = in_org;

            id = in_id;
        }

        public string GetEmail()
        {
            return email;
        }

        public void SetName(string in_email)
        {
            email = in_email;
        }
        public string GetPassword()
        {
            return password;
        }

        public void SetPassword(string in_password)
        {
            password = in_password;
        }

        public string GetUserType()
        {
            return userType;
        }

    }
}
