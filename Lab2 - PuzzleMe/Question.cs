using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2___PuzzleMe
{
    public abstract class Question
    {
        protected String QuestionString { get; set; }
        protected int QuestionNumber { get; set; }
        public int marks { get; }

        public Question(String QuestionString, int marks) { 
            this.QuestionString = QuestionString;
            this.marks = marks;
        }

        public int getQuestionNum()
        {
            return this.QuestionNumber;
        }

        public string getQuestionString()
        {
            return this.QuestionString;
        }

        public void updateQuestion(String QuestionString)
        {
            this.QuestionString = QuestionString;
        }
     
        

        
    }
}
