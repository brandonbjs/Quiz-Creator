namespace Quiz_Creator
{
    partial class JoinCourseScreen
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
            this.listViewCourses = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonJoinCourse = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewCourses
            // 
            this.listViewCourses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewCourses.FullRowSelect = true;
            this.listViewCourses.GridLines = true;
            this.listViewCourses.HideSelection = false;
            this.listViewCourses.LabelWrap = false;
            this.listViewCourses.Location = new System.Drawing.Point(17, 7);
            this.listViewCourses.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.listViewCourses.MultiSelect = false;
            this.listViewCourses.Name = "listViewCourses";
            this.listViewCourses.ShowGroups = false;
            this.listViewCourses.Size = new System.Drawing.Size(527, 206);
            this.listViewCourses.TabIndex = 10;
            this.listViewCourses.UseCompatibleStateImageBehavior = false;
            this.listViewCourses.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Course Name";
            this.columnHeader1.Width = 220;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Instructor";
            this.columnHeader2.Width = 196;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Password Protected";
            this.columnHeader3.Width = 107;
            // 
            // buttonJoinCourse
            // 
            this.buttonJoinCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJoinCourse.Location = new System.Drawing.Point(141, 218);
            this.buttonJoinCourse.Name = "buttonJoinCourse";
            this.buttonJoinCourse.Size = new System.Drawing.Size(136, 27);
            this.buttonJoinCourse.TabIndex = 11;
            this.buttonJoinCourse.Text = "Join Course";
            this.buttonJoinCourse.UseVisualStyleBackColor = true;
            this.buttonJoinCourse.Click += new System.EventHandler(this.buttonJoinCourse_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(283, 218);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(136, 27);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // JoinCourseScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 253);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonJoinCourse);
            this.Controls.Add(this.listViewCourses);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "JoinCourseScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Join Course";
            this.Load += new System.EventHandler(this.JoinCourseScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewCourses;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button buttonJoinCourse;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button buttonCancel;
    }
}