namespace Quiz_Creator
{
    partial class CourseQuizzesList
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
            this.QuizList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // QuizList
            // 
            this.QuizList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuizList.HideSelection = false;
            this.QuizList.Location = new System.Drawing.Point(0, 0);
            this.QuizList.Name = "QuizList";
            this.QuizList.Size = new System.Drawing.Size(797, 451);
            this.QuizList.TabIndex = 0;
            this.QuizList.UseCompatibleStateImageBehavior = false;
            // 
            // CourseQuizzesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 451);
            this.Controls.Add(this.QuizList);
            this.Name = "CourseQuizzesList";
            this.Text = "CourseQuizzesList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView QuizList;
    }
}