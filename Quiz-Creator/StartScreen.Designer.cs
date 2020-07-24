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
            this.buttonMakeLocal.Location = new System.Drawing.Point(18, 18);
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
            this.buttonTakeLocal.Location = new System.Drawing.Point(18, 582);
            this.buttonTakeLocal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTakeLocal.Name = "buttonTakeLocal";
            this.buttonTakeLocal.Size = new System.Drawing.Size(204, 35);
            this.buttonTakeLocal.TabIndex = 1;
            this.buttonTakeLocal.Text = "Take Local Quiz";
            this.buttonTakeLocal.UseVisualStyleBackColor = true;
            this.buttonTakeLocal.Click += new System.EventHandler(this.buttonTakeLocal_Click);
            // 
            // textboxLocalQuizFileLocation
            // 
            this.textboxLocalQuizFileLocation.Location = new System.Drawing.Point(18, 542);
            this.textboxLocalQuizFileLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textboxLocalQuizFileLocation.Name = "textboxLocalQuizFileLocation";
            this.textboxLocalQuizFileLocation.Size = new System.Drawing.Size(1160, 26);
            this.textboxLocalQuizFileLocation.TabIndex = 2;
            this.textboxLocalQuizFileLocation.Text = "save.txt";
            // 
            // buttonEditLocal
            // 
            this.buttonEditLocal.Location = new System.Drawing.Point(232, 580);
            this.buttonEditLocal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEditLocal.Name = "buttonEditLocal";
            this.buttonEditLocal.Size = new System.Drawing.Size(194, 35);
            this.buttonEditLocal.TabIndex = 3;
            this.buttonEditLocal.Text = "Edit Local Quiz";
            this.buttonEditLocal.UseVisualStyleBackColor = true;
            this.buttonEditLocal.Click += new System.EventHandler(this.buttonEditLocal_Click);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 637);
            this.Controls.Add(this.buttonEditLocal);
            this.Controls.Add(this.textboxLocalQuizFileLocation);
            this.Controls.Add(this.buttonTakeLocal);
            this.Controls.Add(this.buttonMakeLocal);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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