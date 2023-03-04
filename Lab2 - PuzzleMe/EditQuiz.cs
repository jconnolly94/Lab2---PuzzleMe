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
    // View
    public partial class EditQuiz : Form
    {
        //Quiz currentQuiz;
        //Question selectedQuestion;
        EditQuizController controller;
        public EditQuiz(EditQuizController controller)
        {
            InitializeComponent();
            this.controller = controller;
            //this.currentQuiz = currentQuiz;
            //this.controller = new EditQuizController(this.currentQuiz);
            //txtModule.Text = currentQuiz.getModule();
            //txtDesc.Text = currentQuiz.getDescription();
            //txtMarks.Text = currentQuiz.getTotalMarks().ToString();
            //txtNumQs.Text = currentQuiz.getNumQuestions().ToString();
            //this.controller.displayQuiz(this);
            loadQuestionsIntoList();
            lstQuestions.SelectedIndex = lstQuestions.Items.Count-1;
            refreshQuestionProperties();
        }

        private void selectionChanged(object sender, EventArgs e)
        {
            //txtMarks.Text = currentQuiz.getTotalMarks().ToString();
            //txtNumQs.Text = currentQuiz.getNumQuestions().ToString();
            if (lstQuestions.SelectedIndex != -1)
                refreshQuestionProperties();
            tabview.SelectedIndex = controller.setupTabForQuestion(this, lstQuestions.SelectedIndex);
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateQ_Click(object sender, EventArgs e)
        {
            int selectedQuestion = lstQuestions.SelectedIndex;
            int selectedType = tabview.SelectedIndex;
            switch (selectedType)
            {
                case 0:
                    controller.updateFreeFormQuestion(selectedQuestion, txtQuestion.Text, (int)numQMarks.Value, (int)numFreeMaxChar.Value);
                    break;
                case 1:
                    controller.updateTFQuestion(selectedQuestion, txtQuestion.Text, (int)numQMarks.Value, rdoTrue.Checked);
                    break;
                case 2:
                    Dictionary<String, bool> answerSet = new Dictionary<String, bool>();
                    answerSet.Add(txtMultiOne.Text, rdoMultiOne.Checked);
                    answerSet.Add(txtMultiTwo.Text, rdoMultiTwo.Checked);
                    answerSet.Add(txtMultiThree.Text, rdoMultiThree.Checked);
                    answerSet.Add(txtMultiFour.Text, rdoMultiFour.Checked);
                    controller.updateMultiQuestion(selectedQuestion, txtQuestion.Text, (int)numQMarks.Value, answerSet);
                    break;
                default:
                    break;
            }
            controller.displayQuiz();
            loadQuestionsIntoList();
            lstQuestions.SelectedIndex = lstQuestions.Items.Count - 1;
            // Create new Question
            //Question newQ;
            //if (tabview.SelectedTab == tabFree)
            //{
            //    newQ = new FreeFormQuestion(txtQuestion.Text, (int)numQMarks.Value, (int)numFreeMaxChar.Value);
            //}
            //else if (tabview.SelectedTab == tabTF)
            //{
            //    newQ = new TrueFalseQuestion(txtQuestion.Text, (int)numQMarks.Value, rdoTrue.Checked);
            //}
            //else if (tabview.SelectedTab != tabMulti)
            //{
            //    Dictionary<String, bool> answerSet = new Dictionary<String, bool>();
            //    answerSet.Add(txtMultiOne.Text, rdoMultiOne.Checked);
            //    answerSet.Add(txtMultiTwo.Text, rdoMultiTwo.Checked);
            //    answerSet.Add(txtMultiThree.Text, rdoMultiThree.Checked);
            //    answerSet.Add(txtMultiFour.Text, rdoMultiFour.Checked);
            //    newQ = new MultiQuestion(txtQuestion.Text, (int)numQMarks.Value, answerSet);
            //}
            //else
            //{
            //    Debug.Print("Math: Not yet implemented!");
            //    newQ = new FreeFormQuestion(txtQuestion.Text, (int)numQMarks.Value, (int)numFreeMaxChar.Value);
            //}
            //if(selectedIndex == -1)
            //{
            //    lstQuestions.Items.Add(newQ.getQuestionString());
            //}
            //else
            //{
            //    lstQuestions.Items.RemoveAt(selectedIndex);
            //    lstQuestions.Items.Insert(selectedIndex, (selectedIndex + 1) + ": " + newQ.getQuestionString());
            //    //Add or replace
            //}
            //if (selectedIndex == lstQuestions.Items.Count - 1)
            //{
            //    currentQuiz.addQuestion(newQ);
            //    lstQuestions.Items.Add("Add new question...");
            //}
            //else
            //{
            //    currentQuiz.GetQuestions().RemoveAt(selectedIndex);
            //    currentQuiz.GetQuestions().Insert(selectedIndex, newQ);
            //}
            //currentQuiz.saveQuiz(txtModule.Text, txtDesc.Text, currentQuiz.GetQuestions());
            //txtMarks.Text = currentQuiz.getTotalMarks().ToString();
            //txtNumQs.Text = currentQuiz.getNumQuestions().ToString();
            //lstQuestions.SelectedIndex = selectedIndex;
        }

        private void loadQuestionsIntoList()
        {
            lstQuestions.Items.Clear();
            //foreach (var item in currentQuiz.GetQuestions())
            //{
            //    lstQuestions.Items.Add((currentQuiz.GetQuestions().IndexOf(item) + 1) + ": " + item.getQuestionString());
            //}
            
            lstQuestions.Items.AddRange(controller.getQuestionList().Select((q, i) => $"{i + 1}. {q}").ToArray());
            lstQuestions.Items.Add("Add new question...");
        }

        private void refreshQuestionProperties()
        {
            // View should update the appropriate  UI elements for the selection type.
            // Controller could have a method to get the type for current index. 
            
            int selectedIndex = lstQuestions.SelectedIndex;
            btnUpdateQ.Text = (selectedIndex == lstQuestions.Items.Count - 1) ? "Add Question" : "Update Question";
            //lstQuestions.SelectedIndex = selectedIndex;
            if (selectedIndex != lstQuestions.Items.Count-1)
            {
                btnDelete.Enabled = true;
                int selectedQuestion = controller.setupTabForQuestion(this, selectedIndex);
                tabview.SelectedIndex= selectedQuestion;
            }
            else
            {
                tabview.SelectedIndex = 0;
                txtQuestion.Text = "";
                numQMarks.Value = 0;
                numFreeMaxChar.Value = 0;
                btnDelete.Enabled = false;
            }
            txtMarks.Text = controller.getQuizMarks();
            txtNumQs.Text = controller.getQuizNumQuestions();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstQuestions.SelectedIndex;
            controller.removeQuestion(selectedIndex);
            //currentQuiz.removeQuestion(selectedIndex);
            lstQuestions.Items.RemoveAt(selectedIndex);
            loadQuestionsIntoList();
            controller.updateQuiz(txtModule.Text, txtDesc.Text);
            //currentQuiz.saveQuiz(txtModule.Text, txtDesc.Text, currentQuiz.GetQuestions());
            txtMarks.Text = controller.getQuizMarks();
            txtNumQs.Text = controller.getQuizNumQuestions();
            lstQuestions.SelectedIndex = lstQuestions.Items.Count-1;
        }

        private void btnSaveQuiz_Click(object sender, EventArgs e)
        {
            // May need to add questions here as they are not passed in updateQuiz method.
            controller.updateQuiz(txtModule.Text, txtDesc.Text);
            this.Close();
        }

        public void setUpFreeFormQuestion(string question, int marks, int max)
        {
            txtQuestion.Text = question;
            numQMarks.Value = marks;
            numFreeMaxChar.Value = max;
        }

        public void setUpTFQuestion(string question, int marks, bool ans)
        {
            txtQuestion.Text = question;
            numQMarks.Value = marks;
            rdoTrue.Checked = ans;
            rdoFalse.Checked = !ans;
        }

        public void setUpMultiQuestion(string question, int marks, Dictionary<string, bool> answerSet)
        {
            txtQuestion.Text = question;
            numQMarks.Value = marks;
            rdoMultiOne.Checked = answerSet.ElementAt(0).Value;
            txtMultiOne.Text = answerSet.ElementAt(0).Key;
            rdoMultiTwo.Checked = answerSet.ElementAt(1).Value;
            txtMultiTwo.Text = answerSet.ElementAt(1).Key;
            rdoMultiThree.Checked = answerSet.ElementAt(2).Value;
            txtMultiThree.Text = answerSet.ElementAt(2).Key;
            rdoMultiFour.Checked = answerSet.ElementAt(3).Value;
            txtMultiFour.Text = answerSet.ElementAt(3).Key;
        }
    }
}
