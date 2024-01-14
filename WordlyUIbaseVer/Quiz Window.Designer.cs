namespace WordlyUIbaseVer
{
    partial class Quiz_Window
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
            quizLbl = new Label();
            SuspendLayout();
            // 
            // quizLbl
            // 
            quizLbl.AutoSize = true;
            quizLbl.BackColor = Color.Transparent;
            quizLbl.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quizLbl.Location = new Point(177, 200);
            quizLbl.Name = "quizLbl";
            quizLbl.Size = new Size(191, 86);
            quizLbl.TabIndex = 1;
            quizLbl.Text = "QUIZ";
            // 
            // Quiz_Window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(584, 486);
            Controls.Add(quizLbl);
            Name = "Quiz_Window";
            Text = "Quiz_Window";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label quizLbl;
    }
}