﻿namespace WordlyUIbaseVer
{
    partial class WriteMode
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
            incorrectPnl = new Panel();
            iAnswerWordLbl = new Label();
            iCorrectMeaningLbl = new Label();
            iTextIncorrectLbl = new Label();
            iTextCorrectLbl = new Label();
            iTextAnswerLbl = new Label();
            iTextTermLbl = new Label();
            iShownWordLbl = new Label();
            iContinueBtn = new Button();
            endPnl = new Panel();
            eBackBtn = new Button();
            eAgainBtn = new Button();
            answerPnl = new Panel();
            aShownWordLbl = new Label();
            aAnswerBtn = new Button();
            aAnswerTbx = new TextBox();
            statNumLeftLbl = new Label();
            statPnl = new Panel();
            panel1 = new Panel();
            statWrongPbx = new PictureBox();
            statCorrectPbx = new PictureBox();
            statNumWrongLbl = new Label();
            statNumCorrectLbl = new Label();
            incorrectPnl.SuspendLayout();
            endPnl.SuspendLayout();
            answerPnl.SuspendLayout();
            statPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)statWrongPbx).BeginInit();
            ((System.ComponentModel.ISupportInitialize)statCorrectPbx).BeginInit();
            SuspendLayout();
            // 
            // incorrectPnl
            // 
            incorrectPnl.BackColor = SystemColors.InactiveCaption;
            incorrectPnl.Controls.Add(iAnswerWordLbl);
            incorrectPnl.Controls.Add(iCorrectMeaningLbl);
            incorrectPnl.Controls.Add(iTextIncorrectLbl);
            incorrectPnl.Controls.Add(iTextCorrectLbl);
            incorrectPnl.Controls.Add(iTextAnswerLbl);
            incorrectPnl.Controls.Add(iTextTermLbl);
            incorrectPnl.Controls.Add(iShownWordLbl);
            incorrectPnl.Controls.Add(iContinueBtn);
            incorrectPnl.Location = new Point(0, 0);
            incorrectPnl.Name = "incorrectPnl";
            incorrectPnl.Size = new Size(900, 500);
            incorrectPnl.TabIndex = 7;
            incorrectPnl.Visible = false;
            // 
            // iAnswerWordLbl
            // 
            iAnswerWordLbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            iAnswerWordLbl.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iAnswerWordLbl.Location = new Point(50, 223);
            iAnswerWordLbl.Name = "iAnswerWordLbl";
            iAnswerWordLbl.Size = new Size(800, 50);
            iAnswerWordLbl.TabIndex = 9;
            iAnswerWordLbl.Text = "Answer word";
            iAnswerWordLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // iCorrectMeaningLbl
            // 
            iCorrectMeaningLbl.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iCorrectMeaningLbl.Location = new Point(50, 322);
            iCorrectMeaningLbl.Name = "iCorrectMeaningLbl";
            iCorrectMeaningLbl.RightToLeft = RightToLeft.No;
            iCorrectMeaningLbl.Size = new Size(800, 50);
            iCorrectMeaningLbl.TabIndex = 8;
            iCorrectMeaningLbl.Text = "Correct word";
            // 
            // iTextIncorrectLbl
            // 
            iTextIncorrectLbl.Anchor = AnchorStyles.Top;
            iTextIncorrectLbl.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iTextIncorrectLbl.Location = new Point(350, 25);
            iTextIncorrectLbl.Name = "iTextIncorrectLbl";
            iTextIncorrectLbl.Size = new Size(200, 50);
            iTextIncorrectLbl.TabIndex = 7;
            iTextIncorrectLbl.Text = "Incorrect";
            iTextIncorrectLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // iTextCorrectLbl
            // 
            iTextCorrectLbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iTextCorrectLbl.Location = new Point(50, 287);
            iTextCorrectLbl.Name = "iTextCorrectLbl";
            iTextCorrectLbl.Size = new Size(266, 35);
            iTextCorrectLbl.TabIndex = 6;
            iTextCorrectLbl.Text = "Correct Meaning:";
            iTextCorrectLbl.TextAlign = ContentAlignment.BottomLeft;
            // 
            // iTextAnswerLbl
            // 
            iTextAnswerLbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iTextAnswerLbl.Location = new Point(50, 177);
            iTextAnswerLbl.Name = "iTextAnswerLbl";
            iTextAnswerLbl.Size = new Size(175, 46);
            iTextAnswerLbl.TabIndex = 5;
            iTextAnswerLbl.Text = "Your Answer:";
            iTextAnswerLbl.TextAlign = ContentAlignment.BottomLeft;
            // 
            // iTextTermLbl
            // 
            iTextTermLbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iTextTermLbl.Location = new Point(50, 63);
            iTextTermLbl.Name = "iTextTermLbl";
            iTextTermLbl.Size = new Size(123, 48);
            iTextTermLbl.TabIndex = 4;
            iTextTermLbl.Text = "Term:";
            iTextTermLbl.TextAlign = ContentAlignment.BottomLeft;
            // 
            // iShownWordLbl
            // 
            iShownWordLbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            iShownWordLbl.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iShownWordLbl.Location = new Point(50, 111);
            iShownWordLbl.Name = "iShownWordLbl";
            iShownWordLbl.Size = new Size(800, 50);
            iShownWordLbl.TabIndex = 2;
            iShownWordLbl.Text = "Shown word";
            iShownWordLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // iContinueBtn
            // 
            iContinueBtn.Anchor = AnchorStyles.Bottom;
            iContinueBtn.BackColor = SystemColors.WindowFrame;
            iContinueBtn.CausesValidation = false;
            iContinueBtn.FlatAppearance.BorderSize = 0;
            iContinueBtn.FlatStyle = FlatStyle.Flat;
            iContinueBtn.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iContinueBtn.ForeColor = SystemColors.ControlLightLight;
            iContinueBtn.Location = new Point(340, 390);
            iContinueBtn.Name = "iContinueBtn";
            iContinueBtn.Size = new Size(220, 75);
            iContinueBtn.TabIndex = 0;
            iContinueBtn.Text = "Continue";
            iContinueBtn.UseVisualStyleBackColor = false;
            iContinueBtn.Click += iContinueBtn_Click;
            // 
            // endPnl
            // 
            endPnl.BackColor = Color.MediumSpringGreen;
            endPnl.Controls.Add(eBackBtn);
            endPnl.Controls.Add(eAgainBtn);
            endPnl.Location = new Point(75, 50);
            endPnl.Name = "endPnl";
            endPnl.Size = new Size(900, 550);
            endPnl.TabIndex = 9;
            endPnl.Visible = false;
            // 
            // eBackBtn
            // 
            eBackBtn.BackColor = SystemColors.ScrollBar;
            eBackBtn.CausesValidation = false;
            eBackBtn.FlatAppearance.BorderSize = 0;
            eBackBtn.FlatStyle = FlatStyle.Flat;
            eBackBtn.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eBackBtn.Location = new Point(300, 430);
            eBackBtn.Name = "eBackBtn";
            eBackBtn.Size = new Size(300, 80);
            eBackBtn.TabIndex = 3;
            eBackBtn.Text = "Back";
            eBackBtn.UseVisualStyleBackColor = false;
            // 
            // eAgainBtn
            // 
            eAgainBtn.Anchor = AnchorStyles.Bottom;
            eAgainBtn.BackColor = SystemColors.ScrollBar;
            eAgainBtn.CausesValidation = false;
            eAgainBtn.FlatAppearance.BorderSize = 0;
            eAgainBtn.FlatStyle = FlatStyle.Flat;
            eAgainBtn.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eAgainBtn.Location = new Point(300, 330);
            eAgainBtn.Name = "eAgainBtn";
            eAgainBtn.Size = new Size(300, 80);
            eAgainBtn.TabIndex = 2;
            eAgainBtn.Text = "Revise Again";
            eAgainBtn.UseVisualStyleBackColor = false;
            eAgainBtn.Click += againBtn_Click;
            // 
            // answerPnl
            // 
            answerPnl.BackColor = Color.PeachPuff;
            answerPnl.Controls.Add(incorrectPnl);
            answerPnl.Controls.Add(aShownWordLbl);
            answerPnl.Controls.Add(aAnswerBtn);
            answerPnl.Controls.Add(aAnswerTbx);
            answerPnl.Location = new Point(75, 100);
            answerPnl.Name = "answerPnl";
            answerPnl.Size = new Size(900, 500);
            answerPnl.TabIndex = 8;
            // 
            // aShownWordLbl
            // 
            aShownWordLbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            aShownWordLbl.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            aShownWordLbl.Location = new Point(50, 63);
            aShownWordLbl.Name = "aShownWordLbl";
            aShownWordLbl.Size = new Size(800, 50);
            aShownWordLbl.TabIndex = 6;
            aShownWordLbl.Text = "Shown word";
            aShownWordLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // aAnswerBtn
            // 
            aAnswerBtn.Anchor = AnchorStyles.Bottom;
            aAnswerBtn.BackColor = SystemColors.WindowFrame;
            aAnswerBtn.CausesValidation = false;
            aAnswerBtn.FlatAppearance.BorderSize = 0;
            aAnswerBtn.FlatStyle = FlatStyle.Flat;
            aAnswerBtn.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            aAnswerBtn.ForeColor = SystemColors.ControlLightLight;
            aAnswerBtn.Location = new Point(340, 390);
            aAnswerBtn.Name = "aAnswerBtn";
            aAnswerBtn.Size = new Size(220, 75);
            aAnswerBtn.TabIndex = 5;
            aAnswerBtn.Text = "Answer";
            aAnswerBtn.UseVisualStyleBackColor = false;
            aAnswerBtn.Click += aAnswerBtn_Click;
            // 
            // aAnswerTbx
            // 
            aAnswerTbx.BackColor = SystemColors.InactiveCaption;
            aAnswerTbx.BorderStyle = BorderStyle.None;
            aAnswerTbx.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aAnswerTbx.Location = new Point(50, 191);
            aAnswerTbx.Name = "aAnswerTbx";
            aAnswerTbx.Size = new Size(800, 50);
            aAnswerTbx.TabIndex = 4;
            // 
            // statNumLeftLbl
            // 
            statNumLeftLbl.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statNumLeftLbl.Location = new Point(345, 0);
            statNumLeftLbl.Name = "statNumLeftLbl";
            statNumLeftLbl.Size = new Size(150, 90);
            statNumLeftLbl.TabIndex = 11;
            statNumLeftLbl.Text = "le / fttt";
            statNumLeftLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // statPnl
            // 
            statPnl.Controls.Add(panel1);
            statPnl.Controls.Add(statWrongPbx);
            statPnl.Controls.Add(statCorrectPbx);
            statPnl.Controls.Add(statNumWrongLbl);
            statPnl.Controls.Add(statNumCorrectLbl);
            statPnl.Controls.Add(statNumLeftLbl);
            statPnl.Dock = DockStyle.Top;
            statPnl.Location = new Point(0, 0);
            statPnl.Name = "statPnl";
            statPnl.Size = new Size(1050, 90);
            statPnl.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(340, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 90);
            panel1.TabIndex = 18;
            // 
            // statWrongPbx
            // 
            statWrongPbx.Image = Properties.Resources.redCross;
            statWrongPbx.Location = new Point(210, 0);
            statWrongPbx.Name = "statWrongPbx";
            statWrongPbx.Size = new Size(35, 90);
            statWrongPbx.SizeMode = PictureBoxSizeMode.Zoom;
            statWrongPbx.TabIndex = 17;
            statWrongPbx.TabStop = false;
            // 
            // statCorrectPbx
            // 
            statCorrectPbx.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            statCorrectPbx.Image = Properties.Resources.greenTick;
            statCorrectPbx.Location = new Point(75, 0);
            statCorrectPbx.Name = "statCorrectPbx";
            statCorrectPbx.Size = new Size(50, 90);
            statCorrectPbx.SizeMode = PictureBoxSizeMode.Zoom;
            statCorrectPbx.TabIndex = 16;
            statCorrectPbx.TabStop = false;
            // 
            // statNumWrongLbl
            // 
            statNumWrongLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            statNumWrongLbl.BackColor = Color.Transparent;
            statNumWrongLbl.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statNumWrongLbl.Location = new Point(250, 0);
            statNumWrongLbl.Name = "statNumWrongLbl";
            statNumWrongLbl.Size = new Size(90, 90);
            statNumWrongLbl.TabIndex = 15;
            statNumWrongLbl.Text = "WRO";
            statNumWrongLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // statNumCorrectLbl
            // 
            statNumCorrectLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            statNumCorrectLbl.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statNumCorrectLbl.Location = new Point(125, 0);
            statNumCorrectLbl.Name = "statNumCorrectLbl";
            statNumCorrectLbl.Size = new Size(90, 90);
            statNumCorrectLbl.TabIndex = 14;
            statNumCorrectLbl.Text = "COR";
            statNumCorrectLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // WriteMode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 650);
            Controls.Add(statPnl);
            Controls.Add(endPnl);
            Controls.Add(answerPnl);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "WriteMode";
            Text = "WriteMode";
            KeyDown += WriteMode_KeyDown;
            PreviewKeyDown += WriteMode_PreviewKeyDown;
            incorrectPnl.ResumeLayout(false);
            endPnl.ResumeLayout(false);
            answerPnl.ResumeLayout(false);
            answerPnl.PerformLayout();
            statPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)statWrongPbx).EndInit();
            ((System.ComponentModel.ISupportInitialize)statCorrectPbx).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel incorrectPnl;
        private Button iContinueBtn;
        private Label iShownWordLbl;
        private Label iTextIncorrectLbl;
        private Label iTextCorrectLbl;
        private Label iTextAnswerLbl;
        private Label iTextTermLbl;
        private Label iCorrectMeaningLbl;
        private Panel answerPnl;
        private Label aShownWordLbl;
        private Button aAnswerBtn;
        private TextBox aAnswerTbx;
        private Label iAnswerWordLbl;
        private Panel endPnl;
        public Button eBackBtn;
        private Button eAgainBtn;
        private Label statNumLeftLbl;
        private Panel statPnl;
        private Label statNumWrongLbl;
        private Label statNumCorrectLbl;
        private PictureBox statWrongPbx;
        private PictureBox statCorrectPbx;
        private Panel panel1;
    }
}