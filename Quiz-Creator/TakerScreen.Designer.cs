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
            this.labelQuizTitle = new System.Windows.Forms.Label();
            this.buttonSubmitQuiz = new System.Windows.Forms.Button();
            this.groupBoxQuestion = new System.Windows.Forms.GroupBox();
            this.textBoxResponse = new System.Windows.Forms.TextBox();
            this.labelResponse = new System.Windows.Forms.Label();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.labelPrompt = new System.Windows.Forms.Label();
            this.comboBoxQuestionSelect = new System.Windows.Forms.ComboBox();
            this.groupBoxQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Enabled = false;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(12, 342);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(92, 31);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "< Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(476, 342);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(87, 31);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = "Next >";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelQuizTitle
            // 
            this.labelQuizTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuizTitle.Location = new System.Drawing.Point(7, 9);
            this.labelQuizTitle.Name = "labelQuizTitle";
            this.labelQuizTitle.Size = new System.Drawing.Size(397, 30);
            this.labelQuizTitle.TabIndex = 2;
            this.labelQuizTitle.Text = "Quiz Title";
            // 
            // buttonSubmitQuiz
            // 
            this.buttonSubmitQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSubmitQuiz.Location = new System.Drawing.Point(212, 342);
            this.buttonSubmitQuiz.Name = "buttonSubmitQuiz";
            this.buttonSubmitQuiz.Size = new System.Drawing.Size(151, 31);
            this.buttonSubmitQuiz.TabIndex = 7;
            this.buttonSubmitQuiz.Text = "Submit Quiz";
            this.buttonSubmitQuiz.UseVisualStyleBackColor = true;
            this.buttonSubmitQuiz.Click += new System.EventHandler(this.buttonSubmitQuiz_Click);
            // 
            // groupBoxQuestion
            // 
            this.groupBoxQuestion.BackColor = System.Drawing.Color.White;
            this.groupBoxQuestion.Controls.Add(this.textBoxResponse);
            this.groupBoxQuestion.Controls.Add(this.labelResponse);
            this.groupBoxQuestion.Controls.Add(this.radioButton5);
            this.groupBoxQuestion.Controls.Add(this.radioButton3);
            this.groupBoxQuestion.Controls.Add(this.radioButton4);
            this.groupBoxQuestion.Controls.Add(this.radioButton2);
            this.groupBoxQuestion.Controls.Add(this.radioButton1);
            this.groupBoxQuestion.Controls.Add(this.labelPrompt);
            this.groupBoxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxQuestion.Location = new System.Drawing.Point(12, 51);
            this.groupBoxQuestion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxQuestion.Name = "groupBoxQuestion";
            this.groupBoxQuestion.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxQuestion.Size = new System.Drawing.Size(550, 280);
            this.groupBoxQuestion.TabIndex = 9;
            this.groupBoxQuestion.TabStop = false;
            this.groupBoxQuestion.Text = "Question #";
            // 
            // textBoxResponse
            // 
            this.textBoxResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResponse.Location = new System.Drawing.Point(126, 93);
            this.textBoxResponse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxResponse.Name = "textBoxResponse";
            this.textBoxResponse.Size = new System.Drawing.Size(272, 26);
            this.textBoxResponse.TabIndex = 8;
            // 
            // labelResponse
            // 
            this.labelResponse.AutoSize = true;
            this.labelResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResponse.Location = new System.Drawing.Point(4, 94);
            this.labelResponse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResponse.Name = "labelResponse";
            this.labelResponse.Size = new System.Drawing.Size(117, 20);
            this.labelResponse.TabIndex = 7;
            this.labelResponse.Text = "Your response:";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.Location = new System.Drawing.Point(7, 226);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(119, 24);
            this.radioButton5.TabIndex = 6;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "radioButton5";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.Visible = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(7, 159);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(119, 24);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Visible = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(7, 192);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(119, 24);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.Visible = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(7, 127);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(119, 24);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(7, 95);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(119, 24);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            // 
            // labelPrompt
            // 
            this.labelPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrompt.Location = new System.Drawing.Point(4, 36);
            this.labelPrompt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrompt.Name = "labelPrompt";
            this.labelPrompt.Size = new System.Drawing.Size(542, 43);
            this.labelPrompt.TabIndex = 0;
            this.labelPrompt.Text = "Question prompt? ";
            this.labelPrompt.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // comboBoxQuestionSelect
            // 
            this.comboBoxQuestionSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQuestionSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxQuestionSelect.FormattingEnabled = true;
            this.comboBoxQuestionSelect.Location = new System.Drawing.Point(366, 9);
            this.comboBoxQuestionSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxQuestionSelect.MaxDropDownItems = 30;
            this.comboBoxQuestionSelect.Name = "comboBoxQuestionSelect";
            this.comboBoxQuestionSelect.Size = new System.Drawing.Size(196, 28);
            this.comboBoxQuestionSelect.TabIndex = 10;
            this.comboBoxQuestionSelect.SelectedIndexChanged += new System.EventHandler(this.comboBoxQuestionSelect_SelectedIndexChanged);
            // 
            // TakerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 385);
            this.Controls.Add(this.comboBoxQuestionSelect);
            this.Controls.Add(this.groupBoxQuestion);
            this.Controls.Add(this.buttonSubmitQuiz);
            this.Controls.Add(this.labelQuizTitle);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "TakerScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Take Quiz";
            this.Load += new System.EventHandler(this.TakerScreen_Load);
            this.groupBoxQuestion.ResumeLayout(false);
            this.groupBoxQuestion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelQuizTitle;
        private System.Windows.Forms.Button buttonSubmitQuiz;
        private System.Windows.Forms.GroupBox groupBoxQuestion;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label labelPrompt;
        private System.Windows.Forms.ComboBox comboBoxQuestionSelect;
        private System.Windows.Forms.TextBox textBoxResponse;
        private System.Windows.Forms.Label labelResponse;
    }
}