using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Creator
{
    [Serializable]
    public class MCQuestion : Question
    {
        public string[] choices;

        public MCQuestion(string[] in_choices, string in_questionType, string in_prompt, string in_answer) : base(in_questionType, in_prompt, in_answer)
        {
            choices = new string[in_choices.Length];

            for(int index = 0; index < in_choices.Length; index++)
            {
                choices[index] = in_choices[index];
            }
        }

        public override string GetChoice(int in_index)
        {
            return choices[in_index];
        }

        public override int GetNumChoices()
        {
            return choices.Length;
        }
    }
}
