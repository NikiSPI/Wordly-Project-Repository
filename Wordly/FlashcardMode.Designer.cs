namespace Wordly
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
            nextCardCBtn = new RoundedButton();
            endPnl = new RoundedPanel();
            resultLbl = new Label();
            backBtn = new RoundedButton();
            againBtn = new RoundedButton();
            countLbl = new Label();
            statPnl = new Panel();
            statCorrectPbx = new PictureBox();
            statIncorrectPbx = new PictureBox();
            statIncorrectLbl = new Label();
            statCorrectLbl = new Label();
            nextCardIBtn = new RoundedButton();
            endPnl.SuspendLayout();
            statPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)statCorrectPbx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)statIncorrectPbx).BeginInit();
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
            flashcardBtn.Font = new Font("Calibri", 44.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            flashcardBtn.ForeColor = Color.FromArgb(240, 245, 245);
            flashcardBtn.Location = new Point(200, 50);
            flashcardBtn.Name = "flashcardBtn";
            flashcardBtn.Size = new Size(650, 550);
            flashcardBtn.TabIndex = 0;
            flashcardBtn.TabStop = false;
            flashcardBtn.Text = "something";
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
            // nextCardCBtn
            // 
            nextCardCBtn.BackColor = Color.FromArgb(190, 250, 200);
            nextCardCBtn.CausesValidation = false;
            nextCardCBtn.FlatAppearance.BorderColor = Color.FromArgb(190, 250, 200);
            nextCardCBtn.FlatAppearance.BorderSize = 0;
            nextCardCBtn.FlatStyle = FlatStyle.Flat;
            nextCardCBtn.Image = Properties.Resources.arrowRight;
            nextCardCBtn.Location = new Point(870, 230);
            nextCardCBtn.Name = "nextCardCBtn";
            nextCardCBtn.Size = new Size(60, 90);
            nextCardCBtn.TabIndex = 0;
            nextCardCBtn.TabStop = false;
            nextCardCBtn.UseMnemonic = false;
            nextCardCBtn.UseVisualStyleBackColor = false;
            nextCardCBtn.Click += NextCardBtn_Click;
            nextCardCBtn.PreviewKeyDown += FlashcardMode_PreviewKeyDown;
            // 
            // endPnl
            // 
            endPnl.BackColor = Color.FromArgb(70, 70, 70);
            endPnl.Controls.Add(resultLbl);
            endPnl.Controls.Add(backBtn);
            endPnl.Controls.Add(againBtn);
            endPnl.Location = new Point(75, 50);
            endPnl.Name = "endPnl";
            endPnl.Size = new Size(900, 550);
            endPnl.TabIndex = 3;
            endPnl.Visible = false;
            // 
            // resultLbl
            // 
            resultLbl.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultLbl.ForeColor = Color.FromArgb(230, 240, 240);
            resultLbl.Location = new Point(200, 100);
            resultLbl.Name = "resultLbl";
            resultLbl.Size = new Size(500, 200);
            resultLbl.TabIndex = 2;
            resultLbl.Text = "100% 123/125";
            resultLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.FromArgb(55, 55, 55);
            backBtn.CausesValidation = false;
            backBtn.FlatAppearance.BorderColor = Color.FromArgb(55, 55, 55);
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 85, 85);
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Calibri", 26.25F, FontStyle.Bold);
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
            againBtn.Font = new Font("Calibri", 26.25F, FontStyle.Bold);
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
            countLbl.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            countLbl.ForeColor = Color.FromArgb(210, 220, 220);
            countLbl.Location = new Point(850, 50);
            countLbl.Name = "countLbl";
            countLbl.Size = new Size(200, 50);
            countLbl.TabIndex = 4;
            countLbl.Text = "123 / 456";
            countLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // statPnl
            // 
            statPnl.Controls.Add(statCorrectPbx);
            statPnl.Controls.Add(statIncorrectPbx);
            statPnl.Controls.Add(statIncorrectLbl);
            statPnl.Controls.Add(statCorrectLbl);
            statPnl.Location = new Point(50, 50);
            statPnl.Name = "statPnl";
            statPnl.Size = new Size(150, 120);
            statPnl.TabIndex = 4;
            // 
            // statCorrectPbx
            // 
            statCorrectPbx.Image = Properties.Resources.greenTick;
            statCorrectPbx.Location = new Point(0, 7);
            statCorrectPbx.Name = "statCorrectPbx";
            statCorrectPbx.Size = new Size(52, 52);
            statCorrectPbx.SizeMode = PictureBoxSizeMode.Zoom;
            statCorrectPbx.TabIndex = 0;
            statCorrectPbx.TabStop = false;
            // 
            // statIncorrectPbx
            // 
            statIncorrectPbx.Image = Properties.Resources.redCross;
            statIncorrectPbx.Location = new Point(7, 74);
            statIncorrectPbx.Name = "statIncorrectPbx";
            statIncorrectPbx.Size = new Size(38, 38);
            statIncorrectPbx.SizeMode = PictureBoxSizeMode.Zoom;
            statIncorrectPbx.TabIndex = 3;
            statIncorrectPbx.TabStop = false;
            // 
            // statIncorrectLbl
            // 
            statIncorrectLbl.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statIncorrectLbl.ForeColor = Color.FromArgb(210, 220, 220);
            statIncorrectLbl.Location = new Point(52, 60);
            statIncorrectLbl.Name = "statIncorrectLbl";
            statIncorrectLbl.Size = new Size(98, 60);
            statIncorrectLbl.TabIndex = 2;
            statIncorrectLbl.Text = "0";
            statIncorrectLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // statCorrectLbl
            // 
            statCorrectLbl.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statCorrectLbl.ForeColor = Color.FromArgb(210, 220, 220);
            statCorrectLbl.Location = new Point(52, 0);
            statCorrectLbl.Name = "statCorrectLbl";
            statCorrectLbl.Size = new Size(98, 60);
            statCorrectLbl.TabIndex = 1;
            statCorrectLbl.Text = "0";
            statCorrectLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nextCardIBtn
            // 
            nextCardIBtn.BackColor = Color.FromArgb(240, 200, 200);
            nextCardIBtn.CausesValidation = false;
            nextCardIBtn.FlatAppearance.BorderColor = Color.FromArgb(240, 200, 200);
            nextCardIBtn.FlatAppearance.BorderSize = 0;
            nextCardIBtn.FlatStyle = FlatStyle.Flat;
            nextCardIBtn.Image = Properties.Resources.arrowRight;
            nextCardIBtn.Location = new Point(870, 330);
            nextCardIBtn.Name = "nextCardIBtn";
            nextCardIBtn.Size = new Size(60, 90);
            nextCardIBtn.TabIndex = 5;
            nextCardIBtn.TabStop = false;
            nextCardIBtn.UseMnemonic = false;
            nextCardIBtn.UseVisualStyleBackColor = false;
            nextCardIBtn.Click += NextCardBtn_Click;
            // 
            // FlashcardMode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            ClientSize = new Size(1050, 650);
            Controls.Add(endPnl);
            Controls.Add(nextCardIBtn);
            Controls.Add(statPnl);
            Controls.Add(nextCardCBtn);
            Controls.Add(previousCardBtn);
            Controls.Add(flashcardBtn);
            Controls.Add(countLbl);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "FlashcardMode";
            Text = "FlashcardMode";
            KeyDown += FlashcardMode_KeyDown;
            PreviewKeyDown += FlashcardMode_PreviewKeyDown;
            endPnl.ResumeLayout(false);
            statPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)statCorrectPbx).EndInit();
            ((System.ComponentModel.ISupportInitialize)statIncorrectPbx).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RoundedButton flashcardBtn;
        private RoundedButton previousCardBtn;
        private RoundedButton nextCardCBtn;
        private RoundedPanel endPnl;
        private RoundedButton againBtn;
        public  RoundedButton backBtn;
        private Label countLbl;
        private Panel statPnl;
        private Label statCorrectLbl;
        private PictureBox statCorrectPbx;
        private Label statIncorrectLbl;
        private PictureBox statIncorrectPbx;
        private RoundedButton nextCardIBtn;
        private Label resultLbl;
    }
}