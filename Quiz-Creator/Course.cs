using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Creator
{
    public class Course
    {
        private string courseName;

        private string instructorName;

        List<Quiz> quizList;

        public Course(string in_name, string in_instructor)
        {
            courseName = in_name;
            instructorName = in_instructor;
        }

        public string GetName()
        {
            return courseName;
        }

        public void setName(string in_name)
        {
            courseName = in_name;
        }

        public string GetInstructorName()
        {
            return instructorName;
        }
    }
}
