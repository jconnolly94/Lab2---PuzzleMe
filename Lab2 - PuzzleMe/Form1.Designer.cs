namespace Lab2___PuzzleMe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstQuizSelection = new System.Windows.Forms.ListBox();
            this.lblModule = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblInstruct = new System.Windows.Forms.Label();
            this.lblNoQs = new System.Windows.Forms.Label();
            this.lblMarks = new System.Windows.Forms.Label();
            this.txtModule = new System.Windows.Forms.TextBox();
            this.lblTopTxt = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtInstruct = new System.Windows.Forms.TextBox();
            this.txtNoOfQs = new System.Windows.Forms.TextBox();
            this.txtMarks = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstQuizSelection
            // 
            this.lstQuizSelection.FormattingEnabled = true;
            this.lstQuizSelection.ItemHeight = 32;
            this.lstQuizSelection.Location = new System.Drawing.Point(12, 85);
            this.lstQuizSelection.Name = "lstQuizSelection";
            this.lstQuizSelection.Size = new System.Drawing.Size(365, 516);
            this.lstQuizSelection.TabIndex = 0;
            this.lstQuizSelection.SelectedIndexChanged += new System.EventHandler(this.selectionChanged);
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.Location = new System.Drawing.Point(383, 85);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(102, 32);
            this.lblModule.TabIndex = 1;
            this.lblModule.Text = "Module:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(383, 156);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(140, 32);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Description:";
            // 
            // lblInstruct
            // 
            this.lblInstruct.AutoSize = true;
            this.lblInstruct.Location = new System.Drawing.Point(384, 378);
            this.lblInstruct.Name = "lblInstruct";
            this.lblInstruct.Size = new System.Drawing.Size(142, 32);
            this.lblInstruct.TabIndex = 3;
            this.lblInstruct.Text = "Instructions:";
            // 
            // lblNoQs
            // 
            this.lblNoQs.AutoSize = true;
            this.lblNoQs.Location = new System.Drawing.Point(394, 601);
            this.lblNoQs.Name = "lblNoQs";
            this.lblNoQs.Size = new System.Drawing.Size(120, 32);
            this.lblNoQs.TabIndex = 4;
            this.lblNoQs.Text = "No. of Qs:";
            // 
            // lblMarks
            // 
            this.lblMarks.AutoSize = true;
            this.lblMarks.Location = new System.Drawing.Point(394, 649);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(141, 32);
            this.lblMarks.TabIndex = 5;
            this.lblMarks.Text = "Total Marks:";
            // 
            // txtModule
            // 
            this.txtModule.Enabled = false;
            this.txtModule.Location = new System.Drawing.Point(491, 82);
            this.txtModule.Name = "txtModule";
            this.txtModule.Size = new System.Drawing.Size(271, 39);
            this.txtModule.TabIndex = 6;
            // 
            // lblTopTxt
            // 
            this.lblTopTxt.AutoSize = true;
            this.lblTopTxt.Location = new System.Drawing.Point(12, 50);
            this.lblTopTxt.Name = "lblTopTxt";
            this.lblTopTxt.Size = new System.Drawing.Size(225, 32);
            this.lblTopTxt.TabIndex = 7;
            this.lblTopTxt.Text = "Please select a quiz:";
            // 
            // txtDesc
            // 
            this.txtDesc.Enabled = false;
            this.txtDesc.Location = new System.Drawing.Point(394, 191);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(368, 169);
            this.txtDesc.TabIndex = 8;
            this.txtDesc.TextChanged += new System.EventHandler(this.txtDesc_TextChanged);
            // 
            // txtInstruct
            // 
            this.txtInstruct.Enabled = false;
            this.txtInstruct.Location = new System.Drawing.Point(394, 413);
            this.txtInstruct.Multiline = true;
            this.txtInstruct.Name = "txtInstruct";
            this.txtInstruct.Size = new System.Drawing.Size(368, 169);
            this.txtInstruct.TabIndex = 9;
            // 
            // txtNoOfQs
            // 
            this.txtNoOfQs.Enabled = false;
            this.txtNoOfQs.Location = new System.Drawing.Point(562, 598);
            this.txtNoOfQs.Name = "txtNoOfQs";
            this.txtNoOfQs.Size = new System.Drawing.Size(200, 39);
            this.txtNoOfQs.TabIndex = 10;
            // 
            // txtMarks
            // 
            this.txtMarks.Enabled = false;
            this.txtMarks.Location = new System.Drawing.Point(562, 646);
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.Size = new System.Drawing.Size(200, 39);
            this.txtMarks.TabIndex = 11;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(12, 642);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(150, 46);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit Quiz";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(227, 642);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 46);
            this.button2.TabIndex = 13;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 729);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtMarks);
            this.Controls.Add(this.txtNoOfQs);
            this.Controls.Add(this.txtInstruct);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblTopTxt);
            this.Controls.Add(this.txtModule);
            this.Controls.Add(this.lblMarks);
            this.Controls.Add(this.lblNoQs);
            this.Controls.Add(this.lblInstruct);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblModule);
            this.Controls.Add(this.lstQuizSelection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstQuizSelection;
        private Label lblModule;
        private Label lblDesc;
        private Label lblInstruct;
        private Label lblNoQs;
        private Label lblMarks;
        private TextBox txtModule;
        private Label lblTopTxt;
        private TextBox txtDesc;
        private TextBox txtInstruct;
        private TextBox txtNoOfQs;
        private TextBox txtMarks;
        private Button btnEdit;
        private Button button2;
    }
}