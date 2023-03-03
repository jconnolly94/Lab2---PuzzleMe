using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2___PuzzleMe
{
    public class Quiz
    {
        List<Question> questions= new List<Question>();
        int totalMarks { get;  set; }
        String module { get; set; }
        String description { get; set; }

        public Quiz(String module, String description)
        {
            this.questions = new List<Question>();
            this.totalMarks = totalMarks;
            this.module = module;
            this.description = description;
            totalMarks = 0;

        }

        public void saveQuiz(String module, String description, List<Question> questions)
        {
            this.module = module;
            this.description= description;
            this.questions = questions;
            totalMarks = questions.Sum(q => q.marks);
        }
        public void addQuestion(Question q)
        {
            questions.Add(q);
            totalMarks = questions.Sum(q => q.marks);
        }

        public string getTitle()
        {
            return this.module + " - " + this.description;
        }

        public string getModule()
        {
            return this.module;
        }

        public string getDescription()
        {
            return this.description;
        }

        public int getTotalMarks()
        {
            return this.totalMarks;
        }

        public int getNumQuestions()
        {
            Debug.Print("Num: " + questions.Count());
            return questions.Count();
        }

        public List<Question> GetQuestions()
        {
            return questions;
        }

        public void updateQuestion(int index, Question q)
        {
            questions.Where(i => questions.IndexOf(i) == index);
        }

        public void removeQuestion(int index)
        {
            questions.RemoveAt(index);
        }
    }
}
