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
            this.textboxLocalQuizFileLocation = new System.Windows.Forms.TextBox();
            this.buttonEditLocal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMakeLocal
            // 
            this.buttonMakeLocal.Location = new System.Drawing.Point(12, 12);
            this.buttonMakeLocal.Name = "buttonMakeLocal";
            this.buttonMakeLocal.Size = new System.Drawing.Size(136, 23);
            this.buttonMakeLocal.TabIndex = 0;
            this.buttonMakeLocal.Text = "Make New Local Quiz";
            this.buttonMakeLocal.UseVisualStyleBackColor = true;
            this.buttonMakeLocal.Click += new System.EventHandler(this.buttonMakeLocal_Click);
            // 
            // buttonTakeLocal
            // 
            this.buttonTakeLocal.Location = new System.Drawing.Point(12, 378);
            this.buttonTakeLocal.Name = "buttonTakeLocal";
            this.buttonTakeLocal.Size = new System.Drawing.Size(136, 23);
            this.buttonTakeLocal.TabIndex = 1;
            this.buttonTakeLocal.Text = "Take Local Quiz";
            this.buttonTakeLocal.UseVisualStyleBackColor = true;
            this.buttonTakeLocal.Click += new System.EventHandler(this.buttonTakeLocal_Click);
            // 
            // textboxLocalQuizFileLocation
            // 
            this.textboxLocalQuizFileLocation.Location = new System.Drawing.Point(12, 352);
            this.textboxLocalQuizFileLocation.Name = "textboxLocalQuizFileLocation";
            this.textboxLocalQuizFileLocation.Size = new System.Drawing.Size(775, 20);
            this.textboxLocalQuizFileLocation.TabIndex = 2;
            this.textboxLocalQuizFileLocation.Text = "Type the file name of the quiz you want to open";
            // 
            // buttonEditLocal
            // 
            this.buttonEditLocal.Location = new System.Drawing.Point(155, 377);
            this.buttonEditLocal.Name = "buttonEditLocal";
            this.buttonEditLocal.Size = new System.Drawing.Size(129, 23);
            this.buttonEditLocal.TabIndex = 3;
            this.buttonEditLocal.Text = "Edit Local Quiz";
            this.buttonEditLocal.UseVisualStyleBackColor = true;
            this.buttonEditLocal.Click += new System.EventHandler(this.buttonEditLocal_Click);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 414);
            this.Controls.Add(this.buttonEditLocal);
            this.Controls.Add(this.textboxLocalQuizFileLocation);
            this.Controls.Add(this.buttonTakeLocal);
            this.Controls.Add(this.buttonMakeLocal);
            this.Name = "StartScreen";
            this.Text = "StartScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMakeLocal;
        private System.Windows.Forms.Button buttonTakeLocal;
        private System.Windows.Forms.TextBox textboxLocalQuizFileLocation;
        private System.Windows.Forms.Button buttonEditLocal;
    }
}