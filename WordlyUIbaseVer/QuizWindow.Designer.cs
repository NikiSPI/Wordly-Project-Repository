namespace WordlyUIbaseVer
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
            Option4Btn = new Button();
            Option3Btn = new Button();
            Option2Btn = new Button();
            Option1Btn = new Button();
            wordListPnl = new Panel();
            wordContainerPnl = new Panel();
            wordListUnlockScrollPnl = new Panel();
            wordListTitlePnl = new Panel();
            wordListTitleSepPnl = new Panel();
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
            Option4Btn.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Option4Btn.Location = new Point(0, 330);
            Option4Btn.Name = "Option4Btn";
            Option4Btn.Size = new Size(300, 100);
            Option4Btn.TabIndex = 3;
            Option4Btn.Text = "Custom";
            Option4Btn.UseVisualStyleBackColor = true;
            // 
            // Option3Btn
            // 
            Option3Btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Option3Btn.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Option3Btn.Location = new Point(0, 220);
            Option3Btn.Name = "Option3Btn";
            Option3Btn.Size = new Size(300, 100);
            Option3Btn.TabIndex = 2;
            Option3Btn.Text = "Exam Mode";
            Option3Btn.UseVisualStyleBackColor = true;
            // 
            // Option2Btn
            // 
            Option2Btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Option2Btn.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Option2Btn.Location = new Point(0, 110);
            Option2Btn.Name = "Option2Btn";
            Option2Btn.Size = new Size(300, 100);
            Option2Btn.TabIndex = 1;
            Option2Btn.Text = "Write Mode";
            Option2Btn.UseVisualStyleBackColor = true;
            // 
            // Option1Btn
            // 
            Option1Btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Option1Btn.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Option1Btn.Location = new Point(0, 0);
            Option1Btn.Name = "Option1Btn";
            Option1Btn.Size = new Size(300, 100);
            Option1Btn.TabIndex = 0;
            Option1Btn.Text = "Flashcards";
            Option1Btn.UseVisualStyleBackColor = true;
            Option1Btn.Click += Option1Btn_Click;
            // 
            // wordListPnl
            // 
            wordListPnl.Anchor = AnchorStyles.None;
            wordListPnl.AutoScroll = true;
            wordListPnl.BackColor = SystemColors.GradientInactiveCaption;
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
            wordListTitlePnl.BackColor = Color.LightCyan;
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
            wordListTitleMeaningLbl.Location = new Point(252, 0);
            wordListTitleMeaningLbl.Name = "wordListTitleMeaningLbl";
            wordListTitleMeaningLbl.Size = new Size(265, 90);
            wordListTitleMeaningLbl.TabIndex = 1;
            wordListTitleMeaningLbl.Text = "Meaning";
            wordListTitleMeaningLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // wordListTitleTermLbl
            // 
            wordListTitleTermLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            wordListTitleTermLbl.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
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
        private Button Option1Btn;
        private Button Option3Btn;
        private Button Option2Btn;
        private Button Option4Btn;
        private Panel wordListPnl;
        private Panel wordListTitlePnl;
        private Label wordListTitleTermLbl;
        private Panel wordListTitleSepPnl;
        private Label wordListTitleMeaningLbl;
        private Panel wordContainerPnl;
        private Panel wordListUnlockScrollPnl;
    }
}