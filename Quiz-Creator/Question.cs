using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Creator
{
    [Serializable]
    public class Question
    {
        private string questionType;

        private string prompt;

        private string answer;

        private string response;

        public Question(string in_questionType, string in_prompt, string in_answer)
        {
            questionType = in_questionType;

            prompt = in_prompt;

            answer = in_answer;

            response = "";
        }

        public string GetQuestionType()
        {
            return questionType;
        }

        public void SetQuestionType(string in_questionType)
        {
            questionType = in_questionType;
        }

        public string GetPrompt()
        {
            return prompt;
        }

        public void SetPrompt(string in_prompt)
        {
            prompt = in_prompt;
        }

        public string GetAnswer()
        {
            return answer;
        }

        public void SetAnswer(string in_answer)
        {
            answer = in_answer;
        }

        public string GetResponse()
        {
            return response;
        }

        public void SetResponse(string in_response)
        {
            response = in_response;
        }

        public Boolean CorrectResponse()
        {
            return answer == response;
        }

        public virtual int GetNumChoices()
        {
            return 0;
        }

        public virtual string GetChoice(int choiceIndex)
        {
            return "";
        }
    }
}
