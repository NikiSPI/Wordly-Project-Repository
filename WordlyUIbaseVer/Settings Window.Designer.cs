namespace Wordly_alpha

{
    partial class Settings_Window
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
            text1Opt1Lbl = new Label();
            switch1Opt2SBtn = new StylishComponents.SButton();
            switch1Opt1SBtn = new StylishComponents.SButton();
            contentPnl = new RoundedComponents.RoundedPanel();
            contentKeybindsPnl = new Panel();
            label12 = new Label();
            label13 = new Label();
            label10 = new Label();
            label11 = new Label();
            label8 = new Label();
            label9 = new Label();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            kbCorrMarkAsIncorrectLbl = new Label();
            kbCorrShowPreviousCardLbl = new Label();
            kbCorrMarkAsCorrectLbl = new Label();
            kbCorrFlipCardLbl = new Label();
            kbTextShowPreviousCardLbl = new Label();
            kbTextMarkAsIncorrectLbl = new Label();
            kbTextMarkAsCorrectLbl = new Label();
            kbTextFlashcardTitleLbl = new Label();
            kbTextFlipCardLbl = new Label();
            kbTitleSepPnl = new RoundedComponents.RoundedPanel();
            label1 = new Label();
            text1Opt2Lbl = new Label();
            switchable1Opt1Lbl = new Label();
            backPnl = new Panel();
            spacingPnl = new Panel();
            contentPnl.SuspendLayout();
            contentKeybindsPnl.SuspendLayout();
            backPnl.SuspendLayout();
            SuspendLayout();
            // 
            // text1Opt1Lbl
            // 
            text1Opt1Lbl.Font = new Font("Candara", 24F);
            text1Opt1Lbl.ForeColor = Color.FromArgb(210, 220, 220);
            text1Opt1Lbl.Location = new Point(40, 30);
            text1Opt1Lbl.Name = "text1Opt1Lbl";
            text1Opt1Lbl.Size = new Size(580, 80);
            text1Opt1Lbl.TabIndex = 5;
            text1Opt1Lbl.Text = "Answer with:";
            text1Opt1Lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // switch1Opt2SBtn
            // 
            switch1Opt2SBtn.Location = new Point(630, 132);
            switch1Opt2SBtn.MinimumSize = new Size(45, 22);
            switch1Opt2SBtn.Name = "switch1Opt2SBtn";
            switch1Opt2SBtn.OffBackColor = Color.Gray;
            switch1Opt2SBtn.OffToggleColor = Color.Gainsboro;
            switch1Opt2SBtn.OnBackColor = Color.FromArgb(150, 180, 180);
            switch1Opt2SBtn.OnToggleColor = Color.WhiteSmoke;
            switch1Opt2SBtn.Size = new Size(80, 36);
            switch1Opt2SBtn.TabIndex = 7;
            switch1Opt2SBtn.UseVisualStyleBackColor = true;
            switch1Opt2SBtn.CheckedChanged += switch1Opt2SBtn_CheckedChanged;
            // 
            // switch1Opt1SBtn
            // 
            switch1Opt1SBtn.Checked = true;
            switch1Opt1SBtn.CheckState = CheckState.Checked;
            switch1Opt1SBtn.Location = new Point(630, 52);
            switch1Opt1SBtn.MinimumSize = new Size(45, 22);
            switch1Opt1SBtn.Name = "switch1Opt1SBtn";
            switch1Opt1SBtn.OffBackColor = SystemColors.WindowFrame;
            switch1Opt1SBtn.OffToggleColor = Color.Gainsboro;
            switch1Opt1SBtn.OnBackColor = Color.FromArgb(100, 110, 110);
            switch1Opt1SBtn.OnToggleColor = Color.WhiteSmoke;
            switch1Opt1SBtn.Size = new Size(80, 36);
            switch1Opt1SBtn.TabIndex = 3;
            switch1Opt1SBtn.UseVisualStyleBackColor = true;
            switch1Opt1SBtn.CheckedChanged += switch1Opt1SBtn_CheckedChanged;
            // 
            // contentPnl
            // 
            contentPnl.BackColor = Color.FromArgb(50, 50, 50);
            contentPnl.Controls.Add(contentKeybindsPnl);
            contentPnl.Controls.Add(switch1Opt2SBtn);
            contentPnl.Controls.Add(switch1Opt1SBtn);
            contentPnl.Controls.Add(text1Opt2Lbl);
            contentPnl.Controls.Add(switchable1Opt1Lbl);
            contentPnl.Controls.Add(text1Opt1Lbl);
            contentPnl.Location = new Point(150, 50);
            contentPnl.Name = "contentPnl";
            contentPnl.Size = new Size(750, 1500);
            contentPnl.TabIndex = 10;
            // 
            // contentKeybindsPnl
            // 
            contentKeybindsPnl.Controls.Add(label12);
            contentKeybindsPnl.Controls.Add(label13);
            contentKeybindsPnl.Controls.Add(label10);
            contentKeybindsPnl.Controls.Add(label11);
            contentKeybindsPnl.Controls.Add(label8);
            contentKeybindsPnl.Controls.Add(label9);
            contentKeybindsPnl.Controls.Add(label6);
            contentKeybindsPnl.Controls.Add(label7);
            contentKeybindsPnl.Controls.Add(label5);
            contentKeybindsPnl.Controls.Add(label3);
            contentKeybindsPnl.Controls.Add(label4);
            contentKeybindsPnl.Controls.Add(label2);
            contentKeybindsPnl.Controls.Add(kbCorrMarkAsIncorrectLbl);
            contentKeybindsPnl.Controls.Add(kbCorrShowPreviousCardLbl);
            contentKeybindsPnl.Controls.Add(kbCorrMarkAsCorrectLbl);
            contentKeybindsPnl.Controls.Add(kbCorrFlipCardLbl);
            contentKeybindsPnl.Controls.Add(kbTextShowPreviousCardLbl);
            contentKeybindsPnl.Controls.Add(kbTextMarkAsIncorrectLbl);
            contentKeybindsPnl.Controls.Add(kbTextMarkAsCorrectLbl);
            contentKeybindsPnl.Controls.Add(kbTextFlashcardTitleLbl);
            contentKeybindsPnl.Controls.Add(kbTextFlipCardLbl);
            contentKeybindsPnl.Controls.Add(kbTitleSepPnl);
            contentKeybindsPnl.Controls.Add(label1);
            contentKeybindsPnl.Location = new Point(0, 220);
            contentKeybindsPnl.Name = "contentKeybindsPnl";
            contentKeybindsPnl.Size = new Size(750, 948);
            contentKeybindsPnl.TabIndex = 11;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(200, 220, 220);
            label12.Location = new Point(510, 585);
            label12.Name = "label12";
            label12.Size = new Size(200, 65);
            label12.TabIndex = 31;
            label12.Text = "Ctrl + Enter";
            label12.TextAlign = ContentAlignment.TopRight;
            // 
            // label13
            // 
            label13.Font = new Font("Candara", 24F);
            label13.ForeColor = Color.FromArgb(210, 220, 220);
            label13.Location = new Point(40, 585);
            label13.Name = "label13";
            label13.Size = new Size(580, 65);
            label13.TabIndex = 30;
            label13.Text = "I was Correct";
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(200, 220, 220);
            label10.Location = new Point(510, 870);
            label10.Name = "label10";
            label10.Size = new Size(200, 65);
            label10.TabIndex = 29;
            label10.Text = "Ctrl + Tab";
            label10.TextAlign = ContentAlignment.TopRight;
            // 
            // label11
            // 
            label11.Font = new Font("Candara", 24F);
            label11.ForeColor = Color.FromArgb(210, 220, 220);
            label11.Location = new Point(40, 870);
            label11.Name = "label11";
            label11.Size = new Size(580, 65);
            label11.TabIndex = 28;
            label11.Text = "Switch Panels";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(200, 220, 220);
            label8.Location = new Point(510, 805);
            label8.Name = "label8";
            label8.Size = new Size(200, 65);
            label8.TabIndex = 27;
            label8.Text = "Ctrl + Enter";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // label9
            // 
            label9.Font = new Font("Candara", 24F);
            label9.ForeColor = Color.FromArgb(210, 220, 220);
            label9.Location = new Point(40, 805);
            label9.Name = "label9";
            label9.Size = new Size(580, 65);
            label9.TabIndex = 26;
            label9.Text = "Submit Answers";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(200, 220, 220);
            label6.Location = new Point(410, 740);
            label6.Name = "label6";
            label6.Size = new Size(300, 65);
            label6.TabIndex = 25;
            label6.Text = "Tab / Arrow Keys";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // label7
            // 
            label7.Font = new Font("Candara", 24F);
            label7.ForeColor = Color.FromArgb(210, 220, 220);
            label7.Location = new Point(40, 740);
            label7.Name = "label7";
            label7.Size = new Size(580, 65);
            label7.TabIndex = 24;
            label7.Text = "Navigate";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(220, 230, 230);
            label5.Location = new Point(40, 655);
            label5.Name = "label5";
            label5.Size = new Size(580, 80);
            label5.TabIndex = 23;
            label5.Text = "Exam Mode";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(200, 220, 220);
            label3.Location = new Point(510, 520);
            label3.Name = "label3";
            label3.Size = new Size(200, 65);
            label3.TabIndex = 22;
            label3.Text = "Enter";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // label4
            // 
            label4.Font = new Font("Candara", 24F);
            label4.ForeColor = Color.FromArgb(210, 220, 220);
            label4.Location = new Point(40, 520);
            label4.Name = "label4";
            label4.Size = new Size(580, 65);
            label4.TabIndex = 21;
            label4.Text = "Answer / Continue";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(220, 230, 230);
            label2.Location = new Point(40, 435);
            label2.Name = "label2";
            label2.Size = new Size(580, 80);
            label2.TabIndex = 20;
            label2.Text = "Write Mode";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // kbCorrMarkAsIncorrectLbl
            // 
            kbCorrMarkAsIncorrectLbl.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            kbCorrMarkAsIncorrectLbl.ForeColor = Color.FromArgb(200, 220, 220);
            kbCorrMarkAsIncorrectLbl.Location = new Point(510, 300);
            kbCorrMarkAsIncorrectLbl.Name = "kbCorrMarkAsIncorrectLbl";
            kbCorrMarkAsIncorrectLbl.Size = new Size(200, 65);
            kbCorrMarkAsIncorrectLbl.TabIndex = 19;
            kbCorrMarkAsIncorrectLbl.Text = "Down Arrow";
            kbCorrMarkAsIncorrectLbl.TextAlign = ContentAlignment.TopRight;
            // 
            // kbCorrShowPreviousCardLbl
            // 
            kbCorrShowPreviousCardLbl.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            kbCorrShowPreviousCardLbl.ForeColor = Color.FromArgb(200, 220, 220);
            kbCorrShowPreviousCardLbl.Location = new Point(510, 365);
            kbCorrShowPreviousCardLbl.Name = "kbCorrShowPreviousCardLbl";
            kbCorrShowPreviousCardLbl.Size = new Size(200, 65);
            kbCorrShowPreviousCardLbl.TabIndex = 18;
            kbCorrShowPreviousCardLbl.Text = "Left Arrow";
            kbCorrShowPreviousCardLbl.TextAlign = ContentAlignment.TopRight;
            // 
            // kbCorrMarkAsCorrectLbl
            // 
            kbCorrMarkAsCorrectLbl.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            kbCorrMarkAsCorrectLbl.ForeColor = Color.FromArgb(200, 220, 220);
            kbCorrMarkAsCorrectLbl.Location = new Point(510, 235);
            kbCorrMarkAsCorrectLbl.Name = "kbCorrMarkAsCorrectLbl";
            kbCorrMarkAsCorrectLbl.Size = new Size(200, 65);
            kbCorrMarkAsCorrectLbl.TabIndex = 17;
            kbCorrMarkAsCorrectLbl.Text = "Up Arrow";
            kbCorrMarkAsCorrectLbl.TextAlign = ContentAlignment.TopRight;
            // 
            // kbCorrFlipCardLbl
            // 
            kbCorrFlipCardLbl.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            kbCorrFlipCardLbl.ForeColor = Color.FromArgb(200, 220, 220);
            kbCorrFlipCardLbl.Location = new Point(510, 170);
            kbCorrFlipCardLbl.Name = "kbCorrFlipCardLbl";
            kbCorrFlipCardLbl.Size = new Size(200, 65);
            kbCorrFlipCardLbl.TabIndex = 16;
            kbCorrFlipCardLbl.Text = "Space";
            kbCorrFlipCardLbl.TextAlign = ContentAlignment.TopRight;
            // 
            // kbTextShowPreviousCardLbl
            // 
            kbTextShowPreviousCardLbl.Font = new Font("Candara", 24F);
            kbTextShowPreviousCardLbl.ForeColor = Color.FromArgb(210, 220, 220);
            kbTextShowPreviousCardLbl.Location = new Point(40, 365);
            kbTextShowPreviousCardLbl.Name = "kbTextShowPreviousCardLbl";
            kbTextShowPreviousCardLbl.Size = new Size(580, 65);
            kbTextShowPreviousCardLbl.TabIndex = 15;
            kbTextShowPreviousCardLbl.Text = "Show Previous Card";
            // 
            // kbTextMarkAsIncorrectLbl
            // 
            kbTextMarkAsIncorrectLbl.Font = new Font("Candara", 24F);
            kbTextMarkAsIncorrectLbl.ForeColor = Color.FromArgb(210, 220, 220);
            kbTextMarkAsIncorrectLbl.Location = new Point(40, 300);
            kbTextMarkAsIncorrectLbl.Name = "kbTextMarkAsIncorrectLbl";
            kbTextMarkAsIncorrectLbl.Size = new Size(580, 65);
            kbTextMarkAsIncorrectLbl.TabIndex = 14;
            kbTextMarkAsIncorrectLbl.Text = "Mark as Incorrect";
            // 
            // kbTextMarkAsCorrectLbl
            // 
            kbTextMarkAsCorrectLbl.Font = new Font("Candara", 24F);
            kbTextMarkAsCorrectLbl.ForeColor = Color.FromArgb(210, 220, 220);
            kbTextMarkAsCorrectLbl.Location = new Point(40, 235);
            kbTextMarkAsCorrectLbl.Name = "kbTextMarkAsCorrectLbl";
            kbTextMarkAsCorrectLbl.Size = new Size(580, 65);
            kbTextMarkAsCorrectLbl.TabIndex = 13;
            kbTextMarkAsCorrectLbl.Text = "Mark as Correct";
            // 
            // kbTextFlashcardTitleLbl
            // 
            kbTextFlashcardTitleLbl.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kbTextFlashcardTitleLbl.ForeColor = Color.FromArgb(220, 230, 230);
            kbTextFlashcardTitleLbl.Location = new Point(40, 85);
            kbTextFlashcardTitleLbl.Name = "kbTextFlashcardTitleLbl";
            kbTextFlashcardTitleLbl.Size = new Size(580, 80);
            kbTextFlashcardTitleLbl.TabIndex = 12;
            kbTextFlashcardTitleLbl.Text = "Flashcard Mode";
            kbTextFlashcardTitleLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // kbTextFlipCardLbl
            // 
            kbTextFlipCardLbl.Font = new Font("Candara", 24F);
            kbTextFlipCardLbl.ForeColor = Color.FromArgb(210, 220, 220);
            kbTextFlipCardLbl.Location = new Point(40, 170);
            kbTextFlipCardLbl.Name = "kbTextFlipCardLbl";
            kbTextFlipCardLbl.Size = new Size(580, 65);
            kbTextFlipCardLbl.TabIndex = 11;
            kbTextFlipCardLbl.Text = "Flip Card";
            // 
            // kbTitleSepPnl
            // 
            kbTitleSepPnl.BackColor = Color.FromArgb(210, 250, 250);
            kbTitleSepPnl.Location = new Point(190, 40);
            kbTitleSepPnl.Name = "kbTitleSepPnl";
            kbTitleSepPnl.Size = new Size(520, 5);
            kbTitleSepPnl.TabIndex = 7;
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(210, 250, 250);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(25, 0);
            label1.Name = "label1";
            label1.Size = new Size(195, 80);
            label1.TabIndex = 6;
            label1.Text = "Key Binds";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // text1Opt2Lbl
            // 
            text1Opt2Lbl.Font = new Font("Candara", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text1Opt2Lbl.ForeColor = Color.FromArgb(210, 220, 220);
            text1Opt2Lbl.Location = new Point(40, 110);
            text1Opt2Lbl.Name = "text1Opt2Lbl";
            text1Opt2Lbl.Size = new Size(580, 80);
            text1Opt2Lbl.TabIndex = 10;
            text1Opt2Lbl.Text = "Answer with both:  (only exam mode)";
            text1Opt2Lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // switchable1Opt1Lbl
            // 
            switchable1Opt1Lbl.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            switchable1Opt1Lbl.ForeColor = Color.FromArgb(200, 220, 220);
            switchable1Opt1Lbl.Location = new Point(465, 30);
            switchable1Opt1Lbl.Name = "switchable1Opt1Lbl";
            switchable1Opt1Lbl.Size = new Size(160, 75);
            switchable1Opt1Lbl.TabIndex = 4;
            switchable1Opt1Lbl.Text = "Meaning";
            switchable1Opt1Lbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // backPnl
            // 
            backPnl.AutoScroll = true;
            backPnl.Controls.Add(spacingPnl);
            backPnl.Controls.Add(contentPnl);
            backPnl.Dock = DockStyle.Fill;
            backPnl.Location = new Point(0, 0);
            backPnl.Name = "backPnl";
            backPnl.Size = new Size(1050, 650);
            backPnl.TabIndex = 11;
            // 
            // spacingPnl
            // 
            spacingPnl.Location = new Point(0, 1550);
            spacingPnl.Name = "spacingPnl";
            spacingPnl.Size = new Size(50, 50);
            spacingPnl.TabIndex = 11;
            // 
            // Settings_Window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            ClientSize = new Size(1050, 650);
            Controls.Add(backPnl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Settings_Window";
            Text = "Settings_Window";
            contentPnl.ResumeLayout(false);
            contentKeybindsPnl.ResumeLayout(false);
            backPnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label text1Opt1Lbl;
        private StylishComponents.SButton switch1Opt2SBtn;
        private StylishComponents.SButton switch1Opt1SBtn;
        private RoundedComponents.RoundedPanel contentPnl;
        private Panel backPnl;
        private Panel spacingPnl;
        private Label text1Opt2Lbl;
        private Label switchable1Opt1Lbl;
        private Panel contentKeybindsPnl;
        private RoundedComponents.RoundedPanel kbTitleSepPnl;
        private Label label1;
        private Label kbTextFlipCardLbl;
        private Label kbTextFlashcardTitleLbl;
        private Label kbTextMarkAsCorrectLbl;
        private Label kbTextShowPreviousCardLbl;
        private Label kbTextMarkAsIncorrectLbl;
        private Label kbCorrFlipCardLbl;
        private Label kbCorrMarkAsIncorrectLbl;
        private Label kbCorrShowPreviousCardLbl;
        private Label kbCorrMarkAsCorrectLbl;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
    }
}