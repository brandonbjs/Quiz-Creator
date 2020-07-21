namespace Quiz_Creator
{
    partial class TakerScreen
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelQuestionNum = new System.Windows.Forms.Label();
            this.textboxQuestion = new System.Windows.Forms.TextBox();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.textboxAnswer = new System.Windows.Forms.TextBox();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.buttonSubmitQuiz = new System.Windows.Forms.Button();
            this.buttonSubmitQuestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "< Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(436, 12);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = "Next >";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelQuestionNum
            // 
            this.labelQuestionNum.AutoSize = true;
            this.labelQuestionNum.Location = new System.Drawing.Point(226, 17);
            this.labelQuestionNum.Name = "labelQuestionNum";
            this.labelQuestionNum.Size = new System.Drawing.Size(59, 13);
            this.labelQuestionNum.TabIndex = 2;
            this.labelQuestionNum.Text = "Question #";
            // 
            // textboxQuestion
            // 
            this.textboxQuestion.Enabled = false;
            this.textboxQuestion.Location = new System.Drawing.Point(12, 78);
            this.textboxQuestion.Multiline = true;
            this.textboxQuestion.Name = "textboxQuestion";
            this.textboxQuestion.ReadOnly = true;
            this.textboxQuestion.Size = new System.Drawing.Size(499, 207);
            this.textboxQuestion.TabIndex = 3;
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(12, 59);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(52, 13);
            this.labelQuestion.TabIndex = 4;
            this.labelQuestion.Text = "Question:";
            // 
            // textboxAnswer
            // 
            this.textboxAnswer.Location = new System.Drawing.Point(202, 345);
            this.textboxAnswer.Name = "textboxAnswer";
            this.textboxAnswer.Size = new System.Drawing.Size(112, 20);
            this.textboxAnswer.TabIndex = 5;
            this.textboxAnswer.TextChanged += new System.EventHandler(this.textboxAnswer_TextChanged);
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Location = new System.Drawing.Point(220, 330);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(80, 13);
            this.labelAnswer.TabIndex = 6;
            this.labelAnswer.Text = "Fill in the blank:";
            // 
            // buttonSubmitQuiz
            // 
            this.buttonSubmitQuiz.Location = new System.Drawing.Point(436, 415);
            this.buttonSubmitQuiz.Name = "buttonSubmitQuiz";
            this.buttonSubmitQuiz.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmitQuiz.TabIndex = 7;
            this.buttonSubmitQuiz.Text = "Submit Quiz";
            this.buttonSubmitQuiz.UseVisualStyleBackColor = true;
            this.buttonSubmitQuiz.Click += new System.EventHandler(this.buttonSubmitQuiz_Click);
            // 
            // buttonSubmitQuestion
            // 
            this.buttonSubmitQuestion.Location = new System.Drawing.Point(398, 343);
            this.buttonSubmitQuestion.Name = "buttonSubmitQuestion";
            this.buttonSubmitQuestion.Size = new System.Drawing.Size(113, 23);
            this.buttonSubmitQuestion.TabIndex = 8;
            this.buttonSubmitQuestion.Text = "Submit Question";
            this.buttonSubmitQuestion.UseVisualStyleBackColor = true;
            this.buttonSubmitQuestion.Click += new System.EventHandler(this.buttonSubmitQuestion_Click);
            // 
            // TakerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 450);
            this.Controls.Add(this.buttonSubmitQuestion);
            this.Controls.Add(this.buttonSubmitQuiz);
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.textboxAnswer);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.textboxQuestion);
            this.Controls.Add(this.labelQuestionNum);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonBack);
            this.Name = "TakerScreen";
            this.Text = "TakerScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelQuestionNum;
        private System.Windows.Forms.TextBox textboxQuestion;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.TextBox textboxAnswer;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.Button buttonSubmitQuiz;
        private System.Windows.Forms.Button buttonSubmitQuestion;
    }
}