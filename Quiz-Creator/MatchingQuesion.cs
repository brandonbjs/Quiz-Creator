using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Creator
{
    class MatchingQuestion : Question
    {
        public string QuestionType;
        private string[][] choices;
        private string[] answers;
        private string[] responses;

        public MatchingQuestion(string in_questionType, string in_prompt, string in_answer) : base(in_questionType, in_prompt, in_answer)
        {

        }

        public Double CorrectResponse()
        {
            int numCorrect = 0;

            for (int index = 0; index < responses.Length; index++)
            {
                if (responses[index] == answers[index])
                {
                    numCorrect++;
                }
            }
            return numCorrect / responses.Length;
        }
    }
}
