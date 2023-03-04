using System.Diagnostics;

namespace Lab2___PuzzleMe
{
    public partial class Form1 : Form
    {
        public Quiz quizOne;
        public Quiz quizTwo;
        public List<Quiz> quizList = new List<Quiz>();
        public Quiz selectedQuiz;
        public Form1()
        {
            InitializeComponent();
            generateQuiz();
            quizList.Add(quizOne);
            quizList.Add((quizTwo));
            foreach (var item in quizList)
            {
                lstQuizSelection.Items.Add(item.getTitle());
            }
            lstQuizSelection.SelectedIndex = 0;
            selectedQuiz = quizList.ElementAt(0);
            txtModule.Text = selectedQuiz.getModule();
            txtDesc.Text = selectedQuiz.getDescription();
            txtMarks.Text = selectedQuiz.getTotalMarks().ToString();
            txtNoOfQs.Text = selectedQuiz.getNumQuestions().ToString();
        }

        public void generateQuiz()
        {
            quizOne = new Quiz("Software Dev", "Something, something UML");
            Question q1 = new TrueFalseQuestion("True or false, cats are cats", 2, true);
            Question q2 = new TrueFalseQuestion("Spins is the king", 2, false);
            quizOne.addQuestion(q1);
            quizOne.addQuestion(q2);
            quizTwo = new Quiz("Testing", "blah blah bullshit");
            q1 = new TrueFalseQuestion("True or false, cats are cats", 2, true);
            q2 = new TrueFalseQuestion("Spins is the king", 2, false);
            quizTwo.addQuestion(q1);
            quizTwo.addQuestion(q2);
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void selectionChanged(object sender, EventArgs e)
        {
            Debug.Print("Selection changed! " + lstQuizSelection.SelectedIndex);
            int selectedIndex = lstQuizSelection.SelectedIndex;
            selectedQuiz = quizList.ElementAt(selectedIndex);
            txtModule.Text = selectedQuiz.getModule();
            txtDesc.Text = selectedQuiz.getDescription();
            txtMarks.Text = selectedQuiz.getTotalMarks().ToString();
            txtNoOfQs.Text = selectedQuiz.getNumQuestions().ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditQuizController edit = new EditQuizController(selectedQuiz);
            //edit.ShowDialog();
        }
    }
}