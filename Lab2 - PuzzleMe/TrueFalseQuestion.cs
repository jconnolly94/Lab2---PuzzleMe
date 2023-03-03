using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2___PuzzleMe
{
    internal class TrueFalseQuestion : Question
    {
        bool answer;

        public TrueFalseQuestion(String questionString, int marks, bool ans): base(questionString, marks) {
            this.answer = ans;
        }

        public bool getAnswer() { return answer; }

        public void updateQuestion(string questionText, bool ans)
        {
            this.QuestionString = questionText;
            this.answer=ans;
        }
    }
}
