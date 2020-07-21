using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Creator
{
    class Quiz
    {
        public string Title;
        public DateTime DateModified;
        public List<Question> Questions;

        public Quiz(string in_title) {
            Title = in_title;
            DateModified = DateTime.Now;
            Questions = new List<Question>();
        }
    }
}
