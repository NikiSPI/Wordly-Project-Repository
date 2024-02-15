namespace WordlyUIbaseVer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlashcardMode));
            flashcardBtn = new Button();
            previousCardBtn = new Button();
            nextCardBtn = new Button();
            EndPnl = new Panel();
            backBtn = new Button();
            againBtn = new Button();
            EndPnl.SuspendLayout();
            SuspendLayout();
            // 
            // flashcardBtn
            // 
            flashcardBtn.BackColor = Color.GreenYellow;
            flashcardBtn.CausesValidation = false;
            flashcardBtn.FlatAppearance.BorderSize = 0;
            flashcardBtn.FlatStyle = FlatStyle.Flat;
            flashcardBtn.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            flashcardBtn.Location = new Point(200, 50);
            flashcardBtn.Name = "flashcardBtn";
            flashcardBtn.Size = new Size(650, 550);
            flashcardBtn.TabIndex = 0;
            flashcardBtn.UseVisualStyleBackColor = false;
            flashcardBtn.Click += FlashcardBtn_Click;
            // 
            // previousCardBtn
            // 
            previousCardBtn.CausesValidation = false;
            previousCardBtn.Image = Properties.Resources.backArrow;
            previousCardBtn.Location = new Point(100, 250);
            previousCardBtn.Name = "previousCardBtn";
            previousCardBtn.Size = new Size(75, 150);
            previousCardBtn.TabIndex = 1;
            previousCardBtn.UseVisualStyleBackColor = true;
            previousCardBtn.Click += PreviousCardBtn_Click;
            // 
            // nextCardBtn
            // 
            nextCardBtn.CausesValidation = false;
            nextCardBtn.Image = (Image)resources.GetObject("nextCardBtn.Image");
            nextCardBtn.Location = new Point(875, 250);
            nextCardBtn.Name = "nextCardBtn";
            nextCardBtn.Size = new Size(75, 150);
            nextCardBtn.TabIndex = 2;
            nextCardBtn.UseVisualStyleBackColor = true;
            nextCardBtn.Click += NextCardBtn_Click;
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
            backBtn.BackColor = SystemColors.ScrollBar;
            backBtn.CausesValidation = false;
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backBtn.Location = new Point(275, 419);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(300, 80);
            backBtn.TabIndex = 1;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = false;
            // 
            // againBtn
            // 
            againBtn.BackColor = SystemColors.ScrollBar;
            againBtn.CausesValidation = false;
            againBtn.FlatAppearance.BorderSize = 0;
            againBtn.FlatStyle = FlatStyle.Flat;
            againBtn.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            againBtn.Location = new Point(275, 320);
            againBtn.Name = "againBtn";
            againBtn.Size = new Size(300, 80);
            againBtn.TabIndex = 0;
            againBtn.Text = "Revise Again";
            againBtn.UseVisualStyleBackColor = false;
            againBtn.Click += AgainBtn_Click;
            // 
            // FlashcardMode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 650);
            Controls.Add(EndPnl);
            Controls.Add(nextCardBtn);
            Controls.Add(previousCardBtn);
            Controls.Add(flashcardBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FlashcardMode";
            Text = "FlashcardMode";
            EndPnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button flashcardBtn;
        private Button previousCardBtn;
        private Button nextCardBtn;
        private Panel EndPnl;
        private Button againBtn;
        public Button backBtn;
    }
}