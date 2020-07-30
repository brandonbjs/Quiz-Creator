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
            this.buttonEditRemote = new System.Windows.Forms.Button();
            this.buttonMakeRemote = new System.Windows.Forms.Button();
            this.buttonDeleteLocal = new System.Windows.Forms.Button();
            this.buttonCourseSelect = new System.Windows.Forms.Button();
            this.buttonJoinCourse = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listViewCourses = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // buttonMakeLocal
            // 
            this.buttonMakeLocal.Location = new System.Drawing.Point(624, 189);
            this.buttonMakeLocal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonMakeLocal.Name = "buttonMakeLocal";
            this.buttonMakeLocal.Size = new System.Drawing.Size(204, 35);
            this.buttonMakeLocal.TabIndex = 0;
            this.buttonMakeLocal.Text = "Make New Local Quiz";
            this.buttonMakeLocal.UseVisualStyleBackColor = true;
            this.buttonMakeLocal.Click += new System.EventHandler(this.buttonMakeLocal_Click);
            // 
            // buttonTakeLocal
            // 
            this.buttonTakeLocal.Enabled = false;
            this.buttonTakeLocal.Location = new System.Drawing.Point(624, 324);
            this.buttonTakeLocal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTakeLocal.Name = "buttonTakeLocal";
            this.buttonTakeLocal.Size = new System.Drawing.Size(204, 35);
            this.buttonTakeLocal.TabIndex = 1;
            this.buttonTakeLocal.Text = "Take Local Quiz";
            this.buttonTakeLocal.UseVisualStyleBackColor = true;
            this.buttonTakeLocal.Click += new System.EventHandler(this.buttonTakeLocal_Click);
            // 
            // buttonEditLocal
            // 
            this.buttonEditLocal.Enabled = false;
            this.buttonEditLocal.Location = new System.Drawing.Point(624, 234);
            this.buttonEditLocal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEditLocal.Name = "buttonEditLocal";
            this.buttonEditLocal.Size = new System.Drawing.Size(204, 35);
            this.buttonEditLocal.TabIndex = 3;
            this.buttonEditLocal.Text = "Edit Local Quiz";
            this.buttonEditLocal.UseVisualStyleBackColor = true;
            this.buttonEditLocal.Click += new System.EventHandler(this.buttonEditLocal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Local Quizzes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "My Courses";
            // 
            // buttonLoginOrSignout
            // 
            this.buttonLoginOrSignout.Location = new System.Drawing.Point(676, 6);
            this.buttonLoginOrSignout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLoginOrSignout.Name = "buttonLoginOrSignout";
            this.buttonLoginOrSignout.Size = new System.Drawing.Size(160, 35);
            this.buttonLoginOrSignout.TabIndex = 8;
            this.buttonLoginOrSignout.Text = "Login";
            this.buttonLoginOrSignout.UseVisualStyleBackColor = true;
            this.buttonLoginOrSignout.Click += new System.EventHandler(this.buttonLoginOrSignout_Click);
            // 
            // listViewLocalQuizzes
            // 
            this.listViewLocalQuizzes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewLocalQuizzes.FullRowSelect = true;
            this.listViewLocalQuizzes.HideSelection = false;
            this.listViewLocalQuizzes.LabelWrap = false;
            this.listViewLocalQuizzes.Location = new System.Drawing.Point(17, 44);
            this.listViewLocalQuizzes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewLocalQuizzes.MultiSelect = false;
            this.listViewLocalQuizzes.Name = "listViewLocalQuizzes";
            this.listViewLocalQuizzes.ShowGroups = false;
            this.listViewLocalQuizzes.Size = new System.Drawing.Size(600, 315);
            this.listViewLocalQuizzes.TabIndex = 9;
            this.listViewLocalQuizzes.UseCompatibleStateImageBehavior = false;
            this.listViewLocalQuizzes.View = System.Windows.Forms.View.Details;
            this.listViewLocalQuizzes.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewLocalQuizzes_ItemSelectionChanged);
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
            // buttonEditRemote
            // 
            this.buttonEditRemote.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditRemote.Location = new System.Drawing.Point(622, 542);
            this.buttonEditRemote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEditRemote.Name = "buttonEditRemote";
            this.buttonEditRemote.Size = new System.Drawing.Size(204, 35);
            this.buttonEditRemote.TabIndex = 12;
            this.buttonEditRemote.Text = "Edit Course Quiz (instructor)";
            this.buttonEditRemote.UseVisualStyleBackColor = true;
            this.buttonEditRemote.Visible = false;
            // 
            // buttonMakeRemote
            // 
            this.buttonMakeRemote.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMakeRemote.Location = new System.Drawing.Point(621, 584);
            this.buttonMakeRemote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonMakeRemote.Name = "buttonMakeRemote";
            this.buttonMakeRemote.Size = new System.Drawing.Size(204, 35);
            this.buttonMakeRemote.TabIndex = 10;
            this.buttonMakeRemote.Text = "Make New Course Quiz (instr)";
            this.buttonMakeRemote.UseVisualStyleBackColor = true;
            this.buttonMakeRemote.Visible = false;
            // 
            // buttonDeleteLocal
            // 
            this.buttonDeleteLocal.Enabled = false;
            this.buttonDeleteLocal.Location = new System.Drawing.Point(624, 279);
            this.buttonDeleteLocal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDeleteLocal.Name = "buttonDeleteLocal";
            this.buttonDeleteLocal.Size = new System.Drawing.Size(204, 35);
            this.buttonDeleteLocal.TabIndex = 13;
            this.buttonDeleteLocal.Text = "Delete Local Quiz";
            this.buttonDeleteLocal.UseVisualStyleBackColor = true;
            this.buttonDeleteLocal.Click += new System.EventHandler(this.buttonDeleteLocal_Click);
            // 
            // buttonCourseSelect
            // 
            this.buttonCourseSelect.Location = new System.Drawing.Point(628, 690);
            this.buttonCourseSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCourseSelect.Name = "buttonCourseSelect";
            this.buttonCourseSelect.Size = new System.Drawing.Size(204, 35);
            this.buttonCourseSelect.TabIndex = 14;
            this.buttonCourseSelect.Text = "View Course";
            this.buttonCourseSelect.UseVisualStyleBackColor = true;
            this.buttonCourseSelect.Click += new System.EventHandler(this.buttonCourseSelect_Click);
            // 
            // buttonJoinCourse
            // 
            this.buttonJoinCourse.Location = new System.Drawing.Point(628, 647);
            this.buttonJoinCourse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonJoinCourse.Name = "buttonJoinCourse";
            this.buttonJoinCourse.Size = new System.Drawing.Size(204, 35);
            this.buttonJoinCourse.TabIndex = 15;
            this.buttonJoinCourse.Text = "Join a Course";
            this.buttonJoinCourse.UseVisualStyleBackColor = true;
            this.buttonJoinCourse.Click += new System.EventHandler(this.buttonJoinCourse_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(621, 497);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 35);
            this.button2.TabIndex = 16;
            this.button2.Text = "Create Course (instructor)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
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
            this.listViewCourses.Location = new System.Drawing.Point(12, 410);
            this.listViewCourses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewCourses.MultiSelect = false;
            this.listViewCourses.Name = "listViewCourses";
            this.listViewCourses.ShowGroups = false;
            this.listViewCourses.Size = new System.Drawing.Size(602, 315);
            this.listViewCourses.TabIndex = 17;
            this.listViewCourses.UseCompatibleStateImageBehavior = false;
            this.listViewCourses.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Course Name";
            this.columnHeader3.Width = 210;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Instructor";
            this.columnHeader4.Width = 187;
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 753);
            this.Controls.Add(this.listViewCourses);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonJoinCourse);
            this.Controls.Add(this.buttonCourseSelect);
            this.Controls.Add(this.buttonDeleteLocal);
            this.Controls.Add(this.buttonEditRemote);
            this.Controls.Add(this.buttonMakeRemote);
            this.Controls.Add(this.listViewLocalQuizzes);
            this.Controls.Add(this.buttonLoginOrSignout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEditLocal);
            this.Controls.Add(this.buttonTakeLocal);
            this.Controls.Add(this.buttonMakeLocal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button buttonEditRemote;
        private System.Windows.Forms.Button buttonMakeRemote;
        private System.Windows.Forms.Button buttonDeleteLocal;
        private System.Windows.Forms.Button buttonCourseSelect;
        private System.Windows.Forms.Button buttonJoinCourse;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listViewCourses;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}