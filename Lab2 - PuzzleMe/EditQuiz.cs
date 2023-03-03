using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2___PuzzleMe
{
    public partial class EditQuiz : Form
    {
        Quiz currentQuiz;
        Question selectedQuestion;
        public EditQuiz(Quiz currentQuiz)
        {
            this.currentQuiz = currentQuiz;
            InitializeComponent();
            txtModule.Text = currentQuiz.getModule();
            txtDesc.Text = currentQuiz.getDescription();
            txtMarks.Text = currentQuiz.getTotalMarks().ToString();
            txtNumQs.Text = currentQuiz.getNumQuestions().ToString();
            loadQuestionsIntoList();
            lstQuestions.SelectedIndex = lstQuestions.Items.Count-1;
        }

        private void selectionChanged(object sender, EventArgs e)
        {
            txtMarks.Text = currentQuiz.getTotalMarks().ToString();
            txtNumQs.Text = currentQuiz.getNumQuestions().ToString();
            if (lstQuestions.SelectedIndex != -1)
                refreshQuestionProperties();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateQ_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstQuestions.SelectedIndex;
            // Create new Question
            Question newQ;
            if (tabview.SelectedTab == tabFree)
            {
                newQ = new FreeFormQuestion(txtQuestion.Text, (int)numQMarks.Value, (int)numFreeMaxChar.Value);
            }
            else if (tabview.SelectedTab == tabTF)
            {
                newQ = new TrueFalseQuestion(txtQuestion.Text, (int)numQMarks.Value, rdoTrue.Checked);
            }
            else if (tabview.SelectedTab != tabMulti)
            {
                Dictionary<String, bool> answerSet = new Dictionary<String, bool>();
                answerSet.Add(txtMultiOne.Text, rdoMultiOne.Checked);
                answerSet.Add(txtMultiTwo.Text, rdoMultiTwo.Checked);
                answerSet.Add(txtMultiThree.Text, rdoMultiThree.Checked);
                answerSet.Add(txtMultiFour.Text, rdoMultiFour.Checked);
                newQ = new MultiQuestion(txtQuestion.Text, (int)numQMarks.Value, answerSet);
            }
            else
            {
                Debug.Print("Math: Not yet implemented!");
                newQ = new FreeFormQuestion(txtQuestion.Text, (int)numQMarks.Value, (int)numFreeMaxChar.Value);
            }
            if(selectedIndex == -1)
            {
                lstQuestions.Items.Add(newQ.getQuestionString());
            }
            else
            {
                lstQuestions.Items.RemoveAt(selectedIndex);
                lstQuestions.Items.Insert(selectedIndex, (selectedIndex + 1) + ": " + newQ.getQuestionString());
                //Add or replace
            }
            if (selectedIndex == lstQuestions.Items.Count - 1)
            {
                currentQuiz.addQuestion(newQ);
                lstQuestions.Items.Add("Add new question...");
            }
            else
            {
                currentQuiz.GetQuestions().RemoveAt(selectedIndex);
                currentQuiz.GetQuestions().Insert(selectedIndex, newQ);
            }
            currentQuiz.saveQuiz(txtModule.Text, txtDesc.Text, currentQuiz.GetQuestions());
            txtMarks.Text = currentQuiz.getTotalMarks().ToString();
            txtNumQs.Text = currentQuiz.getNumQuestions().ToString();
            lstQuestions.SelectedIndex = selectedIndex;
        }

        private void loadQuestionsIntoList()
        {
            lstQuestions.Items.Clear();
            foreach (var item in currentQuiz.GetQuestions())
            {
                lstQuestions.Items.Add((currentQuiz.GetQuestions().IndexOf(item) + 1) + ": " + item.getQuestionString());
            }
            lstQuestions.Items.Add("Add new question...");
        }

        private void refreshQuestionProperties()
        {
            int selectedIndex = lstQuestions.SelectedIndex;
            btnUpdateQ.Text = (selectedIndex == lstQuestions.Items.Count - 1) ? "Add Question" : "Update Question";
            //lstQuestions.SelectedIndex = selectedIndex;
            if (selectedIndex != lstQuestions.Items.Count-1)
            {
                btnDelete.Enabled = true;
                selectedQuestion = currentQuiz.GetQuestions().ElementAt(selectedIndex);
                txtQuestion.Text = selectedQuestion.getQuestionString();
                numQMarks.Value = selectedQuestion.marks;
                if (typeof(FreeFormQuestion) == selectedQuestion.GetType())
                {
                    FreeFormQuestion FreeFormQ = (FreeFormQuestion)selectedQuestion;
                    Debug.Print("FreeFormQuestion");
                    tabview.SelectedTab = tabFree;
                    numFreeMaxChar.Value = FreeFormQ.getMaxChar();
                }
                else if (typeof(TrueFalseQuestion) == selectedQuestion.GetType())
                {
                    TrueFalseQuestion TrueFalseQ = (TrueFalseQuestion)selectedQuestion;
                    Debug.Print("True false question");
                    tabview.SelectedTab = tabTF;
                    if (TrueFalseQ.getAnswer()) rdoTrue.Checked = true;
                    else rdoFalse.Checked = true;
                }
                else
                {
                    Debug.Print("Math Question not  yet implimented");
                }
            }
            else
            {
                btnDelete.Enabled = false;
            }
            txtMarks.Text = currentQuiz.getTotalMarks().ToString();
            txtNumQs.Text = currentQuiz.getNumQuestions().ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstQuestions.SelectedIndex;
            currentQuiz.removeQuestion(selectedIndex);
            lstQuestions.Items.RemoveAt(selectedIndex);
            loadQuestionsIntoList();
            currentQuiz.saveQuiz(txtModule.Text, txtDesc.Text, currentQuiz.GetQuestions());
            txtMarks.Text = currentQuiz.getTotalMarks().ToString();
            txtNumQs.Text = currentQuiz.getNumQuestions().ToString();
            lstQuestions.SelectedIndex = lstQuestions.Items.Count-1;
        }

        private void btnSaveQuiz_Click(object sender, EventArgs e)
        {
            currentQuiz.saveQuiz(txtModule.Text, txtDesc.Text, currentQuiz.GetQuestions());
            this.Close();
        }
    }
}
