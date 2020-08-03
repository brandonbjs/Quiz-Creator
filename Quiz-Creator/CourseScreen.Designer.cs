namespace Quiz_Creator
{
    partial class CourseScreen
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
            this.labelCourse = new System.Windows.Forms.Label();
            this.buttonTakeQuiz = new System.Windows.Forms.Button();
            this.listBoxQuizzes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelCourse
            // 
            this.labelCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourse.Location = new System.Drawing.Point(28, 9);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(358, 30);
            this.labelCourse.TabIndex = 17;
            this.labelCourse.Text = "Course Quizzes";
            this.labelCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonTakeQuiz
            // 
            this.buttonTakeQuiz.Enabled = false;
            this.buttonTakeQuiz.Location = new System.Drawing.Point(128, 282);
            this.buttonTakeQuiz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTakeQuiz.Name = "buttonTakeQuiz";
            this.buttonTakeQuiz.Size = new System.Drawing.Size(159, 26);
            this.buttonTakeQuiz.TabIndex = 15;
            this.buttonTakeQuiz.Text = "Take Quiz";
            this.buttonTakeQuiz.UseVisualStyleBackColor = true;
            this.buttonTakeQuiz.Click += new System.EventHandler(this.buttonTakeQuiz_Click);
            // 
            // listBoxQuizzes
            // 
            this.listBoxQuizzes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxQuizzes.FormattingEnabled = true;
            this.listBoxQuizzes.ItemHeight = 16;
            this.listBoxQuizzes.Location = new System.Drawing.Point(13, 43);
            this.listBoxQuizzes.Name = "listBoxQuizzes";
            this.listBoxQuizzes.Size = new System.Drawing.Size(390, 228);
            this.listBoxQuizzes.TabIndex = 18;
            this.listBoxQuizzes.SelectedValueChanged += new System.EventHandler(this.listBoxQuizzes_SelectedValueChanged);
            // 
            // CourseScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 319);
            this.Controls.Add(this.listBoxQuizzes);
            this.Controls.Add(this.labelCourse);
            this.Controls.Add(this.buttonTakeQuiz);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBox = false;
            this.Name = "CourseScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Quizzes";
            this.Load += new System.EventHandler(this.CourseScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.Button buttonTakeQuiz;
        private System.Windows.Forms.ListBox listBoxQuizzes;
    }
}