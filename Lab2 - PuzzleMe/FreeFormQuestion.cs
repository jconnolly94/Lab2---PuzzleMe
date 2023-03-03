using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2___PuzzleMe
{
    internal class FreeFormQuestion : Question
    {
        //protected String answer { get; set; }
        protected int maxChar { get; set; }

        public FreeFormQuestion(String QuestionString, int marks, int maxChar): base(QuestionString, marks) 
        {
            //this.answer = ans;
            this.maxChar  = maxChar;
        }

        public int getMaxChar()
        {
            return maxChar;
        }

        public void updateQuestion(String questionText, int max)
        {
            this.QuestionString = questionText;
            this.maxChar = max;
        }

        
    }
}
