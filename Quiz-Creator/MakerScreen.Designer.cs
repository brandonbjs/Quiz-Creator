namespace Quiz_Creator
{
    partial class MakerScreen
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
            this.listboxQuestions = new System.Windows.Forms.ListBox();
            this.textboxTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddQuestion = new System.Windows.Forms.Button();
            this.buttonRemoveQuestion = new System.Windows.Forms.Button();
            this.buttonSaveQuiz = new System.Windows.Forms.Button();
            this.textboxPromptEdit = new System.Windows.Forms.TextBox();
            this.labelPromptEdit = new System.Windows.Forms.Label();
            this.textboxAnswerEdit = new System.Windows.Forms.TextBox();
            this.labelAnswerEdit = new System.Windows.Forms.Label();
            this.tabControlQuestionType = new System.Windows.Forms.TabControl();
            this.tabPageFITB = new System.Windows.Forms.TabPage();
            this.labelFITB = new System.Windows.Forms.Label();
            this.tabPageMultipleChoice = new System.Windows.Forms.TabPage();
            this.labelMCInstruct = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxMC5 = new System.Windows.Forms.TextBox();
            this.textBoxMC4 = new System.Windows.Forms.TextBox();
            this.textBoxMC3 = new System.Windows.Forms.TextBox();
            this.textBoxMC2 = new System.Windows.Forms.TextBox();
            this.textBoxMC1 = new System.Windows.Forms.TextBox();
            this.radioButtonMC5 = new System.Windows.Forms.RadioButton();
            this.radioButtonMC4 = new System.Windows.Forms.RadioButton();
            this.radioButtonMC3 = new System.Windows.Forms.RadioButton();
            this.radioButtonMC1 = new System.Windows.Forms.RadioButton();
            this.radioButtonMC2 = new System.Windows.Forms.RadioButton();
            this.tabControlQuestionType.SuspendLayout();
            this.tabPageFITB.SuspendLayout();
            this.tabPageMultipleChoice.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listboxQuestions
            // 
            this.listboxQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxQuestions.FormattingEnabled = true;
            this.listboxQuestions.ItemHeight = 15;
            this.listboxQuestions.Location = new System.Drawing.Point(12, 93);
            this.listboxQuestions.Name = "listboxQuestions";
            this.listboxQuestions.Size = new System.Drawing.Size(267, 334);
            this.listboxQuestions.TabIndex = 0;
            this.listboxQuestions.SelectedIndexChanged += new System.EventHandler(this.listboxQuestions_SelectedIndexChanged);
            // 
            // textboxTitle
            // 
            this.textboxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxTitle.Location = new System.Drawing.Point(12, 32);
            this.textboxTitle.Name = "textboxTitle";
            this.textboxTitle.Size = new System.Drawing.Size(700, 22);
            this.textboxTitle.TabIndex = 1;
            this.textboxTitle.TextChanged += new System.EventHandler(this.textboxTitle_TextChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(38, 20);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Questions";
            // 
            // buttonAddQuestion
            // 
            this.buttonAddQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddQuestion.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonAddQuestion.Location = new System.Drawing.Point(12, 437);
            this.buttonAddQuestion.Name = "buttonAddQuestion";
            this.buttonAddQuestion.Size = new System.Drawing.Size(116, 38);
            this.buttonAddQuestion.TabIndex = 4;
            this.buttonAddQuestion.Text = "Add Question";
            this.buttonAddQuestion.UseVisualStyleBackColor = true;
            this.buttonAddQuestion.Click += new System.EventHandler(this.buttonAddQuestion_Click);
            // 
            // buttonRemoveQuestion
            // 
            this.buttonRemoveQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveQuestion.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonRemoveQuestion.Location = new System.Drawing.Point(134, 437);
            this.buttonRemoveQuestion.Name = "buttonRemoveQuestion";
            this.buttonRemoveQuestion.Size = new System.Drawing.Size(145, 38);
            this.buttonRemoveQuestion.TabIndex = 5;
            this.buttonRemoveQuestion.Text = "Remove Question";
            this.buttonRemoveQuestion.UseVisualStyleBackColor = true;
            this.buttonRemoveQuestion.Click += new System.EventHandler(this.buttonRemoveQuestion_Click);
            // 
            // buttonSaveQuiz
            // 
            this.buttonSaveQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveQuiz.Location = new System.Drawing.Point(718, 27);
            this.buttonSaveQuiz.Name = "buttonSaveQuiz";
            this.buttonSaveQuiz.Size = new System.Drawing.Size(97, 30);
            this.buttonSaveQuiz.TabIndex = 6;
            this.buttonSaveQuiz.Text = "Save Quiz";
            this.buttonSaveQuiz.UseVisualStyleBackColor = true;
            this.buttonSaveQuiz.Click += new System.EventHandler(this.buttonSaveQuiz_Click);
            // 
            // textboxPromptEdit
            // 
            this.textboxPromptEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxPromptEdit.Location = new System.Drawing.Point(301, 93);
            this.textboxPromptEdit.Multiline = true;
            this.textboxPromptEdit.Name = "textboxPromptEdit";
            this.textboxPromptEdit.Size = new System.Drawing.Size(514, 85);
            this.textboxPromptEdit.TabIndex = 7;
            this.textboxPromptEdit.TextChanged += new System.EventHandler(this.textboxPromptEdit_TextChanged);
            // 
            // labelPromptEdit
            // 
            this.labelPromptEdit.AutoSize = true;
            this.labelPromptEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPromptEdit.Location = new System.Drawing.Point(297, 70);
            this.labelPromptEdit.Name = "labelPromptEdit";
            this.labelPromptEdit.Size = new System.Drawing.Size(172, 20);
            this.labelPromptEdit.TabIndex = 8;
            this.labelPromptEdit.Text = "Type the Prompt Here. ";
            // 
            // textboxAnswerEdit
            // 
            this.textboxAnswerEdit.Location = new System.Drawing.Point(20, 90);
            this.textboxAnswerEdit.Name = "textboxAnswerEdit";
            this.textboxAnswerEdit.Size = new System.Drawing.Size(475, 26);
            this.textboxAnswerEdit.TabIndex = 9;
            this.textboxAnswerEdit.TextChanged += new System.EventHandler(this.textboxAnswerEdit_TextChanged);
            this.textboxAnswerEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxAnswerEdit_KeyPress);
            // 
            // labelAnswerEdit
            // 
            this.labelAnswerEdit.AutoSize = true;
            this.labelAnswerEdit.Location = new System.Drawing.Point(16, 67);
            this.labelAnswerEdit.Name = "labelAnswerEdit";
            this.labelAnswerEdit.Size = new System.Drawing.Size(170, 20);
            this.labelAnswerEdit.TabIndex = 10;
            this.labelAnswerEdit.Text = "Type the Answer Here:";
            // 
            // tabControlQuestionType
            // 
            this.tabControlQuestionType.Controls.Add(this.tabPageFITB);
            this.tabControlQuestionType.Controls.Add(this.tabPageMultipleChoice);
            this.tabControlQuestionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlQuestionType.ItemSize = new System.Drawing.Size(100, 36);
            this.tabControlQuestionType.Location = new System.Drawing.Point(301, 196);
            this.tabControlQuestionType.Name = "tabControlQuestionType";
            this.tabControlQuestionType.SelectedIndex = 0;
            this.tabControlQuestionType.Size = new System.Drawing.Size(518, 279);
            this.tabControlQuestionType.TabIndex = 11;
            this.tabControlQuestionType.SelectedIndexChanged += new System.EventHandler(this.tabControlQuestionType_SelectedIndexChanged);
            // 
            // tabPageFITB
            // 
            this.tabPageFITB.Controls.Add(this.labelFITB);
            this.tabPageFITB.Controls.Add(this.labelAnswerEdit);
            this.tabPageFITB.Controls.Add(this.textboxAnswerEdit);
            this.tabPageFITB.Location = new System.Drawing.Point(4, 40);
            this.tabPageFITB.Name = "tabPageFITB";
            this.tabPageFITB.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFITB.Size = new System.Drawing.Size(510, 235);
            this.tabPageFITB.TabIndex = 0;
            this.tabPageFITB.Text = "Fill in the Blank";
            this.tabPageFITB.UseVisualStyleBackColor = true;
            // 
            // labelFITB
            // 
            this.labelFITB.AutoSize = true;
            this.labelFITB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFITB.Location = new System.Drawing.Point(17, 119);
            this.labelFITB.Name = "labelFITB";
            this.labelFITB.Size = new System.Drawing.Size(273, 13);
            this.labelFITB.TabIndex = 11;
            this.labelFITB.Text = "This answer must be typed exactly when taking the quiz.";
            // 
            // tabPageMultipleChoice
            // 
            this.tabPageMultipleChoice.Controls.Add(this.labelMCInstruct);
            this.tabPageMultipleChoice.Controls.Add(this.groupBox1);
            this.tabPageMultipleChoice.Location = new System.Drawing.Point(4, 40);
            this.tabPageMultipleChoice.Name = "tabPageMultipleChoice";
            this.tabPageMultipleChoice.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMultipleChoice.Size = new System.Drawing.Size(510, 235);
            this.tabPageMultipleChoice.TabIndex = 1;
            this.tabPageMultipleChoice.Text = "Multiple Choice";
            this.tabPageMultipleChoice.UseVisualStyleBackColor = true;
            // 
            // labelMCInstruct
            // 
            this.labelMCInstruct.AutoSize = true;
            this.labelMCInstruct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMCInstruct.Location = new System.Drawing.Point(18, 210);
            this.labelMCInstruct.Name = "labelMCInstruct";
            this.labelMCInstruct.Size = new System.Drawing.Size(471, 13);
            this.labelMCInstruct.TabIndex = 3;
            this.labelMCInstruct.Text = "Enter 2 to 5 choices, and bubble in the correct choice on the left.  Blank choice" +
    "s will be discarded.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxMC5);
            this.groupBox1.Controls.Add(this.textBoxMC4);
            this.groupBox1.Controls.Add(this.textBoxMC3);
            this.groupBox1.Controls.Add(this.textBoxMC2);
            this.groupBox1.Controls.Add(this.textBoxMC1);
            this.groupBox1.Controls.Add(this.radioButtonMC5);
            this.groupBox1.Controls.Add(this.radioButtonMC4);
            this.groupBox1.Controls.Add(this.radioButtonMC3);
            this.groupBox1.Controls.Add(this.radioButtonMC1);
            this.groupBox1.Controls.Add(this.radioButtonMC2);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 191);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choices";
            // 
            // textBoxMC5
            // 
            this.textBoxMC5.Location = new System.Drawing.Point(26, 151);
            this.textBoxMC5.Name = "textBoxMC5";
            this.textBoxMC5.Size = new System.Drawing.Size(466, 26);
            this.textBoxMC5.TabIndex = 9;
            this.textBoxMC5.TextChanged += new System.EventHandler(this.textBoxMC5_TextChanged);
            // 
            // textBoxMC4
            // 
            this.textBoxMC4.Location = new System.Drawing.Point(26, 119);
            this.textBoxMC4.Name = "textBoxMC4";
            this.textBoxMC4.Size = new System.Drawing.Size(466, 26);
            this.textBoxMC4.TabIndex = 8;
            this.textBoxMC4.TextChanged += new System.EventHandler(this.textBoxMC4_TextChanged);
            // 
            // textBoxMC3
            // 
            this.textBoxMC3.Location = new System.Drawing.Point(26, 87);
            this.textBoxMC3.Name = "textBoxMC3";
            this.textBoxMC3.Size = new System.Drawing.Size(466, 26);
            this.textBoxMC3.TabIndex = 7;
            this.textBoxMC3.TextChanged += new System.EventHandler(this.textBoxMC3_TextChanged);
            // 
            // textBoxMC2
            // 
            this.textBoxMC2.Location = new System.Drawing.Point(26, 55);
            this.textBoxMC2.Name = "textBoxMC2";
            this.textBoxMC2.Size = new System.Drawing.Size(466, 26);
            this.textBoxMC2.TabIndex = 6;
            this.textBoxMC2.Text = "False";
            this.textBoxMC2.TextChanged += new System.EventHandler(this.textBoxMC2_TextChanged);
            // 
            // textBoxMC1
            // 
            this.textBoxMC1.Location = new System.Drawing.Point(26, 23);
            this.textBoxMC1.Name = "textBoxMC1";
            this.textBoxMC1.Size = new System.Drawing.Size(466, 26);
            this.textBoxMC1.TabIndex = 5;
            this.textBoxMC1.Text = "True";
            this.textBoxMC1.TextChanged += new System.EventHandler(this.textBoxMC1_TextChanged);
            // 
            // radioButtonMC5
            // 
            this.radioButtonMC5.AutoSize = true;
            this.radioButtonMC5.Location = new System.Drawing.Point(6, 158);
            this.radioButtonMC5.Name = "radioButtonMC5";
            this.radioButtonMC5.Size = new System.Drawing.Size(14, 13);
            this.radioButtonMC5.TabIndex = 4;
            this.radioButtonMC5.UseVisualStyleBackColor = true;
            this.radioButtonMC5.CheckedChanged += new System.EventHandler(this.radioButtonMC5_CheckedChanged);
            // 
            // radioButtonMC4
            // 
            this.radioButtonMC4.AutoSize = true;
            this.radioButtonMC4.Location = new System.Drawing.Point(6, 126);
            this.radioButtonMC4.Name = "radioButtonMC4";
            this.radioButtonMC4.Size = new System.Drawing.Size(14, 13);
            this.radioButtonMC4.TabIndex = 3;
            this.radioButtonMC4.UseVisualStyleBackColor = true;
            this.radioButtonMC4.CheckedChanged += new System.EventHandler(this.radioButtonMC4_CheckedChanged);
            // 
            // radioButtonMC3
            // 
            this.radioButtonMC3.AutoSize = true;
            this.radioButtonMC3.Location = new System.Drawing.Point(6, 94);
            this.radioButtonMC3.Name = "radioButtonMC3";
            this.radioButtonMC3.Size = new System.Drawing.Size(14, 13);
            this.radioButtonMC3.TabIndex = 2;
            this.radioButtonMC3.UseVisualStyleBackColor = true;
            this.radioButtonMC3.CheckedChanged += new System.EventHandler(this.radioButtonMC3_CheckedChanged);
            // 
            // radioButtonMC1
            // 
            this.radioButtonMC1.AutoSize = true;
            this.radioButtonMC1.Checked = true;
            this.radioButtonMC1.Location = new System.Drawing.Point(6, 30);
            this.radioButtonMC1.Name = "radioButtonMC1";
            this.radioButtonMC1.Size = new System.Drawing.Size(14, 13);
            this.radioButtonMC1.TabIndex = 0;
            this.radioButtonMC1.TabStop = true;
            this.radioButtonMC1.UseVisualStyleBackColor = true;
            this.radioButtonMC1.CheckedChanged += new System.EventHandler(this.radioButtonMC1_CheckedChanged);
            // 
            // radioButtonMC2
            // 
            this.radioButtonMC2.AutoSize = true;
            this.radioButtonMC2.Location = new System.Drawing.Point(6, 62);
            this.radioButtonMC2.Name = "radioButtonMC2";
            this.radioButtonMC2.Size = new System.Drawing.Size(14, 13);
            this.radioButtonMC2.TabIndex = 1;
            this.radioButtonMC2.UseVisualStyleBackColor = true;
            this.radioButtonMC2.CheckedChanged += new System.EventHandler(this.radioButtonMC2_CheckedChanged);
            // 
            // MakerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 487);
            this.Controls.Add(this.textboxPromptEdit);
            this.Controls.Add(this.tabControlQuestionType);
            this.Controls.Add(this.labelPromptEdit);
            this.Controls.Add(this.buttonSaveQuiz);
            this.Controls.Add(this.buttonRemoveQuestion);
            this.Controls.Add(this.buttonAddQuestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textboxTitle);
            this.Controls.Add(this.listboxQuestions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MakerScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Make a Quiz";
            this.tabControlQuestionType.ResumeLayout(false);
            this.tabPageFITB.ResumeLayout(false);
            this.tabPageFITB.PerformLayout();
            this.tabPageMultipleChoice.ResumeLayout(false);
            this.tabPageMultipleChoice.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listboxQuestions;
        private System.Windows.Forms.TextBox textboxTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddQuestion;
        private System.Windows.Forms.Button buttonRemoveQuestion;
        private System.Windows.Forms.Button buttonSaveQuiz;
        private System.Windows.Forms.TextBox textboxPromptEdit;
        private System.Windows.Forms.Label labelPromptEdit;
        private System.Windows.Forms.TextBox textboxAnswerEdit;
        private System.Windows.Forms.Label labelAnswerEdit;
        private System.Windows.Forms.TabControl tabControlQuestionType;
        private System.Windows.Forms.TabPage tabPageFITB;
        private System.Windows.Forms.TabPage tabPageMultipleChoice;
        private System.Windows.Forms.Label labelFITB;
        private System.Windows.Forms.RadioButton radioButtonMC2;
        private System.Windows.Forms.RadioButton radioButtonMC1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxMC5;
        private System.Windows.Forms.TextBox textBoxMC4;
        private System.Windows.Forms.TextBox textBoxMC3;
        private System.Windows.Forms.TextBox textBoxMC2;
        private System.Windows.Forms.TextBox textBoxMC1;
        private System.Windows.Forms.RadioButton radioButtonMC5;
        private System.Windows.Forms.RadioButton radioButtonMC4;
        private System.Windows.Forms.RadioButton radioButtonMC3;
        private System.Windows.Forms.Label labelMCInstruct;
    }
}