namespace Quiz_Creator
{
    partial class StartScreen
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
            this.buttonMakeLocal = new System.Windows.Forms.Button();
            this.buttonTakeLocal = new System.Windows.Forms.Button();
            this.buttonEditLocal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLoginOrSignout = new System.Windows.Forms.Button();
            this.listViewLocalQuizzes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDeleteLocal = new System.Windows.Forms.Button();
            this.buttonCourseSelect = new System.Windows.Forms.Button();
            this.buttonJoinCourse = new System.Windows.Forms.Button();
            this.listViewCourses = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelHideCourses = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonMakeLocal
            // 
            this.buttonMakeLocal.FlatAppearance.BorderSize = 0;
            this.buttonMakeLocal.Location = new System.Drawing.Point(12, 239);
            this.buttonMakeLocal.Name = "buttonMakeLocal";
            this.buttonMakeLocal.Size = new System.Drawing.Size(101, 35);
            this.buttonMakeLocal.TabIndex = 0;
            this.buttonMakeLocal.TabStop = false;
            this.buttonMakeLocal.Text = "New Local Quiz";
            this.buttonMakeLocal.UseVisualStyleBackColor = true;
            this.buttonMakeLocal.Click += new System.EventHandler(this.buttonMakeLocal_Click);
            // 
            // buttonTakeLocal
            // 
            this.buttonTakeLocal.Location = new System.Drawing.Point(313, 239);
            this.buttonTakeLocal.Name = "buttonTakeLocal";
            this.buttonTakeLocal.Size = new System.Drawing.Size(101, 35);
            this.buttonTakeLocal.TabIndex = 1;
            this.buttonTakeLocal.TabStop = false;
            this.buttonTakeLocal.Text = "Take Local Quiz";
            this.buttonTakeLocal.UseVisualStyleBackColor = true;
            this.buttonTakeLocal.Click += new System.EventHandler(this.buttonTakeLocal_Click);
            // 
            // buttonEditLocal
            // 
            this.buttonEditLocal.Location = new System.Drawing.Point(112, 239);
            this.buttonEditLocal.Name = "buttonEditLocal";
            this.buttonEditLocal.Size = new System.Drawing.Size(102, 35);
            this.buttonEditLocal.TabIndex = 3;
            this.buttonEditLocal.TabStop = false;
            this.buttonEditLocal.Text = "Edit Local Quiz";
            this.buttonEditLocal.UseVisualStyleBackColor = true;
            this.buttonEditLocal.Click += new System.EventHandler(this.buttonEditLocal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Local Quizzes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 284);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "My Courses";
            // 
            // buttonLoginOrSignout
            // 
            this.buttonLoginOrSignout.Location = new System.Drawing.Point(308, 4);
            this.buttonLoginOrSignout.Name = "buttonLoginOrSignout";
            this.buttonLoginOrSignout.Size = new System.Drawing.Size(107, 23);
            this.buttonLoginOrSignout.TabIndex = 8;
            this.buttonLoginOrSignout.TabStop = false;
            this.buttonLoginOrSignout.Text = "Sign In";
            this.buttonLoginOrSignout.UseVisualStyleBackColor = true;
            this.buttonLoginOrSignout.Click += new System.EventHandler(this.buttonLoginOrSignout_Click);
            // 
            // listViewLocalQuizzes
            // 
            this.listViewLocalQuizzes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewLocalQuizzes.FullRowSelect = true;
            this.listViewLocalQuizzes.GridLines = true;
            this.listViewLocalQuizzes.HideSelection = false;
            this.listViewLocalQuizzes.LabelWrap = false;
            this.listViewLocalQuizzes.Location = new System.Drawing.Point(13, 33);
            this.listViewLocalQuizzes.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.listViewLocalQuizzes.MultiSelect = false;
            this.listViewLocalQuizzes.Name = "listViewLocalQuizzes";
            this.listViewLocalQuizzes.ShowGroups = false;
            this.listViewLocalQuizzes.Size = new System.Drawing.Size(400, 206);
            this.listViewLocalQuizzes.TabIndex = 9;
            this.listViewLocalQuizzes.UseCompatibleStateImageBehavior = false;
            this.listViewLocalQuizzes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Quiz Name";
            this.columnHeader1.Width = 198;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date Last Modified";
            this.columnHeader2.Width = 198;
            // 
            // buttonDeleteLocal
            // 
            this.buttonDeleteLocal.Location = new System.Drawing.Point(213, 239);
            this.buttonDeleteLocal.Name = "buttonDeleteLocal";
            this.buttonDeleteLocal.Size = new System.Drawing.Size(101, 35);
            this.buttonDeleteLocal.TabIndex = 13;
            this.buttonDeleteLocal.TabStop = false;
            this.buttonDeleteLocal.Text = "Delete Local Quiz";
            this.buttonDeleteLocal.UseVisualStyleBackColor = true;
            this.buttonDeleteLocal.Click += new System.EventHandler(this.buttonDeleteLocal_Click);
            // 
            // buttonCourseSelect
            // 
            this.buttonCourseSelect.Location = new System.Drawing.Point(208, 511);
            this.buttonCourseSelect.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonCourseSelect.Name = "buttonCourseSelect";
            this.buttonCourseSelect.Size = new System.Drawing.Size(203, 35);
            this.buttonCourseSelect.TabIndex = 14;
            this.buttonCourseSelect.TabStop = false;
            this.buttonCourseSelect.Text = "View Course";
            this.buttonCourseSelect.UseVisualStyleBackColor = true;
            this.buttonCourseSelect.Click += new System.EventHandler(this.buttonCourseSelect_Click);
            // 
            // buttonJoinCourse
            // 
            this.buttonJoinCourse.Location = new System.Drawing.Point(9, 511);
            this.buttonJoinCourse.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonJoinCourse.Name = "buttonJoinCourse";
            this.buttonJoinCourse.Size = new System.Drawing.Size(200, 35);
            this.buttonJoinCourse.TabIndex = 15;
            this.buttonJoinCourse.TabStop = false;
            this.buttonJoinCourse.Text = "Join a Course";
            this.buttonJoinCourse.UseVisualStyleBackColor = true;
            this.buttonJoinCourse.Click += new System.EventHandler(this.buttonJoinCourse_Click);
            // 
            // listViewCourses
            // 
            this.listViewCourses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listViewCourses.FullRowSelect = true;
            this.listViewCourses.GridLines = true;
            this.listViewCourses.HideSelection = false;
            this.listViewCourses.LabelWrap = false;
            this.listViewCourses.Location = new System.Drawing.Point(10, 305);
            this.listViewCourses.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.listViewCourses.MultiSelect = false;
            this.listViewCourses.Name = "listViewCourses";
            this.listViewCourses.ShowGroups = false;
            this.listViewCourses.Size = new System.Drawing.Size(400, 206);
            this.listViewCourses.TabIndex = 17;
            this.listViewCourses.UseCompatibleStateImageBehavior = false;
            this.listViewCourses.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Course Name";
            this.columnHeader3.Width = 199;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Instructor";
            this.columnHeader4.Width = 197;
            // 
            // labelHideCourses
            // 
            this.labelHideCourses.BackColor = System.Drawing.SystemColors.Control;
            this.labelHideCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHideCourses.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelHideCourses.Location = new System.Drawing.Point(11, 307);
            this.labelHideCourses.Name = "labelHideCourses";
            this.labelHideCourses.Size = new System.Drawing.Size(398, 202);
            this.labelHideCourses.TabIndex = 18;
            this.labelHideCourses.Text = "Sign in to view";
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(423, 554);
            this.Controls.Add(this.listViewLocalQuizzes);
            this.Controls.Add(this.buttonLoginOrSignout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTakeLocal);
            this.Controls.Add(this.buttonDeleteLocal);
            this.Controls.Add(this.buttonEditLocal);
            this.Controls.Add(this.buttonMakeLocal);
            this.Controls.Add(this.buttonJoinCourse);
            this.Controls.Add(this.buttonCourseSelect);
            this.Controls.Add(this.labelHideCourses);
            this.Controls.Add(this.listViewCourses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "StartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Quiz Creator!";
            this.Activated += new System.EventHandler(this.StartScreen_Activated);
            this.Load += new System.EventHandler(this.StartScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMakeLocal;
        private System.Windows.Forms.Button buttonTakeLocal;
        private System.Windows.Forms.Button buttonEditLocal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLoginOrSignout;
        private System.Windows.Forms.ListView listViewLocalQuizzes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button buttonDeleteLocal;
        private System.Windows.Forms.Button buttonCourseSelect;
        private System.Windows.Forms.Button buttonJoinCourse;
        private System.Windows.Forms.ListView listViewCourses;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label labelHideCourses;
    }
}