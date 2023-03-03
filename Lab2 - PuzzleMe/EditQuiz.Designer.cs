namespace Lab2___PuzzleMe
{
    partial class EditQuiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabview = new System.Windows.Forms.TabControl();
            this.tabFree = new System.Windows.Forms.TabPage();
            this.numFreeMaxChar = new System.Windows.Forms.NumericUpDown();
            this.lblFreeMax = new System.Windows.Forms.Label();
            this.tabTF = new System.Windows.Forms.TabPage();
            this.grpTFAns = new System.Windows.Forms.GroupBox();
            this.rdoFalse = new System.Windows.Forms.RadioButton();
            this.rdoTrue = new System.Windows.Forms.RadioButton();
            this.lblTFQuestion = new System.Windows.Forms.Label();
            this.tabMulti = new System.Windows.Forms.TabPage();
            this.grpMultiAnswer = new System.Windows.Forms.GroupBox();
            this.rdoMultiFour = new System.Windows.Forms.RadioButton();
            this.rdoMultiThree = new System.Windows.Forms.RadioButton();
            this.rdoMultiTwo = new System.Windows.Forms.RadioButton();
            this.rdoMultiOne = new System.Windows.Forms.RadioButton();
            this.txtMultiFour = new System.Windows.Forms.TextBox();
            this.txtMultiThree = new System.Windows.Forms.TextBox();
            this.txtMultiTwo = new System.Windows.Forms.TextBox();
            this.txtMultiOne = new System.Windows.Forms.TextBox();
            this.tabMath = new System.Windows.Forms.TabPage();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnSaveQuiz = new System.Windows.Forms.Button();
            this.lstQuestions = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalMarks = new System.Windows.Forms.Label();
            this.lblNumQs = new System.Windows.Forms.Label();
            this.txtModule = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtInstruction = new System.Windows.Forms.TextBox();
            this.txtMarks = new System.Windows.Forms.TextBox();
            this.txtNumQs = new System.Windows.Forms.TextBox();
            this.btnUpdateQ = new System.Windows.Forms.Button();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblQMarks = new System.Windows.Forms.Label();
            this.numQMarks = new System.Windows.Forms.NumericUpDown();
            this.tabview.SuspendLayout();
            this.tabFree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFreeMaxChar)).BeginInit();
            this.tabTF.SuspendLayout();
            this.grpTFAns.SuspendLayout();
            this.tabMulti.SuspendLayout();
            this.grpMultiAnswer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQMarks)).BeginInit();
            this.SuspendLayout();
            // 
            // tabview
            // 
            this.tabview.Controls.Add(this.tabFree);
            this.tabview.Controls.Add(this.tabTF);
            this.tabview.Controls.Add(this.tabMulti);
            this.tabview.Controls.Add(this.tabMath);
            this.tabview.Location = new System.Drawing.Point(552, 483);
            this.tabview.Name = "tabview";
            this.tabview.SelectedIndex = 0;
            this.tabview.Size = new System.Drawing.Size(691, 313);
            this.tabview.TabIndex = 0;
            // 
            // tabFree
            // 
            this.tabFree.Controls.Add(this.numFreeMaxChar);
            this.tabFree.Controls.Add(this.lblFreeMax);
            this.tabFree.Location = new System.Drawing.Point(8, 46);
            this.tabFree.Name = "tabFree";
            this.tabFree.Padding = new System.Windows.Forms.Padding(3);
            this.tabFree.Size = new System.Drawing.Size(675, 259);
            this.tabFree.TabIndex = 0;
            this.tabFree.Text = "Free Form";
            this.tabFree.UseVisualStyleBackColor = true;
            // 
            // numFreeMaxChar
            // 
            this.numFreeMaxChar.Location = new System.Drawing.Point(312, 106);
            this.numFreeMaxChar.Name = "numFreeMaxChar";
            this.numFreeMaxChar.Size = new System.Drawing.Size(240, 39);
            this.numFreeMaxChar.TabIndex = 3;
            // 
            // lblFreeMax
            // 
            this.lblFreeMax.AutoSize = true;
            this.lblFreeMax.Location = new System.Drawing.Point(6, 108);
            this.lblFreeMax.Name = "lblFreeMax";
            this.lblFreeMax.Size = new System.Drawing.Size(296, 32);
            this.lblFreeMax.TabIndex = 2;
            this.lblFreeMax.Text = "Max characters for answer:";
            // 
            // tabTF
            // 
            this.tabTF.Controls.Add(this.grpTFAns);
            this.tabTF.Controls.Add(this.lblTFQuestion);
            this.tabTF.Location = new System.Drawing.Point(8, 46);
            this.tabTF.Name = "tabTF";
            this.tabTF.Padding = new System.Windows.Forms.Padding(3);
            this.tabTF.Size = new System.Drawing.Size(675, 259);
            this.tabTF.TabIndex = 1;
            this.tabTF.Text = "True/False";
            this.tabTF.UseVisualStyleBackColor = true;
            // 
            // grpTFAns
            // 
            this.grpTFAns.Controls.Add(this.rdoFalse);
            this.grpTFAns.Controls.Add(this.rdoTrue);
            this.grpTFAns.Location = new System.Drawing.Point(12, 21);
            this.grpTFAns.Name = "grpTFAns";
            this.grpTFAns.Size = new System.Drawing.Size(400, 200);
            this.grpTFAns.TabIndex = 3;
            this.grpTFAns.TabStop = false;
            this.grpTFAns.Text = "Answer";
            // 
            // rdoFalse
            // 
            this.rdoFalse.AutoSize = true;
            this.rdoFalse.Location = new System.Drawing.Point(6, 124);
            this.rdoFalse.Name = "rdoFalse";
            this.rdoFalse.Size = new System.Drawing.Size(97, 36);
            this.rdoFalse.TabIndex = 1;
            this.rdoFalse.TabStop = true;
            this.rdoFalse.Text = "False";
            this.rdoFalse.UseVisualStyleBackColor = true;
            // 
            // rdoTrue
            // 
            this.rdoTrue.AutoSize = true;
            this.rdoTrue.Location = new System.Drawing.Point(6, 63);
            this.rdoTrue.Name = "rdoTrue";
            this.rdoTrue.Size = new System.Drawing.Size(91, 36);
            this.rdoTrue.TabIndex = 0;
            this.rdoTrue.TabStop = true;
            this.rdoTrue.Text = "True";
            this.rdoTrue.UseVisualStyleBackColor = true;
            // 
            // lblTFQuestion
            // 
            this.lblTFQuestion.AutoSize = true;
            this.lblTFQuestion.Location = new System.Drawing.Point(6, 3);
            this.lblTFQuestion.Name = "lblTFQuestion";
            this.lblTFQuestion.Size = new System.Drawing.Size(0, 32);
            this.lblTFQuestion.TabIndex = 0;
            // 
            // tabMulti
            // 
            this.tabMulti.Controls.Add(this.grpMultiAnswer);
            this.tabMulti.Location = new System.Drawing.Point(8, 46);
            this.tabMulti.Name = "tabMulti";
            this.tabMulti.Padding = new System.Windows.Forms.Padding(3);
            this.tabMulti.Size = new System.Drawing.Size(675, 259);
            this.tabMulti.TabIndex = 2;
            this.tabMulti.Text = "Multi Choice";
            this.tabMulti.UseVisualStyleBackColor = true;
            // 
            // grpMultiAnswer
            // 
            this.grpMultiAnswer.Controls.Add(this.rdoMultiFour);
            this.grpMultiAnswer.Controls.Add(this.rdoMultiThree);
            this.grpMultiAnswer.Controls.Add(this.rdoMultiTwo);
            this.grpMultiAnswer.Controls.Add(this.rdoMultiOne);
            this.grpMultiAnswer.Controls.Add(this.txtMultiFour);
            this.grpMultiAnswer.Controls.Add(this.txtMultiThree);
            this.grpMultiAnswer.Controls.Add(this.txtMultiTwo);
            this.grpMultiAnswer.Controls.Add(this.txtMultiOne);
            this.grpMultiAnswer.Location = new System.Drawing.Point(6, 10);
            this.grpMultiAnswer.Name = "grpMultiAnswer";
            this.grpMultiAnswer.Size = new System.Drawing.Size(631, 241);
            this.grpMultiAnswer.TabIndex = 5;
            this.grpMultiAnswer.TabStop = false;
            this.grpMultiAnswer.Text = "Answer (Select correct reponse)";
            // 
            // rdoMultiFour
            // 
            this.rdoMultiFour.AutoSize = true;
            this.rdoMultiFour.Location = new System.Drawing.Point(16, 200);
            this.rdoMultiFour.Name = "rdoMultiFour";
            this.rdoMultiFour.Size = new System.Drawing.Size(27, 26);
            this.rdoMultiFour.TabIndex = 4;
            this.rdoMultiFour.TabStop = true;
            this.rdoMultiFour.UseVisualStyleBackColor = true;
            // 
            // rdoMultiThree
            // 
            this.rdoMultiThree.AutoSize = true;
            this.rdoMultiThree.Location = new System.Drawing.Point(16, 148);
            this.rdoMultiThree.Name = "rdoMultiThree";
            this.rdoMultiThree.Size = new System.Drawing.Size(27, 26);
            this.rdoMultiThree.TabIndex = 3;
            this.rdoMultiThree.TabStop = true;
            this.rdoMultiThree.UseVisualStyleBackColor = true;
            // 
            // rdoMultiTwo
            // 
            this.rdoMultiTwo.AutoSize = true;
            this.rdoMultiTwo.Location = new System.Drawing.Point(16, 96);
            this.rdoMultiTwo.Name = "rdoMultiTwo";
            this.rdoMultiTwo.Size = new System.Drawing.Size(27, 26);
            this.rdoMultiTwo.TabIndex = 2;
            this.rdoMultiTwo.TabStop = true;
            this.rdoMultiTwo.UseVisualStyleBackColor = true;
            // 
            // rdoMultiOne
            // 
            this.rdoMultiOne.AutoSize = true;
            this.rdoMultiOne.Location = new System.Drawing.Point(16, 44);
            this.rdoMultiOne.Name = "rdoMultiOne";
            this.rdoMultiOne.Size = new System.Drawing.Size(27, 26);
            this.rdoMultiOne.TabIndex = 1;
            this.rdoMultiOne.TabStop = true;
            this.rdoMultiOne.UseVisualStyleBackColor = true;
            // 
            // txtMultiFour
            // 
            this.txtMultiFour.Location = new System.Drawing.Point(62, 194);
            this.txtMultiFour.Name = "txtMultiFour";
            this.txtMultiFour.Size = new System.Drawing.Size(563, 39);
            this.txtMultiFour.TabIndex = 0;
            // 
            // txtMultiThree
            // 
            this.txtMultiThree.Location = new System.Drawing.Point(62, 142);
            this.txtMultiThree.Name = "txtMultiThree";
            this.txtMultiThree.Size = new System.Drawing.Size(563, 39);
            this.txtMultiThree.TabIndex = 0;
            // 
            // txtMultiTwo
            // 
            this.txtMultiTwo.Location = new System.Drawing.Point(62, 90);
            this.txtMultiTwo.Name = "txtMultiTwo";
            this.txtMultiTwo.Size = new System.Drawing.Size(563, 39);
            this.txtMultiTwo.TabIndex = 0;
            // 
            // txtMultiOne
            // 
            this.txtMultiOne.Location = new System.Drawing.Point(62, 38);
            this.txtMultiOne.Name = "txtMultiOne";
            this.txtMultiOne.Size = new System.Drawing.Size(563, 39);
            this.txtMultiOne.TabIndex = 0;
            this.txtMultiOne.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tabMath
            // 
            this.tabMath.Location = new System.Drawing.Point(8, 46);
            this.tabMath.Name = "tabMath";
            this.tabMath.Size = new System.Drawing.Size(675, 259);
            this.tabMath.TabIndex = 3;
            this.tabMath.Text = "Math";
            this.tabMath.UseVisualStyleBackColor = true;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(552, 356);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(116, 32);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Question:";
            // 
            // btnSaveQuiz
            // 
            this.btnSaveQuiz.Location = new System.Drawing.Point(1037, 802);
            this.btnSaveQuiz.Name = "btnSaveQuiz";
            this.btnSaveQuiz.Size = new System.Drawing.Size(210, 46);
            this.btnSaveQuiz.TabIndex = 1;
            this.btnSaveQuiz.Text = "Save Quiz";
            this.btnSaveQuiz.UseVisualStyleBackColor = true;
            this.btnSaveQuiz.Click += new System.EventHandler(this.btnSaveQuiz_Click);
            // 
            // lstQuestions
            // 
            this.lstQuestions.FormattingEnabled = true;
            this.lstQuestions.ItemHeight = 32;
            this.lstQuestions.Location = new System.Drawing.Point(12, 12);
            this.lstQuestions.Name = "lstQuestions";
            this.lstQuestions.Size = new System.Drawing.Size(534, 836);
            this.lstQuestions.TabIndex = 2;
            this.lstQuestions.SelectedIndexChanged += new System.EventHandler(this.selectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(552, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Module:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(552, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Instructions:";
            // 
            // lblTotalMarks
            // 
            this.lblTotalMarks.AutoSize = true;
            this.lblTotalMarks.Location = new System.Drawing.Point(553, 68);
            this.lblTotalMarks.Name = "lblTotalMarks";
            this.lblTotalMarks.Size = new System.Drawing.Size(141, 32);
            this.lblTotalMarks.TabIndex = 6;
            this.lblTotalMarks.Text = "Total Marks:";
            // 
            // lblNumQs
            // 
            this.lblNumQs.AutoSize = true;
            this.lblNumQs.Location = new System.Drawing.Point(918, 68);
            this.lblNumQs.Name = "lblNumQs";
            this.lblNumQs.Size = new System.Drawing.Size(120, 32);
            this.lblNumQs.TabIndex = 7;
            this.lblNumQs.Text = "No. of Qs:";
            // 
            // txtModule
            // 
            this.txtModule.Location = new System.Drawing.Point(660, 9);
            this.txtModule.Name = "txtModule";
            this.txtModule.Size = new System.Drawing.Size(575, 39);
            this.txtModule.TabIndex = 8;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(552, 144);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(683, 78);
            this.txtDesc.TabIndex = 9;
            // 
            // txtInstruction
            // 
            this.txtInstruction.Location = new System.Drawing.Point(552, 265);
            this.txtInstruction.Multiline = true;
            this.txtInstruction.Name = "txtInstruction";
            this.txtInstruction.Size = new System.Drawing.Size(683, 78);
            this.txtInstruction.TabIndex = 10;
            // 
            // txtMarks
            // 
            this.txtMarks.Enabled = false;
            this.txtMarks.Location = new System.Drawing.Point(700, 65);
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.Size = new System.Drawing.Size(200, 39);
            this.txtMarks.TabIndex = 11;
            // 
            // txtNumQs
            // 
            this.txtNumQs.Enabled = false;
            this.txtNumQs.Location = new System.Drawing.Point(1044, 65);
            this.txtNumQs.Name = "txtNumQs";
            this.txtNumQs.Size = new System.Drawing.Size(191, 39);
            this.txtNumQs.TabIndex = 12;
            // 
            // btnUpdateQ
            // 
            this.btnUpdateQ.Location = new System.Drawing.Point(560, 802);
            this.btnUpdateQ.Name = "btnUpdateQ";
            this.btnUpdateQ.Size = new System.Drawing.Size(210, 46);
            this.btnUpdateQ.TabIndex = 13;
            this.btnUpdateQ.Text = "Update Question";
            this.btnUpdateQ.UseVisualStyleBackColor = true;
            this.btnUpdateQ.Click += new System.EventHandler(this.btnUpdateQ_Click);
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(552, 391);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(683, 86);
            this.txtQuestion.TabIndex = 14;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(795, 802);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(210, 46);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete Question";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblQMarks
            // 
            this.lblQMarks.AutoSize = true;
            this.lblQMarks.Location = new System.Drawing.Point(1021, 349);
            this.lblQMarks.Name = "lblQMarks";
            this.lblQMarks.Size = new System.Drawing.Size(83, 32);
            this.lblQMarks.TabIndex = 0;
            this.lblQMarks.Text = "Marks:";
            // 
            // numQMarks
            // 
            this.numQMarks.Location = new System.Drawing.Point(1104, 350);
            this.numQMarks.Name = "numQMarks";
            this.numQMarks.Size = new System.Drawing.Size(131, 39);
            this.numQMarks.TabIndex = 16;
            // 
            // EditQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 862);
            this.Controls.Add(this.numQMarks);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.btnUpdateQ);
            this.Controls.Add(this.txtNumQs);
            this.Controls.Add(this.lblQMarks);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.txtMarks);
            this.Controls.Add(this.txtInstruction);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtModule);
            this.Controls.Add(this.lblNumQs);
            this.Controls.Add(this.lblTotalMarks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstQuestions);
            this.Controls.Add(this.btnSaveQuiz);
            this.Controls.Add(this.tabview);
            this.Name = "EditQuiz";
            this.Text = "EditQuiz";
            this.tabview.ResumeLayout(false);
            this.tabFree.ResumeLayout(false);
            this.tabFree.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFreeMaxChar)).EndInit();
            this.tabTF.ResumeLayout(false);
            this.tabTF.PerformLayout();
            this.grpTFAns.ResumeLayout(false);
            this.grpTFAns.PerformLayout();
            this.tabMulti.ResumeLayout(false);
            this.grpMultiAnswer.ResumeLayout(false);
            this.grpMultiAnswer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQMarks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabview;
        private TabPage tabFree;
        private NumericUpDown numFreeMaxChar;
        private Label lblFreeMax;
        private Label lblQuestion;
        private TabPage tabTF;
        private GroupBox grpTFAns;
        private RadioButton rdoFalse;
        private RadioButton rdoTrue;
        private Label lblTFQuestion;
        private TabPage tabMulti;
        private GroupBox grpMultiAnswer;
        private TextBox txtMultiFour;
        private TextBox txtMultiThree;
        private TextBox txtMultiTwo;
        private TextBox txtMultiOne;
        private TabPage tabMath;
        private Button btnSaveQuiz;
        private ListBox lstQuestions;
        private RadioButton rdoMultiFour;
        private RadioButton rdoMultiThree;
        private RadioButton rdoMultiTwo;
        private RadioButton rdoMultiOne;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblTotalMarks;
        private Label lblNumQs;
        private TextBox txtModule;
        private TextBox txtDesc;
        private TextBox txtInstruction;
        private TextBox txtMarks;
        private TextBox txtNumQs;
        private Button btnUpdateQ;
        private TextBox txtQuestion;
        private Button btnDelete;
        private Label lblQMarks;
        private NumericUpDown numQMarks;
    }
}