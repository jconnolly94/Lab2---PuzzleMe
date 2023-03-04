using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2___PuzzleMe
{
    internal class MultiQuestion : Question
    {
        public Dictionary<string, bool> answers { get; set; }
        public MultiQuestion(String QuestionString, int marks, Dictionary<string, bool>answers): base(QuestionString, marks)
        {
            this.answers = answers;
        }

        public void updateQuestion(string questionText, Dictionary<String, bool> answerSet)
        {
            this.QuestionString= questionText;
            this.answers = answerSet;
        }
    }
}
