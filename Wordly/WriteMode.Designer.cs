﻿namespace Wordly
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
            incorrectPnl = new RoundedPanel();
            iWasCorrectBtn = new RoundedButton();
            iShownWordLbl = new Label();
            iAnswerWordLbl = new Label();
            iCorrectMeaningLbl = new Label();
            iTextIncorrectLbl = new RoundedLabel();
            iTextCorrectLbl = new Label();
            iTextAnswerLbl = new Label();
            iTextTermLbl = new Label();
            iContinueBtn = new RoundedButton();
            endPnl = new RoundedPanel();
            resultLbl = new Label();
            eBackBtn = new RoundedButton();
            eAgainBtn = new RoundedButton();
            answerPnl = new RoundedPanel();
            aUnderlineTbxPnl = new RoundedPanel();
            aShownWordLbl = new Label();
            aAnswerBtn = new RoundedButton();
            aAnswerTbx = new AdvancedTextBox();
            statNumLeftLbl = new Label();
            statPnl = new Panel();
            statIntersectionPnl = new RoundedPanel();
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
            incorrectPnl.BackColor = Color.FromArgb(65, 65, 65);
            incorrectPnl.BorderColor = Color.Black;
            incorrectPnl.BorderThickness = 0F;
            incorrectPnl.Controls.Add(iWasCorrectBtn);
            incorrectPnl.Controls.Add(iShownWordLbl);
            incorrectPnl.Controls.Add(iAnswerWordLbl);
            incorrectPnl.Controls.Add(iCorrectMeaningLbl);
            incorrectPnl.Controls.Add(iTextIncorrectLbl);
            incorrectPnl.Controls.Add(iTextCorrectLbl);
            incorrectPnl.Controls.Add(iTextAnswerLbl);
            incorrectPnl.Controls.Add(iTextTermLbl);
            incorrectPnl.Controls.Add(iContinueBtn);
            incorrectPnl.CornerRadius = 5;
            incorrectPnl.Location = new Point(0, 0);
            incorrectPnl.Name = "incorrectPnl";
            incorrectPnl.Size = new Size(900, 500);
            incorrectPnl.TabIndex = 7;
            incorrectPnl.Visible = false;
            // 
            // iWasCorrectBtn
            // 
            iWasCorrectBtn.Anchor = AnchorStyles.Bottom;
            iWasCorrectBtn.BackColor = Color.FromArgb(75, 75, 75);
            iWasCorrectBtn.BorderColor = Color.Black;
            iWasCorrectBtn.BorderThickness = 0F;
            iWasCorrectBtn.CausesValidation = false;
            iWasCorrectBtn.CornerRadius = 5;
            iWasCorrectBtn.FlatAppearance.BorderColor = Color.FromArgb(75, 75, 75);
            iWasCorrectBtn.FlatAppearance.BorderSize = 0;
            iWasCorrectBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(95, 95, 95);
            iWasCorrectBtn.FlatStyle = FlatStyle.Flat;
            iWasCorrectBtn.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iWasCorrectBtn.ForeColor = Color.FromArgb(250, 230, 230);
            iWasCorrectBtn.Location = new Point(475, 390);
            iWasCorrectBtn.Name = "iWasCorrectBtn";
            iWasCorrectBtn.Size = new Size(220, 75);
            iWasCorrectBtn.TabIndex = 10;
            iWasCorrectBtn.TabStop = false;
            iWasCorrectBtn.Text = "I was correct";
            iWasCorrectBtn.UseMnemonic = false;
            iWasCorrectBtn.UseVisualStyleBackColor = false;
            iWasCorrectBtn.Click += iWasCorrectBtn_Click;
            // 
            // iShownWordLbl
            // 
            iShownWordLbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            iShownWordLbl.Font = new Font("Calibri", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iShownWordLbl.ForeColor = Color.FromArgb(200, 210, 210);
            iShownWordLbl.Location = new Point(70, 111);
            iShownWordLbl.Name = "iShownWordLbl";
            iShownWordLbl.Size = new Size(800, 50);
            iShownWordLbl.TabIndex = 2;
            iShownWordLbl.Text = "Shown word";
            iShownWordLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // iAnswerWordLbl
            // 
            iAnswerWordLbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            iAnswerWordLbl.Font = new Font("Calibri", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iAnswerWordLbl.ForeColor = Color.FromArgb(220, 230, 230);
            iAnswerWordLbl.Location = new Point(70, 215);
            iAnswerWordLbl.Name = "iAnswerWordLbl";
            iAnswerWordLbl.Size = new Size(800, 50);
            iAnswerWordLbl.TabIndex = 9;
            iAnswerWordLbl.Text = "Answer word";
            iAnswerWordLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // iCorrectMeaningLbl
            // 
            iCorrectMeaningLbl.Font = new Font("Calibri", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iCorrectMeaningLbl.ForeColor = Color.FromArgb(220, 230, 230);
            iCorrectMeaningLbl.Location = new Point(70, 315);
            iCorrectMeaningLbl.Name = "iCorrectMeaningLbl";
            iCorrectMeaningLbl.RightToLeft = RightToLeft.No;
            iCorrectMeaningLbl.Size = new Size(800, 50);
            iCorrectMeaningLbl.TabIndex = 8;
            iCorrectMeaningLbl.Text = "Correct word";
            // 
            // iTextIncorrectLbl
            // 
            iTextIncorrectLbl.Anchor = AnchorStyles.Top;
            iTextIncorrectLbl.BackColor = Color.FromArgb(230, 200, 200);
            iTextIncorrectLbl.BorderColor = Color.Black;
            iTextIncorrectLbl.BorderThickness = 0F;
            iTextIncorrectLbl.CornerRadius = 5;
            iTextIncorrectLbl.Font = new Font("Calibri", 27.75F, FontStyle.Bold);
            iTextIncorrectLbl.ForeColor = Color.FromArgb(30, 10, 10);
            iTextIncorrectLbl.Location = new Point(340, 25);
            iTextIncorrectLbl.Name = "iTextIncorrectLbl";
            iTextIncorrectLbl.Size = new Size(220, 55);
            iTextIncorrectLbl.TabIndex = 7;
            iTextIncorrectLbl.Text = "Incorrect";
            iTextIncorrectLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // iTextCorrectLbl
            // 
            iTextCorrectLbl.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iTextCorrectLbl.ForeColor = Color.FromArgb(220, 230, 230);
            iTextCorrectLbl.Location = new Point(50, 280);
            iTextCorrectLbl.Name = "iTextCorrectLbl";
            iTextCorrectLbl.Size = new Size(266, 35);
            iTextCorrectLbl.TabIndex = 6;
            iTextCorrectLbl.Text = "Correct Meaning:";
            iTextCorrectLbl.TextAlign = ContentAlignment.BottomLeft;
            // 
            // iTextAnswerLbl
            // 
            iTextAnswerLbl.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iTextAnswerLbl.ForeColor = Color.FromArgb(220, 230, 230);
            iTextAnswerLbl.Location = new Point(50, 170);
            iTextAnswerLbl.Name = "iTextAnswerLbl";
            iTextAnswerLbl.Size = new Size(175, 46);
            iTextAnswerLbl.TabIndex = 5;
            iTextAnswerLbl.Text = "Your Answer:";
            iTextAnswerLbl.TextAlign = ContentAlignment.BottomLeft;
            // 
            // iTextTermLbl
            // 
            iTextTermLbl.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iTextTermLbl.ForeColor = Color.FromArgb(200, 210, 210);
            iTextTermLbl.Location = new Point(50, 63);
            iTextTermLbl.Name = "iTextTermLbl";
            iTextTermLbl.Size = new Size(123, 48);
            iTextTermLbl.TabIndex = 4;
            iTextTermLbl.Text = "Term:";
            iTextTermLbl.TextAlign = ContentAlignment.BottomLeft;
            // 
            // iContinueBtn
            // 
            iContinueBtn.Anchor = AnchorStyles.Bottom;
            iContinueBtn.BackColor = Color.FromArgb(75, 75, 75);
            iContinueBtn.BorderColor = Color.Black;
            iContinueBtn.BorderThickness = 0F;
            iContinueBtn.CausesValidation = false;
            iContinueBtn.CornerRadius = 5;
            iContinueBtn.FlatAppearance.BorderColor = Color.FromArgb(75, 75, 75);
            iContinueBtn.FlatAppearance.BorderSize = 0;
            iContinueBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(95, 95, 95);
            iContinueBtn.FlatStyle = FlatStyle.Flat;
            iContinueBtn.Font = new Font("Calibri", 27.75F, FontStyle.Bold);
            iContinueBtn.ForeColor = Color.FromArgb(220, 230, 230);
            iContinueBtn.Location = new Point(205, 390);
            iContinueBtn.Name = "iContinueBtn";
            iContinueBtn.Size = new Size(220, 75);
            iContinueBtn.TabIndex = 0;
            iContinueBtn.TabStop = false;
            iContinueBtn.Text = "Continue";
            iContinueBtn.UseMnemonic = false;
            iContinueBtn.UseVisualStyleBackColor = false;
            iContinueBtn.Click += iContinueBtn_Click;
            // 
            // endPnl
            // 
            endPnl.BackColor = Color.FromArgb(70, 70, 70);
            endPnl.BorderColor = Color.Black;
            endPnl.BorderThickness = 0F;
            endPnl.Controls.Add(resultLbl);
            endPnl.Controls.Add(eBackBtn);
            endPnl.Controls.Add(eAgainBtn);
            endPnl.CornerRadius = 5;
            endPnl.Location = new Point(75, 50);
            endPnl.Name = "endPnl";
            endPnl.Size = new Size(900, 550);
            endPnl.TabIndex = 9;
            endPnl.Visible = false;
            // 
            // resultLbl
            // 
            resultLbl.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultLbl.ForeColor = Color.FromArgb(230, 240, 240);
            resultLbl.Location = new Point(200, 100);
            resultLbl.Name = "resultLbl";
            resultLbl.Size = new Size(500, 200);
            resultLbl.TabIndex = 4;
            resultLbl.Text = "100% 123/125";
            resultLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // eBackBtn
            // 
            eBackBtn.BackColor = Color.FromArgb(55, 55, 55);
            eBackBtn.BorderColor = Color.Black;
            eBackBtn.BorderThickness = 0F;
            eBackBtn.CausesValidation = false;
            eBackBtn.CornerRadius = 5;
            eBackBtn.FlatAppearance.BorderColor = Color.FromArgb(55, 55, 55);
            eBackBtn.FlatAppearance.BorderSize = 0;
            eBackBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 85, 85);
            eBackBtn.FlatStyle = FlatStyle.Flat;
            eBackBtn.Font = new Font("Calibri", 27.75F, FontStyle.Bold);
            eBackBtn.ForeColor = Color.FromArgb(200, 210, 210);
            eBackBtn.Location = new Point(475, 425);
            eBackBtn.Name = "eBackBtn";
            eBackBtn.Size = new Size(300, 80);
            eBackBtn.TabIndex = 3;
            eBackBtn.TabStop = false;
            eBackBtn.Text = "Back";
            eBackBtn.UseMnemonic = false;
            eBackBtn.UseVisualStyleBackColor = false;
            // 
            // eAgainBtn
            // 
            eAgainBtn.Anchor = AnchorStyles.Bottom;
            eAgainBtn.BackColor = Color.FromArgb(55, 55, 55);
            eAgainBtn.BorderColor = Color.Black;
            eAgainBtn.BorderThickness = 0F;
            eAgainBtn.CausesValidation = false;
            eAgainBtn.CornerRadius = 5;
            eAgainBtn.FlatAppearance.BorderColor = Color.FromArgb(55, 55, 55);
            eAgainBtn.FlatAppearance.BorderSize = 0;
            eAgainBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 85, 85);
            eAgainBtn.FlatStyle = FlatStyle.Flat;
            eAgainBtn.Font = new Font("Calibri", 27.75F, FontStyle.Bold);
            eAgainBtn.ForeColor = Color.FromArgb(200, 210, 210);
            eAgainBtn.Location = new Point(125, 425);
            eAgainBtn.Name = "eAgainBtn";
            eAgainBtn.Size = new Size(300, 80);
            eAgainBtn.TabIndex = 2;
            eAgainBtn.TabStop = false;
            eAgainBtn.Text = "Revise Again";
            eAgainBtn.UseMnemonic = false;
            eAgainBtn.UseVisualStyleBackColor = false;
            eAgainBtn.Click += againBtn_Click;
            // 
            // answerPnl
            // 
            answerPnl.BackColor = Color.FromArgb(65, 65, 65);
            answerPnl.BorderColor = Color.Black;
            answerPnl.BorderThickness = 0F;
            answerPnl.Controls.Add(incorrectPnl);
            answerPnl.Controls.Add(aUnderlineTbxPnl);
            answerPnl.Controls.Add(aShownWordLbl);
            answerPnl.Controls.Add(aAnswerBtn);
            answerPnl.Controls.Add(aAnswerTbx);
            answerPnl.CornerRadius = 5;
            answerPnl.Location = new Point(75, 120);
            answerPnl.Name = "answerPnl";
            answerPnl.Size = new Size(900, 500);
            answerPnl.TabIndex = 8;
            // 
            // aUnderlineTbxPnl
            // 
            aUnderlineTbxPnl.BackColor = Color.FromArgb(220, 230, 230);
            aUnderlineTbxPnl.BorderColor = Color.Black;
            aUnderlineTbxPnl.BorderThickness = 0F;
            aUnderlineTbxPnl.CornerRadius = 1;
            aUnderlineTbxPnl.ForeColor = Color.Black;
            aUnderlineTbxPnl.Location = new Point(50, 265);
            aUnderlineTbxPnl.Name = "aUnderlineTbxPnl";
            aUnderlineTbxPnl.Size = new Size(800, 3);
            aUnderlineTbxPnl.TabIndex = 10;
            // 
            // aShownWordLbl
            // 
            aShownWordLbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            aShownWordLbl.Font = new Font("Calibri", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aShownWordLbl.ForeColor = Color.FromArgb(200, 210, 210);
            aShownWordLbl.Location = new Point(50, 60);
            aShownWordLbl.Name = "aShownWordLbl";
            aShownWordLbl.Size = new Size(800, 50);
            aShownWordLbl.TabIndex = 6;
            aShownWordLbl.Text = "Shown word";
            aShownWordLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // aAnswerBtn
            // 
            aAnswerBtn.Anchor = AnchorStyles.Bottom;
            aAnswerBtn.BackColor = Color.FromArgb(75, 75, 75);
            aAnswerBtn.BorderColor = Color.Black;
            aAnswerBtn.BorderThickness = 0F;
            aAnswerBtn.CausesValidation = false;
            aAnswerBtn.CornerRadius = 5;
            aAnswerBtn.FlatAppearance.BorderColor = Color.FromArgb(75, 75, 75);
            aAnswerBtn.FlatAppearance.BorderSize = 0;
            aAnswerBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(95, 95, 95);
            aAnswerBtn.FlatStyle = FlatStyle.Flat;
            aAnswerBtn.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            aAnswerBtn.ForeColor = SystemColors.ControlLightLight;
            aAnswerBtn.Location = new Point(340, 390);
            aAnswerBtn.Name = "aAnswerBtn";
            aAnswerBtn.Size = new Size(220, 75);
            aAnswerBtn.TabIndex = 5;
            aAnswerBtn.TabStop = false;
            aAnswerBtn.Text = "Answer";
            aAnswerBtn.UseMnemonic = false;
            aAnswerBtn.UseVisualStyleBackColor = false;
            aAnswerBtn.Click += aAnswerBtn_Click;
            // 
            // aAnswerTbx
            // 
            aAnswerTbx.BackColor = Color.FromArgb(65, 65, 65);
            aAnswerTbx.BorderColor = Color.Empty;
            aAnswerTbx.BorderStyle = BorderStyle.None;
            aAnswerTbx.Font = new Font("Candara", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aAnswerTbx.ForeColor = Color.FromArgb(220, 230, 230);
            aAnswerTbx.Location = new Point(50, 220);
            aAnswerTbx.Name = "aAnswerTbx";
            aAnswerTbx.Size = new Size(800, 50);
            aAnswerTbx.TabIndex = 8;
            aAnswerTbx.TabStop = false;
            // 
            // statNumLeftLbl
            // 
            statNumLeftLbl.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statNumLeftLbl.ForeColor = Color.FromArgb(200, 210, 210);
            statNumLeftLbl.Location = new Point(345, 0);
            statNumLeftLbl.Name = "statNumLeftLbl";
            statNumLeftLbl.Size = new Size(150, 90);
            statNumLeftLbl.TabIndex = 11;
            statNumLeftLbl.Text = "le / fttt";
            statNumLeftLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // statPnl
            // 
            statPnl.BackColor = Color.FromArgb(50, 50, 50);
            statPnl.Controls.Add(statIntersectionPnl);
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
            // statIntersectionPnl
            // 
            statIntersectionPnl.BackColor = Color.FromArgb(30, 30, 30);
            statIntersectionPnl.BorderColor = Color.Black;
            statIntersectionPnl.BorderThickness = 0F;
            statIntersectionPnl.CornerRadius = 1;
            statIntersectionPnl.Location = new Point(340, 10);
            statIntersectionPnl.Name = "statIntersectionPnl";
            statIntersectionPnl.Size = new Size(5, 70);
            statIntersectionPnl.TabIndex = 18;
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
            statNumWrongLbl.ForeColor = Color.FromArgb(210, 220, 220);
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
            statNumCorrectLbl.ForeColor = Color.FromArgb(210, 220, 220);
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
            BackColor = Color.FromArgb(50, 50, 50);
            ClientSize = new Size(1050, 650);
            Controls.Add(endPnl);
            Controls.Add(statPnl);
            Controls.Add(answerPnl);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "WriteMode";
            Text = "WriteMode";
            KeyDown += WriteMode_KeyDown;
            KeyUp += WriteMode_KeyUp;
            incorrectPnl.ResumeLayout(false);
            endPnl.ResumeLayout(false);
            answerPnl.ResumeLayout(false);
            statPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)statWrongPbx).EndInit();
            ((System.ComponentModel.ISupportInitialize)statCorrectPbx).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RoundedPanel incorrectPnl;
        private RoundedButton iContinueBtn;
        private Label iShownWordLbl;
        private RoundedLabel iTextIncorrectLbl;
        private Label iTextCorrectLbl;
        private Label iTextAnswerLbl;
        private Label iTextTermLbl;
        private Label iCorrectMeaningLbl;
        private RoundedPanel answerPnl;
        private Label aShownWordLbl;
        private RoundedButton aAnswerBtn;
        private Label iAnswerWordLbl;
        private RoundedPanel endPnl;
        public  RoundedButton eBackBtn;
        private RoundedButton eAgainBtn;
        private Label statNumLeftLbl;
        private Panel statPnl;
        private Label statNumWrongLbl;
        private Label statNumCorrectLbl;
        private PictureBox statWrongPbx;
        private PictureBox statCorrectPbx;
        private RoundedPanel statIntersectionPnl;
        private AdvancedTextBox aAnswerTbx;
        private RoundedPanel aUnderlineTbxPnl;
        private Label resultLbl;
        private RoundedButton iWasCorrectBtn;
    }
}