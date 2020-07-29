using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Creator
{
    class Course
    {
        private string coursename;


        public Course(string in_name)
        {
            coursename = in_name;
        }

        public string GetName()
        {
            return coursename;
        }

        public void setName(string in_name)
        {
            coursename = in_name;
        }


    }
}
