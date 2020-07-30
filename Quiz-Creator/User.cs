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

        private Boolean isLoggedIn;

        private List<Course> courseList;

        public User()
        {
            isLoggedIn = false;

            courseList = new List<Course>();
        }

        public User(string in_email, string in_pass, string in_userType, string in_org, int in_id)
        {
            email = in_email;

            password = in_pass;

            userType = in_userType;

            org = in_org;

            id = in_id;
        }

        public void AddToCourseList(Course in_course)
        {
            courseList.Add(in_course);
        }

        public List<Course> GetCourseList()
        {
            return courseList;
        }

        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string in_email)
        {
            email = in_email;
        }
        public string GetPassword()
        {
            return password;
        }

        public void SetID(int in_ID)
        {
            id = in_ID;
        }

        public int getID()
        {
            return id;
        }

        public void SetPassword(string in_password)
        {
            password = in_password;
        }

        public string GetUserType()
        {
            return userType;
        }

        public void setLoginStatus(Boolean in_status)
        {
            isLoggedIn = in_status;
        }

        public Boolean getLoginStatus()
        {
            return isLoggedIn;
        }

    }
}
