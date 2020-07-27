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
            this.listboxQuestions.ItemHeight = 20;
            this.listboxQuestions.Location = new System.Drawing.Point(18, 129);
            this.listboxQuestions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listboxQuestions.Name = "listboxQuestions";
            this.listboxQuestions.Size = new System.Drawing.Size(361, 484);
            this.listboxQuestions.TabIndex = 0;
            this.listboxQuestions.SelectedIndexChanged += new System.EventHandler(this.listboxQuestions_SelectedIndexChanged);
            // 
            // textboxTitle
            // 
            this.textboxTitle.Location = new System.Drawing.Point(18, 38);
            this.textboxTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textboxTitle.Name = "textboxTitle";
            this.textboxTitle.Size = new System.Drawing.Size(1048, 26);
            this.textboxTitle.TabIndex = 1;
            this.textboxTitle.TextChanged += new System.EventHandler(this.textboxTitle_TextChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(18, 14);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(38, 20);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Questions";
            // 
            // buttonAddQuestion
            // 
            this.buttonAddQuestion.Location = new System.Drawing.Point(18, 638);
            this.buttonAddQuestion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddQuestion.Name = "buttonAddQuestion";
            this.buttonAddQuestion.Size = new System.Drawing.Size(174, 35);
            this.buttonAddQuestion.TabIndex = 4;
            this.buttonAddQuestion.Text = "Add Question";
            this.buttonAddQuestion.UseVisualStyleBackColor = true;
            this.buttonAddQuestion.Click += new System.EventHandler(this.buttonAddQuestion_Click);
            // 
            // buttonRemoveQuestion
            // 
            this.buttonRemoveQuestion.Location = new System.Drawing.Point(201, 638);
            this.buttonRemoveQuestion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRemoveQuestion.Name = "buttonRemoveQuestion";
            this.buttonRemoveQuestion.Size = new System.Drawing.Size(180, 35);
            this.buttonRemoveQuestion.TabIndex = 5;
            this.buttonRemoveQuestion.Text = "Remove Question";
            this.buttonRemoveQuestion.UseVisualStyleBackColor = true;
            this.buttonRemoveQuestion.Click += new System.EventHandler(this.buttonRemoveQuestion_Click);
            // 
            // buttonSaveQuiz
            // 
            this.buttonSaveQuiz.Location = new System.Drawing.Point(1077, 34);
            this.buttonSaveQuiz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSaveQuiz.Name = "buttonSaveQuiz";
            this.buttonSaveQuiz.Size = new System.Drawing.Size(112, 35);
            this.buttonSaveQuiz.TabIndex = 6;
            this.buttonSaveQuiz.Text = "Save Quiz";
            this.buttonSaveQuiz.UseVisualStyleBackColor = true;
            this.buttonSaveQuiz.Click += new System.EventHandler(this.buttonSaveQuiz_Click);
            // 
            // textboxPromptEdit
            // 
            this.textboxPromptEdit.Location = new System.Drawing.Point(441, 200);
            this.textboxPromptEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textboxPromptEdit.Multiline = true;
            this.textboxPromptEdit.Name = "textboxPromptEdit";
            this.textboxPromptEdit.Size = new System.Drawing.Size(746, 206);
            this.textboxPromptEdit.TabIndex = 7;
            this.textboxPromptEdit.Click += new System.EventHandler(this.textboxPromptEdit_Click);
            this.textboxPromptEdit.TextChanged += new System.EventHandler(this.textboxPromptEdit_TextChanged);
            // 
            // labelPromptEdit
            // 
            this.labelPromptEdit.AutoSize = true;
            this.labelPromptEdit.Location = new System.Drawing.Point(436, 175);
            this.labelPromptEdit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPromptEdit.Name = "labelPromptEdit";
            this.labelPromptEdit.Size = new System.Drawing.Size(562, 20);
            this.labelPromptEdit.TabIndex = 8;
            this.labelPromptEdit.Text = "Type your Prompt Here.  Don\'t forget to use underscores to indictate the blank.";
            // 
            // textboxAnswerEdit
            // 
            this.textboxAnswerEdit.Location = new System.Drawing.Point(441, 483);
            this.textboxAnswerEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textboxAnswerEdit.Name = "textboxAnswerEdit";
            this.textboxAnswerEdit.Size = new System.Drawing.Size(172, 26);
            this.textboxAnswerEdit.TabIndex = 9;
            this.textboxAnswerEdit.TextChanged += new System.EventHandler(this.textboxAnswerEdit_TextChanged);
            this.textboxAnswerEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxAnswerEdit_KeyPress);
            // 
            // labelAnswerEdit
            // 
            this.labelAnswerEdit.AutoSize = true;
            this.labelAnswerEdit.Location = new System.Drawing.Point(436, 458);
            this.labelAnswerEdit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAnswerEdit.Name = "labelAnswerEdit";
            this.labelAnswerEdit.Size = new System.Drawing.Size(170, 20);
            this.labelAnswerEdit.TabIndex = 10;
            this.labelAnswerEdit.Text = "Type the Answer Here:";
            // 
            // MakerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 692);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MakerScreen";
            this.Text = "Make a Quiz";
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