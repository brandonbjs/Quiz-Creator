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
            this.listViewCourseQuizzes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTakeLocal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewCourseQuizzes
            // 
            this.listViewCourseQuizzes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewCourseQuizzes.FullRowSelect = true;
            this.listViewCourseQuizzes.HideSelection = false;
            this.listViewCourseQuizzes.LabelWrap = false;
            this.listViewCourseQuizzes.Location = new System.Drawing.Point(12, 42);
            this.listViewCourseQuizzes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewCourseQuizzes.MultiSelect = false;
            this.listViewCourseQuizzes.Name = "listViewCourseQuizzes";
            this.listViewCourseQuizzes.ShowGroups = false;
            this.listViewCourseQuizzes.Size = new System.Drawing.Size(600, 315);
            this.listViewCourseQuizzes.TabIndex = 19;
            this.listViewCourseQuizzes.UseCompatibleStateImageBehavior = false;
            this.listViewCourseQuizzes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Quiz Name";
            this.columnHeader1.Width = 197;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date Last Modified";
            this.columnHeader2.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Course Quizzes";
            // 
            // buttonTakeLocal
            // 
            this.buttonTakeLocal.Enabled = false;
            this.buttonTakeLocal.Location = new System.Drawing.Point(214, 364);
            this.buttonTakeLocal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTakeLocal.Name = "buttonTakeLocal";
            this.buttonTakeLocal.Size = new System.Drawing.Size(204, 35);
            this.buttonTakeLocal.TabIndex = 15;
            this.buttonTakeLocal.Text = "Take Local Quiz";
            this.buttonTakeLocal.UseVisualStyleBackColor = true;
            // 
            // CourseScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 415);
            this.Controls.Add(this.listViewCourseQuizzes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTakeLocal);
            this.Name = "CourseScreen";
            this.Text = "CourseScreen";
            this.Load += new System.EventHandler(this.CourseScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewCourseQuizzes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTakeLocal;
    }
}