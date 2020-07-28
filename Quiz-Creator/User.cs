using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Creator
{
    class User
    {
        private string username;

        private string password;

        private string userType;

        public User(string in_name, string in_pass, string in_userType)
        {
            username = in_name;

            password = in_pass;

            userType = in_userType;
        }

        public string GetName()
        {
            return username;
        }

        public void setName(string in_name)
        {
            username = in_name;
        }
        public string GetPassword()
        {
            return password;
        }

        public void setPassword(string in_password)
        {
            password = in_password;
        }

    }
}
