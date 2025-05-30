namespace Wordly
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
            label1 = new Label();
            Option4Btn = new RoundedButton();
            Option3Btn = new RoundedButton();
            Option2Btn = new RoundedButton();
            Option1Btn = new RoundedButton();
            wordListPnl = new RoundedPanel();
            wordContainerPnl = new Experimental.CustomScrollPanel();
            wordContainerInnerPnl = new RoundedPanel();
            wordListUnlockScrollPnl = new Panel();
            wordListTitlePnl = new RoundedPanel();
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
            OptionsPnl.Controls.Add(label1);
            OptionsPnl.Controls.Add(Option4Btn);
            OptionsPnl.Controls.Add(Option3Btn);
            OptionsPnl.Controls.Add(Option2Btn);
            OptionsPnl.Controls.Add(Option1Btn);
            OptionsPnl.Location = new Point(100, 110);
            OptionsPnl.Name = "OptionsPnl";
            OptionsPnl.Size = new Size(300, 430);
            OptionsPnl.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ActiveBorder;
            label1.Location = new Point(104, 405);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 10;
            label1.Text = "(coming soon)";
            // 
            // Option4Btn
            // 
            Option4Btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Option4Btn.BackColor = Color.FromArgb(60, 60, 60);
            Option4Btn.CornerRadius = 10;
            Option4Btn.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            Option4Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 90, 90);
            Option4Btn.FlatStyle = FlatStyle.Flat;
            Option4Btn.Font = new Font("Calibri", 26.25F, FontStyle.Bold);
            Option4Btn.ForeColor = Color.FromArgb(230, 240, 240);
            Option4Btn.Location = new Point(0, 333);
            Option4Btn.Name = "Option4Btn";
            Option4Btn.Size = new Size(300, 97);
            Option4Btn.TabIndex = 3;
            Option4Btn.TabStop = false;
            Option4Btn.Text = "Custom";
            Option4Btn.UseMnemonic = false;
            Option4Btn.UseVisualStyleBackColor = false;
            Option4Btn.Click += Option4Btn_Click;
            // 
            // Option3Btn
            // 
            Option3Btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Option3Btn.BackColor = Color.FromArgb(60, 60, 60);
            Option3Btn.CornerRadius = 10;
            Option3Btn.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            Option3Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 90, 90);
            Option3Btn.FlatStyle = FlatStyle.Flat;
            Option3Btn.Font = new Font("Calibri", 26.25F, FontStyle.Bold);
            Option3Btn.ForeColor = Color.FromArgb(230, 240, 240);
            Option3Btn.Location = new Point(0, 222);
            Option3Btn.Name = "Option3Btn";
            Option3Btn.Size = new Size(300, 97);
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
            Option2Btn.BackColor = Color.FromArgb(60, 60, 60);
            Option2Btn.CornerRadius = 10;
            Option2Btn.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            Option2Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 90, 90);
            Option2Btn.FlatStyle = FlatStyle.Flat;
            Option2Btn.Font = new Font("Calibri", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Option2Btn.ForeColor = Color.FromArgb(230, 240, 240);
            Option2Btn.Location = new Point(0, 111);
            Option2Btn.Name = "Option2Btn";
            Option2Btn.Size = new Size(300, 97);
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
            Option1Btn.BackColor = Color.FromArgb(60, 60, 60);
            Option1Btn.CornerRadius = 10;
            Option1Btn.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            Option1Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 90, 90);
            Option1Btn.FlatStyle = FlatStyle.Flat;
            Option1Btn.Font = new Font("Calibri", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Option1Btn.ForeColor = Color.FromArgb(230, 240, 240);
            Option1Btn.Location = new Point(0, 0);
            Option1Btn.Name = "Option1Btn";
            Option1Btn.Size = new Size(300, 97);
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
            wordListPnl.BackColor = Color.FromArgb(45, 45, 45);
            wordListPnl.Controls.Add(wordContainerPnl);
            wordListPnl.Controls.Add(wordListTitlePnl);
            wordListPnl.CornerRadius = 8;
            wordListPnl.Location = new Point(500, 50);
            wordListPnl.Name = "wordListPnl";
            wordListPnl.Size = new Size(510, 550);
            wordListPnl.TabIndex = 2;
            // 
            // wordContainerPnl
            // 
            wordContainerPnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            wordContainerPnl.AutoScroll = true;
            wordContainerPnl.BackColor = Color.FromArgb(45, 45, 45);
            wordContainerPnl.Controls.Add(wordContainerInnerPnl);
            wordContainerPnl.Controls.Add(wordListUnlockScrollPnl);
            wordContainerPnl.Location = new Point(0, 90);
            wordContainerPnl.Name = "wordContainerPnl";
            wordContainerPnl.PanelRadius = 10;
            wordContainerPnl.Size = new Size(510, 460);
            wordContainerPnl.TabIndex = 1;
            wordContainerPnl.ThumbColor = Color.FromArgb(210, 220, 220);
            wordContainerPnl.ThumbColorChange_Hold = 40;
            wordContainerPnl.ThumbColorChange_Hover = 30;
            wordContainerPnl.ThumbHoldEnlargement = new Size(1, 1);
            wordContainerPnl.ThumbMargin = new Size(5, 8);
            wordContainerPnl.ThumbMinHeight = 40;
            wordContainerPnl.ThumbRadius = 2;
            wordContainerPnl.ThumbWidth = 5;
            // 
            // wordContainerInnerPnl
            // 
            wordContainerInnerPnl.BackColor = Color.FromArgb(52, 52, 52);
            wordContainerInnerPnl.CornerRadius = 8;
            wordContainerInnerPnl.Location = new Point(0, 0);
            wordContainerInnerPnl.Name = "wordContainerInnerPnl";
            wordContainerInnerPnl.Size = new Size(500, 460);
            wordContainerInnerPnl.TabIndex = 1;
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
            wordListTitlePnl.BackColor = Color.FromArgb(60, 60, 60);
            wordListTitlePnl.Controls.Add(wordListTitleSepPnl);
            wordListTitlePnl.Controls.Add(wordListTitleMeaningLbl);
            wordListTitlePnl.Controls.Add(wordListTitleTermLbl);
            wordListTitlePnl.CornerRadius = 8;
            wordListTitlePnl.Location = new Point(0, 0);
            wordListTitlePnl.Name = "wordListTitlePnl";
            wordListTitlePnl.Size = new Size(500, 90);
            wordListTitlePnl.TabIndex = 0;
            // 
            // wordListTitleSepPnl
            // 
            wordListTitleSepPnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            wordListTitleSepPnl.BackColor = Color.FromArgb(160, 170, 170);
            wordListTitleSepPnl.CornerRadius = 3;
            wordListTitleSepPnl.ForeColor = Color.FromArgb(80, 80, 80);
            wordListTitleSepPnl.Location = new Point(247, 7);
            wordListTitleSepPnl.Name = "wordListTitleSepPnl";
            wordListTitleSepPnl.Size = new Size(6, 76);
            wordListTitleSepPnl.TabIndex = 1;
            // 
            // wordListTitleMeaningLbl
            // 
            wordListTitleMeaningLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            wordListTitleMeaningLbl.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            wordListTitleMeaningLbl.ForeColor = Color.FromArgb(200, 210, 210);
            wordListTitleMeaningLbl.Location = new Point(250, 0);
            wordListTitleMeaningLbl.Name = "wordListTitleMeaningLbl";
            wordListTitleMeaningLbl.Size = new Size(250, 90);
            wordListTitleMeaningLbl.TabIndex = 1;
            wordListTitleMeaningLbl.Text = "Meaning";
            wordListTitleMeaningLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // wordListTitleTermLbl
            // 
            wordListTitleTermLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            wordListTitleTermLbl.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            wordListTitleTermLbl.ForeColor = Color.FromArgb(210, 220, 220);
            wordListTitleTermLbl.Location = new Point(0, 0);
            wordListTitleTermLbl.Name = "wordListTitleTermLbl";
            wordListTitleTermLbl.Size = new Size(250, 90);
            wordListTitleTermLbl.TabIndex = 0;
            wordListTitleTermLbl.Text = "Term";
            wordListTitleTermLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // QuizWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 45);
            ClientSize = new Size(1050, 650);
            Controls.Add(wordListPnl);
            Controls.Add(OptionsPnl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "QuizWindow";
            OptionsPnl.ResumeLayout(false);
            OptionsPnl.PerformLayout();
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
        private RoundedPanel wordListTitlePnl;
        private Label wordListTitleTermLbl;
        private RoundedPanel wordListTitleSepPnl;
        private Label wordListTitleMeaningLbl;
        private Experimental.CustomScrollPanel wordContainerPnl;
        private Panel wordListUnlockScrollPnl;
        private Label label1;
        private RoundedPanel wordContainerInnerPnl;
    }
}