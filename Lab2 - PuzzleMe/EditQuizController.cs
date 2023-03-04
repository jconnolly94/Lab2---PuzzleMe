using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab2___PuzzleMe
{
    // Controller
    public class EditQuizController
    {
        Quiz currentQuiz;
        EditQuiz editQuizView;
        //Question currentQuestion;
        public EditQuizController(Quiz quiz) 
        { 
            this.currentQuiz = quiz;
            editQuizView = new EditQuiz(this);
            displayQuiz();
            editQuizView.Show();
        }

        public void displayQuiz()
        {
            editQuizView.txtModule.Text = currentQuiz.getModule();
            editQuizView.txtDesc.Text = currentQuiz.getDescription();
            editQuizView.txtMarks.Text = currentQuiz.getTotalMarks().ToString();
            editQuizView.txtNumQs.Text = currentQuiz.getNumQuestions().ToString();
        }

        public List<String> getQuestionList()
        {
            List<String> list = new List<String>();
            list = currentQuiz.GetQuestions().Select(q => q.getQuestionString()).ToList();
            return list;
        }

        public void updateQuiz(String module, String description)
        {
            currentQuiz.saveQuiz(module, description, currentQuiz.GetQuestions());
        }

        public void removeQuestion(int selectedIndex)
        {
            currentQuiz.removeQuestion(selectedIndex);
            displayQuiz();

        }

        public String getQuizMarks()
        {
            return currentQuiz.getTotalMarks().ToString();
        }
        public String getQuizNumQuestions()
        {
            return currentQuiz.getNumQuestions().ToString();
        }
        public int setupTabForQuestion(EditQuiz quizView, int selectedIndex)
        {
            if (selectedIndex < currentQuiz.GetQuestions().Count() && selectedIndex >= 0) 
            {
                Question currentQuestion = currentQuiz.GetQuestions().ElementAt(selectedIndex);
                var selectedType = currentQuestion.GetType();
                if (selectedType == typeof(FreeFormQuestion))
                {
                    FreeFormQuestion question = (FreeFormQuestion)currentQuestion;
                    quizView.setUpFreeFormQuestion(question.getQuestionString(), question.marks, question.getMaxChar());
                    return 0;
                }
                else if (selectedType == typeof(TrueFalseQuestion))
                {
                    TrueFalseQuestion question = (TrueFalseQuestion)currentQuestion;
                    quizView.setUpTFQuestion(question.getQuestionString(), question.marks, question.getAnswer());
                    return 1;
                }

                else if (selectedType == typeof(MultiQuestion))
                {
                    MultiQuestion question = (MultiQuestion)currentQuestion;
                    quizView.setUpMultiQuestion(question.getQuestionString(), question.marks, question.answers);
                    return 2;
                }
                else return 3;
            }
            else
            {
                return 1;
            }
        }

        

        public void updateFreeFormQuestion(int index, string question, int marks, int max)
        {
            FreeFormQuestion freeFormQuestion = new FreeFormQuestion(question, marks, max);
            if(index == -1){
                currentQuiz.addQuestion(freeFormQuestion);
            }
            else
            {
                currentQuiz.updateQuestion(index, freeFormQuestion);
            }
        }

        public void updateTFQuestion(int index, string question, int marks, bool ans)
        {
            TrueFalseQuestion trueFalseQuestion = new TrueFalseQuestion(question, marks, ans);
            if(index == -1)
            {
                currentQuiz.addQuestion(trueFalseQuestion);
            }
            else
            {
                currentQuiz.updateQuestion(index, trueFalseQuestion);
            }

        }

        public void updateMultiQuestion(int index, string question, int marks, Dictionary<string, bool> answerSet)
        {
            MultiQuestion multiQuestion = new MultiQuestion(question, marks, answerSet);
            if(index == -1)
            {
                currentQuiz.addQuestion(multiQuestion);
            }
            else
            {
                currentQuiz.updateQuestion(index, multiQuestion);
            }
        }
    }
}
