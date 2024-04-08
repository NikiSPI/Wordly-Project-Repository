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
            endPnl = new RoundedPanel();
            backBtn = new RoundedButton();
            againBtn = new RoundedButton();
            countLbl = new Label();
            endPnl.SuspendLayout();
            SuspendLayout();
            // 
            // flashcardBtn
            // 
            flashcardBtn.BackColor = Color.FromArgb(120, 130, 130);
            flashcardBtn.CausesValidation = false;
            flashcardBtn.FlatAppearance.BorderColor = Color.FromArgb(120, 130, 130);
            flashcardBtn.FlatAppearance.BorderSize = 0;
            flashcardBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 110, 110);
            flashcardBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(115, 125, 125);
            flashcardBtn.FlatStyle = FlatStyle.Flat;
            flashcardBtn.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            flashcardBtn.ForeColor = Color.FromArgb(240, 245, 245);
            flashcardBtn.Location = new Point(200, 50);
            flashcardBtn.Name = "flashcardBtn";
            flashcardBtn.Size = new Size(650, 550);
            flashcardBtn.TabIndex = 0;
            flashcardBtn.TabStop = false;
            flashcardBtn.Text = "sth";
            flashcardBtn.UseMnemonic = false;
            flashcardBtn.UseVisualStyleBackColor = false;
            flashcardBtn.Click += FlashcardBtn_Click;
            flashcardBtn.PreviewKeyDown += FlashcardMode_PreviewKeyDown;
            // 
            // previousCardBtn
            // 
            previousCardBtn.BackColor = Color.FromArgb(190, 200, 200);
            previousCardBtn.CausesValidation = false;
            previousCardBtn.FlatAppearance.BorderColor = Color.FromArgb(190, 200, 200);
            previousCardBtn.FlatAppearance.BorderSize = 0;
            previousCardBtn.FlatStyle = FlatStyle.Flat;
            previousCardBtn.Image = Properties.Resources.arrowLeft;
            previousCardBtn.Location = new Point(120, 280);
            previousCardBtn.Name = "previousCardBtn";
            previousCardBtn.Size = new Size(60, 90);
            previousCardBtn.TabIndex = 0;
            previousCardBtn.TabStop = false;
            previousCardBtn.UseMnemonic = false;
            previousCardBtn.UseVisualStyleBackColor = false;
            previousCardBtn.Click += PreviousCardBtn_Click;
            previousCardBtn.PreviewKeyDown += FlashcardMode_PreviewKeyDown;
            // 
            // nextCardBtn
            // 
            nextCardBtn.BackColor = Color.FromArgb(190, 200, 200);
            nextCardBtn.CausesValidation = false;
            nextCardBtn.FlatAppearance.BorderColor = Color.FromArgb(190, 200, 200);
            nextCardBtn.FlatAppearance.BorderSize = 0;
            nextCardBtn.FlatStyle = FlatStyle.Flat;
            nextCardBtn.Image = Properties.Resources.arrowRight;
            nextCardBtn.Location = new Point(870, 280);
            nextCardBtn.Name = "nextCardBtn";
            nextCardBtn.Size = new Size(60, 90);
            nextCardBtn.TabIndex = 0;
            nextCardBtn.TabStop = false;
            nextCardBtn.UseMnemonic = false;
            nextCardBtn.UseVisualStyleBackColor = false;
            nextCardBtn.Click += NextCardBtn_Click;
            nextCardBtn.PreviewKeyDown += FlashcardMode_PreviewKeyDown;
            // 
            // endPnl
            // 
            endPnl.BackColor = Color.FromArgb(70, 70, 70);
            endPnl.Controls.Add(backBtn);
            endPnl.Controls.Add(againBtn);
            endPnl.Location = new Point(75, 50);
            endPnl.Name = "endPnl";
            endPnl.Size = new Size(900, 550);
            endPnl.TabIndex = 3;
            endPnl.Visible = false;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.FromArgb(55, 55, 55);
            backBtn.CausesValidation = false;
            backBtn.FlatAppearance.BorderColor = Color.FromArgb(55, 55, 55);
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 85, 85);
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backBtn.ForeColor = Color.FromArgb(210, 220, 220);
            backBtn.Location = new Point(475, 425);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(300, 80);
            backBtn.TabIndex = 1;
            backBtn.TabStop = false;
            backBtn.Text = "Back";
            backBtn.UseMnemonic = false;
            backBtn.UseVisualStyleBackColor = false;
            // 
            // againBtn
            // 
            againBtn.BackColor = Color.FromArgb(55, 55, 55);
            againBtn.CausesValidation = false;
            againBtn.FlatAppearance.BorderColor = Color.FromArgb(55, 55, 55);
            againBtn.FlatAppearance.BorderSize = 0;
            againBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 85, 85);
            againBtn.FlatStyle = FlatStyle.Flat;
            againBtn.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            againBtn.ForeColor = Color.FromArgb(210, 220, 220);
            againBtn.Location = new Point(125, 425);
            againBtn.Name = "againBtn";
            againBtn.Size = new Size(300, 80);
            againBtn.TabIndex = 0;
            againBtn.TabStop = false;
            againBtn.Text = "Revise Again";
            againBtn.UseMnemonic = false;
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
            BackColor = Color.FromArgb(60, 60, 60);
            ClientSize = new Size(1050, 650);
            Controls.Add(endPnl);
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
            endPnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private RoundedButton flashcardBtn;
        private RoundedButton previousCardBtn;
        private RoundedButton nextCardBtn;
        private RoundedPanel endPnl;
        private RoundedButton againBtn;
        public  RoundedButton backBtn;
        private Label countLbl;
    }
}