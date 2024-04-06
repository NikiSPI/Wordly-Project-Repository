using RoundedComponents;

namespace Wordly_alpha
{
    partial class FlashcardMode
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
            flashcardBtn = new RoundedButton();
            previousCardBtn = new RoundedButton();
            nextCardBtn = new RoundedButton();
            EndPnl = new RoundedPanel();
            backBtn = new RoundedButton();
            againBtn = new RoundedButton();
            countLbl = new Label();
            EndPnl.SuspendLayout();
            SuspendLayout();
            // 
            // flashcardBtn
            // 
            flashcardBtn.BackColor = Color.GreenYellow;
            flashcardBtn.CausesValidation = false;
            flashcardBtn.FlatAppearance.BorderColor = Color.GreenYellow;
            flashcardBtn.FlatAppearance.BorderSize = 0;
            flashcardBtn.FlatStyle = FlatStyle.Flat;
            flashcardBtn.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            flashcardBtn.Location = new Point(200, 50);
            flashcardBtn.Name = "flashcardBtn";
            flashcardBtn.Size = new Size(650, 550);
            flashcardBtn.TabIndex = 0;
            flashcardBtn.TabStop = false;
            flashcardBtn.UseVisualStyleBackColor = false;
            flashcardBtn.Click += FlashcardBtn_Click;
            flashcardBtn.PreviewKeyDown += FlashcardMode_PreviewKeyDown;
            // 
            // previousCardBtn
            // 
            previousCardBtn.BackColor = Color.White;
            previousCardBtn.CausesValidation = false;
            previousCardBtn.FlatAppearance.BorderColor = Color.White;
            previousCardBtn.FlatAppearance.BorderSize = 0;
            previousCardBtn.FlatStyle = FlatStyle.Flat;
            previousCardBtn.Image = Properties.Resources.arrowLeft;
            previousCardBtn.Location = new Point(100, 250);
            previousCardBtn.Name = "previousCardBtn";
            previousCardBtn.Size = new Size(75, 150);
            previousCardBtn.TabIndex = 0;
            previousCardBtn.TabStop = false;
            previousCardBtn.UseVisualStyleBackColor = true;
            previousCardBtn.Click += PreviousCardBtn_Click;
            previousCardBtn.PreviewKeyDown += FlashcardMode_PreviewKeyDown;
            // 
            // nextCardBtn
            // 
            nextCardBtn.BackColor = Color.White;
            nextCardBtn.CausesValidation = false;
            nextCardBtn.FlatAppearance.BorderColor = Color.White;
            nextCardBtn.FlatAppearance.BorderSize = 0;
            nextCardBtn.FlatStyle = FlatStyle.Flat;
            nextCardBtn.Image = Properties.Resources.arrowRight;
            nextCardBtn.Location = new Point(875, 250);
            nextCardBtn.Name = "nextCardBtn";
            nextCardBtn.Size = new Size(75, 150);
            nextCardBtn.TabIndex = 0;
            nextCardBtn.TabStop = false;
            nextCardBtn.UseVisualStyleBackColor = true;
            nextCardBtn.Click += NextCardBtn_Click;
            nextCardBtn.PreviewKeyDown += FlashcardMode_PreviewKeyDown;
            // 
            // EndPnl
            // 
            EndPnl.BackColor = SystemColors.InactiveCaption;
            EndPnl.Controls.Add(backBtn);
            EndPnl.Controls.Add(againBtn);
            EndPnl.Location = new Point(75, 50);
            EndPnl.Name = "EndPnl";
            EndPnl.Size = new Size(900, 550);
            EndPnl.TabIndex = 3;
            EndPnl.Visible = false;
            // 
            // backBtn
            // 
            backBtn.BackColor = SystemColors.HotTrack;
            backBtn.CausesValidation = false;
            backBtn.FlatAppearance.BorderColor = SystemColors.HotTrack;
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backBtn.Location = new Point(475, 425);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(300, 80);
            backBtn.TabIndex = 1;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = false;
            // 
            // againBtn
            // 
            againBtn.BackColor = SystemColors.HotTrack;
            againBtn.CausesValidation = false;
            againBtn.FlatAppearance.BorderColor = SystemColors.HotTrack;
            againBtn.FlatAppearance.BorderSize = 0;
            againBtn.FlatStyle = FlatStyle.Flat;
            againBtn.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            againBtn.Location = new Point(125, 425);
            againBtn.Name = "againBtn";
            againBtn.Size = new Size(300, 80);
            againBtn.TabIndex = 0;
            againBtn.Text = "Revise Again";
            againBtn.UseVisualStyleBackColor = false;
            againBtn.Click += AgainBtn_Click;
            // 
            // countLbl
            // 
            countLbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            countLbl.Location = new Point(75, 50);
            countLbl.Name = "countLbl";
            countLbl.Size = new Size(125, 50);
            countLbl.TabIndex = 4;
            countLbl.Text = "x / y";
            countLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FlashcardMode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 650);
            Controls.Add(EndPnl);
            Controls.Add(countLbl);
            Controls.Add(nextCardBtn);
            Controls.Add(previousCardBtn);
            Controls.Add(flashcardBtn);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "FlashcardMode";
            Text = "FlashcardMode";
            KeyDown += FlashcardMode_KeyDown;
            PreviewKeyDown += FlashcardMode_PreviewKeyDown;
            EndPnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private RoundedButton flashcardBtn;
        private RoundedButton previousCardBtn;
        private RoundedButton nextCardBtn;
        private RoundedPanel EndPnl;
        private RoundedButton againBtn;
        public  RoundedButton backBtn;
        private Label countLbl;
    }
}