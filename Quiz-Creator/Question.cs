using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Creator
{
    class Question
    {
        public qType QuestionType;

        public string Prompt;
        public string Answer;
        public string Response;


        public Question(qType in_questionType, string in_prompt, string in_answer)
        {
            QuestionType = in_questionType;
            Prompt = in_prompt;
            Answer = in_answer;
            Response = "";
        }
    }

    public enum qType { Fill_In, Multiple_Choice, Matching, Short_Answer }
}
