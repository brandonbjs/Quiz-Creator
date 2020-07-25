using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Creator
{
    abstract class Question
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

    class MCquestion : Question
    {
        public MCquestion(qType in_questionType, string in_prompt, string in_answer) : base(in_questionType, in_prompt, in_answer)
        {

        }
    }

    class FITBquestion : Question
    {
        public FITBquestion(qType in_questionType, string in_prompt, string in_answer) : base(in_questionType, in_prompt, in_answer)
        {

        }
    }

    class Matchquestion : Question
    {
        public Matchquestion(qType in_questionType, string in_prompt, string in_answer) : base(in_questionType, in_prompt, in_answer)
        {

        }
    }
    public enum qType { Fill_In, Multiple_Choice, Matching, Short_Answer }
}
