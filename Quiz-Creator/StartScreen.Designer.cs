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
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLoginOrSignout = new System.Windows.Forms.Button();
            this.listViewLocalQuizzes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonEditRemote = new System.Windows.Forms.Button();
            this.buttonTakeRemote = new System.Windows.Forms.Button();
            this.buttonMakeRemote = new System.Windows.Forms.Button();
            this.buttonDeleteLocal = new System.Windows.Forms.Button();
            this.CourseSelectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMakeLocal
            // 
            this.buttonMakeLocal.Location = new System.Drawing.Point(555, 151);
            this.buttonMakeLocal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMakeLocal.Name = "buttonMakeLocal";
            this.buttonMakeLocal.Size = new System.Drawing.Size(181, 28);
            this.buttonMakeLocal.TabIndex = 0;
            this.buttonMakeLocal.Text = "Make New Local Quiz";
            this.buttonMakeLocal.UseVisualStyleBackColor = true;
            this.buttonMakeLocal.Click += new System.EventHandler(this.buttonMakeLocal_Click);
            // 
            // buttonTakeLocal
            // 
            this.buttonTakeLocal.Enabled = false;
            this.buttonTakeLocal.Location = new System.Drawing.Point(555, 259);
            this.buttonTakeLocal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTakeLocal.Name = "buttonTakeLocal";
            this.buttonTakeLocal.Size = new System.Drawing.Size(181, 28);
            this.buttonTakeLocal.TabIndex = 1;
            this.buttonTakeLocal.Text = "Take Local Quiz";
            this.buttonTakeLocal.UseVisualStyleBackColor = true;
            this.buttonTakeLocal.Click += new System.EventHandler(this.buttonTakeLocal_Click);
            // 
            // buttonEditLocal
            // 
            this.buttonEditLocal.Enabled = false;
            this.buttonEditLocal.Location = new System.Drawing.Point(555, 187);
            this.buttonEditLocal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEditLocal.Name = "buttonEditLocal";
            this.buttonEditLocal.Size = new System.Drawing.Size(181, 28);
            this.buttonEditLocal.TabIndex = 3;
            this.buttonEditLocal.Text = "Edit Local Quiz";
            this.buttonEditLocal.UseVisualStyleBackColor = true;
            this.buttonEditLocal.Click += new System.EventHandler(this.buttonEditLocal_Click);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Items.AddRange(new object[] {
            "Only available when signed in..."});
            this.listBox2.Location = new System.Drawing.Point(11, 328);
            this.listBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(538, 244);
            this.listBox2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Local Quizzes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Organization Quizzes";
            // 
            // buttonLoginOrSignout
            // 
            this.buttonLoginOrSignout.Location = new System.Drawing.Point(601, 5);
            this.buttonLoginOrSignout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLoginOrSignout.Name = "buttonLoginOrSignout";
            this.buttonLoginOrSignout.Size = new System.Drawing.Size(142, 28);
            this.buttonLoginOrSignout.TabIndex = 8;
            this.buttonLoginOrSignout.Text = "Login / signout";
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
            this.listViewLocalQuizzes.Location = new System.Drawing.Point(15, 35);
            this.listViewLocalQuizzes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewLocalQuizzes.MultiSelect = false;
            this.listViewLocalQuizzes.Name = "listViewLocalQuizzes";
            this.listViewLocalQuizzes.ShowGroups = false;
            this.listViewLocalQuizzes.Size = new System.Drawing.Size(534, 253);
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
            this.buttonEditRemote.Location = new System.Drawing.Point(558, 543);
            this.buttonEditRemote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEditRemote.Name = "buttonEditRemote";
            this.buttonEditRemote.Size = new System.Drawing.Size(181, 28);
            this.buttonEditRemote.TabIndex = 12;
            this.buttonEditRemote.Text = "Edit Course Quiz";
            this.buttonEditRemote.UseVisualStyleBackColor = true;
            // 
            // buttonTakeRemote
            // 
            this.buttonTakeRemote.Location = new System.Drawing.Point(558, 507);
            this.buttonTakeRemote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTakeRemote.Name = "buttonTakeRemote";
            this.buttonTakeRemote.Size = new System.Drawing.Size(181, 28);
            this.buttonTakeRemote.TabIndex = 11;
            this.buttonTakeRemote.Text = "Take Course Quiz";
            this.buttonTakeRemote.UseVisualStyleBackColor = true;
            // 
            // buttonMakeRemote
            // 
            this.buttonMakeRemote.Location = new System.Drawing.Point(558, 471);
            this.buttonMakeRemote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMakeRemote.Name = "buttonMakeRemote";
            this.buttonMakeRemote.Size = new System.Drawing.Size(181, 28);
            this.buttonMakeRemote.TabIndex = 10;
            this.buttonMakeRemote.Text = "Make New Course Quiz";
            this.buttonMakeRemote.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteLocal
            // 
            this.buttonDeleteLocal.Enabled = false;
            this.buttonDeleteLocal.Location = new System.Drawing.Point(555, 223);
            this.buttonDeleteLocal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDeleteLocal.Name = "buttonDeleteLocal";
            this.buttonDeleteLocal.Size = new System.Drawing.Size(181, 28);
            this.buttonDeleteLocal.TabIndex = 13;
            this.buttonDeleteLocal.Text = "Delete Local Quiz";
            this.buttonDeleteLocal.UseVisualStyleBackColor = true;
            this.buttonDeleteLocal.Click += new System.EventHandler(this.buttonDeleteLocal_Click);
            // 
            // CourseSelectButton
            // 
            this.CourseSelectButton.Location = new System.Drawing.Point(558, 436);
            this.CourseSelectButton.Name = "CourseSelectButton";
            this.CourseSelectButton.Size = new System.Drawing.Size(181, 28);
            this.CourseSelectButton.TabIndex = 14;
            this.CourseSelectButton.Text = "Select Course";
            this.CourseSelectButton.UseVisualStyleBackColor = true;
            this.CourseSelectButton.Click += new System.EventHandler(this.CourseSelectButton_Click);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 584);
            this.Controls.Add(this.CourseSelectButton);
            this.Controls.Add(this.buttonDeleteLocal);
            this.Controls.Add(this.buttonEditRemote);
            this.Controls.Add(this.buttonTakeRemote);
            this.Controls.Add(this.buttonMakeRemote);
            this.Controls.Add(this.listViewLocalQuizzes);
            this.Controls.Add(this.buttonLoginOrSignout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.buttonEditLocal);
            this.Controls.Add(this.buttonTakeLocal);
            this.Controls.Add(this.buttonMakeLocal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLoginOrSignout;
        private System.Windows.Forms.ListView listViewLocalQuizzes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button buttonEditRemote;
        private System.Windows.Forms.Button buttonTakeRemote;
        private System.Windows.Forms.Button buttonMakeRemote;
        private System.Windows.Forms.Button buttonDeleteLocal;
        private System.Windows.Forms.Button CourseSelectButton;
    }
}