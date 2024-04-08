using RoundedComponents;

namespace Wordly_alpha
{
    partial class QuizWindow
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
            OptionsPnl = new Panel();
            Option4Btn = new RoundedButton();
            Option3Btn = new RoundedButton();
            Option2Btn = new RoundedButton();
            Option1Btn = new RoundedButton();
            wordListPnl = new RoundedPanel();
            wordContainerPnl = new Panel();
            wordListUnlockScrollPnl = new Panel();
            wordListTitlePnl = new Panel();
            wordListTitleSepPnl = new RoundedPanel();
            wordListTitleMeaningLbl = new Label();
            wordListTitleTermLbl = new Label();
            OptionsPnl.SuspendLayout();
            wordListPnl.SuspendLayout();
            wordContainerPnl.SuspendLayout();
            wordListTitlePnl.SuspendLayout();
            SuspendLayout();
            // 
            // OptionsPnl
            // 
            OptionsPnl.Anchor = AnchorStyles.None;
            OptionsPnl.Controls.Add(Option4Btn);
            OptionsPnl.Controls.Add(Option3Btn);
            OptionsPnl.Controls.Add(Option2Btn);
            OptionsPnl.Controls.Add(Option1Btn);
            OptionsPnl.Location = new Point(91, 110);
            OptionsPnl.Name = "OptionsPnl";
            OptionsPnl.Size = new Size(300, 430);
            OptionsPnl.TabIndex = 0;
            // 
            // Option4Btn
            // 
            Option4Btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Option4Btn.BackColor = Color.FromArgb(45, 45, 45);
            Option4Btn.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
            Option4Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 75, 75);
            Option4Btn.FlatStyle = FlatStyle.Flat;
            Option4Btn.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Option4Btn.ForeColor = Color.FromArgb(230, 240, 240);
            Option4Btn.Location = new Point(0, 330);
            Option4Btn.Name = "Option4Btn";
            Option4Btn.Size = new Size(300, 100);
            Option4Btn.TabIndex = 3;
            Option4Btn.TabStop = false;
            Option4Btn.Text = "Custom";
            Option4Btn.UseMnemonic = false;
            Option4Btn.UseVisualStyleBackColor = false;
            // 
            // Option3Btn
            // 
            Option3Btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Option3Btn.BackColor = Color.FromArgb(45, 45, 45);
            Option3Btn.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
            Option3Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 75, 75);
            Option3Btn.FlatStyle = FlatStyle.Flat;
            Option3Btn.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Option3Btn.ForeColor = Color.FromArgb(230, 240, 240);
            Option3Btn.Location = new Point(0, 220);
            Option3Btn.Name = "Option3Btn";
            Option3Btn.Size = new Size(300, 100);
            Option3Btn.TabIndex = 2;
            Option3Btn.TabStop = false;
            Option3Btn.Text = "Exam Mode";
            Option3Btn.UseMnemonic = false;
            Option3Btn.UseVisualStyleBackColor = false;
            Option3Btn.Click += Option3Btn_Click;
            // 
            // Option2Btn
            // 
            Option2Btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Option2Btn.BackColor = Color.FromArgb(45, 45, 45);
            Option2Btn.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
            Option2Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 75, 75);
            Option2Btn.FlatStyle = FlatStyle.Flat;
            Option2Btn.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Option2Btn.ForeColor = Color.FromArgb(230, 240, 240);
            Option2Btn.Location = new Point(0, 110);
            Option2Btn.Name = "Option2Btn";
            Option2Btn.Size = new Size(300, 100);
            Option2Btn.TabIndex = 1;
            Option2Btn.TabStop = false;
            Option2Btn.Text = "Write Mode";
            Option2Btn.UseMnemonic = false;
            Option2Btn.UseVisualStyleBackColor = false;
            Option2Btn.Click += Option2Btn_Click;
            // 
            // Option1Btn
            // 
            Option1Btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Option1Btn.BackColor = Color.FromArgb(45, 45, 45);
            Option1Btn.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
            Option1Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 75, 75);
            Option1Btn.FlatStyle = FlatStyle.Flat;
            Option1Btn.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Option1Btn.ForeColor = Color.FromArgb(230, 240, 240);
            Option1Btn.Location = new Point(0, 0);
            Option1Btn.Name = "Option1Btn";
            Option1Btn.Size = new Size(300, 100);
            Option1Btn.TabIndex = 0;
            Option1Btn.TabStop = false;
            Option1Btn.Text = "Flashcards";
            Option1Btn.UseMnemonic = false;
            Option1Btn.UseVisualStyleBackColor = false;
            Option1Btn.Click += Option1Btn_Click;
            // 
            // wordListPnl
            // 
            wordListPnl.Anchor = AnchorStyles.None;
            wordListPnl.AutoScroll = true;
            wordListPnl.BackColor = Color.FromArgb(50, 50, 50);
            wordListPnl.Controls.Add(wordContainerPnl);
            wordListPnl.Controls.Add(wordListTitlePnl);
            wordListPnl.Location = new Point(483, 50);
            wordListPnl.Name = "wordListPnl";
            wordListPnl.Size = new Size(517, 550);
            wordListPnl.TabIndex = 2;
            // 
            // wordContainerPnl
            // 
            wordContainerPnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            wordContainerPnl.AutoScroll = true;
            wordContainerPnl.BackColor = Color.FromArgb(50, 50, 50);
            wordContainerPnl.Controls.Add(wordListUnlockScrollPnl);
            wordContainerPnl.Location = new Point(0, 90);
            wordContainerPnl.Name = "wordContainerPnl";
            wordContainerPnl.Size = new Size(517, 460);
            wordContainerPnl.TabIndex = 1;
            // 
            // wordListUnlockScrollPnl
            // 
            wordListUnlockScrollPnl.Location = new Point(499, 460);
            wordListUnlockScrollPnl.Name = "wordListUnlockScrollPnl";
            wordListUnlockScrollPnl.Size = new Size(1, 1);
            wordListUnlockScrollPnl.TabIndex = 0;
            // 
            // wordListTitlePnl
            // 
            wordListTitlePnl.BackColor = Color.FromArgb(45, 45, 45);
            wordListTitlePnl.Controls.Add(wordListTitleSepPnl);
            wordListTitlePnl.Controls.Add(wordListTitleMeaningLbl);
            wordListTitlePnl.Controls.Add(wordListTitleTermLbl);
            wordListTitlePnl.Dock = DockStyle.Top;
            wordListTitlePnl.Location = new Point(0, 0);
            wordListTitlePnl.Name = "wordListTitlePnl";
            wordListTitlePnl.Size = new Size(517, 90);
            wordListTitlePnl.TabIndex = 0;
            // 
            // wordListTitleSepPnl
            // 
            wordListTitleSepPnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            wordListTitleSepPnl.BackColor = Color.Black;
            wordListTitleSepPnl.Location = new Point(248, 7);
            wordListTitleSepPnl.Name = "wordListTitleSepPnl";
            wordListTitleSepPnl.Size = new Size(5, 76);
            wordListTitleSepPnl.TabIndex = 1;
            // 
            // wordListTitleMeaningLbl
            // 
            wordListTitleMeaningLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            wordListTitleMeaningLbl.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            wordListTitleMeaningLbl.ForeColor = Color.FromArgb(200, 210, 210);
            wordListTitleMeaningLbl.Location = new Point(252, 0);
            wordListTitleMeaningLbl.Name = "wordListTitleMeaningLbl";
            wordListTitleMeaningLbl.Size = new Size(248, 90);
            wordListTitleMeaningLbl.TabIndex = 1;
            wordListTitleMeaningLbl.Text = "Meaning";
            wordListTitleMeaningLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // wordListTitleTermLbl
            // 
            wordListTitleTermLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            wordListTitleTermLbl.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            wordListTitleTermLbl.ForeColor = Color.FromArgb(200, 210, 210);
            wordListTitleTermLbl.Location = new Point(0, 0);
            wordListTitleTermLbl.Name = "wordListTitleTermLbl";
            wordListTitleTermLbl.Size = new Size(248, 90);
            wordListTitleTermLbl.TabIndex = 0;
            wordListTitleTermLbl.Text = "Term";
            wordListTitleTermLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // QuizWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            ClientSize = new Size(1050, 650);
            Controls.Add(wordListPnl);
            Controls.Add(OptionsPnl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "QuizWindow";
            OptionsPnl.ResumeLayout(false);
            wordListPnl.ResumeLayout(false);
            wordContainerPnl.ResumeLayout(false);
            wordListTitlePnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel OptionsPnl;
        private RoundedButton Option1Btn;
        private RoundedButton Option2Btn;
        private RoundedButton Option3Btn;
        private RoundedButton Option4Btn;
        private RoundedPanel wordListPnl;
        private Panel wordListTitlePnl;
        private Label wordListTitleTermLbl;
        private RoundedPanel wordListTitleSepPnl;
        private Label wordListTitleMeaningLbl;
        private Panel wordContainerPnl;
        private Panel wordListUnlockScrollPnl;
    }
}