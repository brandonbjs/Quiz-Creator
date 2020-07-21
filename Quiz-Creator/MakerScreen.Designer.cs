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
            this.SuspendLayout();
            // 
            // listboxQuestions
            // 
            this.listboxQuestions.FormattingEnabled = true;
            this.listboxQuestions.Location = new System.Drawing.Point(12, 84);
            this.listboxQuestions.Name = "listboxQuestions";
            this.listboxQuestions.Size = new System.Drawing.Size(242, 316);
            this.listboxQuestions.TabIndex = 0;
            this.listboxQuestions.SelectedIndexChanged += new System.EventHandler(this.listboxQuestions_SelectedIndexChanged);
            // 
            // textboxTitle
            // 
            this.textboxTitle.Location = new System.Drawing.Point(12, 25);
            this.textboxTitle.Name = "textboxTitle";
            this.textboxTitle.Size = new System.Drawing.Size(700, 20);
            this.textboxTitle.TabIndex = 1;
            this.textboxTitle.TextChanged += new System.EventHandler(this.textboxTitle_TextChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(27, 13);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Questions";
            // 
            // buttonAddQuestion
            // 
            this.buttonAddQuestion.Location = new System.Drawing.Point(12, 415);
            this.buttonAddQuestion.Name = "buttonAddQuestion";
            this.buttonAddQuestion.Size = new System.Drawing.Size(116, 23);
            this.buttonAddQuestion.TabIndex = 4;
            this.buttonAddQuestion.Text = "Add Question";
            this.buttonAddQuestion.UseVisualStyleBackColor = true;
            this.buttonAddQuestion.Click += new System.EventHandler(this.buttonAddQuestion_Click);
            // 
            // buttonRemoveQuestion
            // 
            this.buttonRemoveQuestion.Location = new System.Drawing.Point(134, 415);
            this.buttonRemoveQuestion.Name = "buttonRemoveQuestion";
            this.buttonRemoveQuestion.Size = new System.Drawing.Size(120, 23);
            this.buttonRemoveQuestion.TabIndex = 5;
            this.buttonRemoveQuestion.Text = "Remove Question";
            this.buttonRemoveQuestion.UseVisualStyleBackColor = true;
            this.buttonRemoveQuestion.Click += new System.EventHandler(this.buttonRemoveQuestion_Click);
            // 
            // buttonSaveQuiz
            // 
            this.buttonSaveQuiz.Location = new System.Drawing.Point(718, 22);
            this.buttonSaveQuiz.Name = "buttonSaveQuiz";
            this.buttonSaveQuiz.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveQuiz.TabIndex = 6;
            this.buttonSaveQuiz.Text = "Save Quiz";
            this.buttonSaveQuiz.UseVisualStyleBackColor = true;
            this.buttonSaveQuiz.Click += new System.EventHandler(this.buttonSaveQuiz_Click);
            // 
            // textboxPromptEdit
            // 
            this.textboxPromptEdit.Location = new System.Drawing.Point(294, 130);
            this.textboxPromptEdit.Multiline = true;
            this.textboxPromptEdit.Name = "textboxPromptEdit";
            this.textboxPromptEdit.Size = new System.Drawing.Size(499, 135);
            this.textboxPromptEdit.TabIndex = 7;
            this.textboxPromptEdit.Click += new System.EventHandler(this.textboxPromptEdit_Click);
            this.textboxPromptEdit.TextChanged += new System.EventHandler(this.textboxPromptEdit_TextChanged);
            // 
            // labelPromptEdit
            // 
            this.labelPromptEdit.AutoSize = true;
            this.labelPromptEdit.Location = new System.Drawing.Point(291, 114);
            this.labelPromptEdit.Name = "labelPromptEdit";
            this.labelPromptEdit.Size = new System.Drawing.Size(378, 13);
            this.labelPromptEdit.TabIndex = 8;
            this.labelPromptEdit.Text = "Type your Prompt Here.  Don\'t forget to use underscores to indictate the blank.";
            // 
            // textboxAnswerEdit
            // 
            this.textboxAnswerEdit.Location = new System.Drawing.Point(294, 314);
            this.textboxAnswerEdit.Name = "textboxAnswerEdit";
            this.textboxAnswerEdit.Size = new System.Drawing.Size(116, 20);
            this.textboxAnswerEdit.TabIndex = 9;
            this.textboxAnswerEdit.TextChanged += new System.EventHandler(this.textboxAnswerEdit_TextChanged);
            this.textboxAnswerEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxAnswerEdit_KeyPress);
            // 
            // labelAnswerEdit
            // 
            this.labelAnswerEdit.AutoSize = true;
            this.labelAnswerEdit.Location = new System.Drawing.Point(291, 298);
            this.labelAnswerEdit.Name = "labelAnswerEdit";
            this.labelAnswerEdit.Size = new System.Drawing.Size(116, 13);
            this.labelAnswerEdit.TabIndex = 10;
            this.labelAnswerEdit.Text = "Type the Answer Here:";
            // 
            // MakerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 450);
            this.Controls.Add(this.labelAnswerEdit);
            this.Controls.Add(this.textboxAnswerEdit);
            this.Controls.Add(this.labelPromptEdit);
            this.Controls.Add(this.textboxPromptEdit);
            this.Controls.Add(this.buttonSaveQuiz);
            this.Controls.Add(this.buttonRemoveQuestion);
            this.Controls.Add(this.buttonAddQuestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textboxTitle);
            this.Controls.Add(this.listboxQuestions);
            this.Name = "MakerScreen";
            this.Text = "MakerScreen";
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
    }
}