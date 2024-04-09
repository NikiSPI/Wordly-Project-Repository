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
            text1Opt2Lbl = new Label();
            switchable1Opt1Lbl = new Label();
            backPnl = new Panel();
            spacingPnl = new Panel();
            contentPnl.SuspendLayout();
            backPnl.SuspendLayout();
            SuspendLayout();
            // 
            // text1Opt1Lbl
            // 
            text1Opt1Lbl.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text1Opt1Lbl.ForeColor = Color.FromArgb(210, 220, 220);
            text1Opt1Lbl.Location = new Point(30, 30);
            text1Opt1Lbl.Name = "text1Opt1Lbl";
            text1Opt1Lbl.Size = new Size(580, 80);
            text1Opt1Lbl.TabIndex = 5;
            text1Opt1Lbl.Text = "Answer with:";
            text1Opt1Lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // switch1Opt2SBtn
            // 
            switch1Opt2SBtn.Location = new Point(640, 132);
            switch1Opt2SBtn.MinimumSize = new Size(45, 22);
            switch1Opt2SBtn.Name = "switch1Opt2SBtn";
            switch1Opt2SBtn.OffBackColor = Color.Gray;
            switch1Opt2SBtn.OffToggleColor = Color.Gainsboro;
            switch1Opt2SBtn.OnBackColor = Color.MediumSlateBlue;
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
            switch1Opt1SBtn.Location = new Point(640, 52);
            switch1Opt1SBtn.MinimumSize = new Size(45, 22);
            switch1Opt1SBtn.Name = "switch1Opt1SBtn";
            switch1Opt1SBtn.OffBackColor = Color.Gray;
            switch1Opt1SBtn.OffToggleColor = Color.Gainsboro;
            switch1Opt1SBtn.OnBackColor = Color.MediumSlateBlue;
            switch1Opt1SBtn.OnToggleColor = Color.WhiteSmoke;
            switch1Opt1SBtn.Size = new Size(80, 36);
            switch1Opt1SBtn.TabIndex = 3;
            switch1Opt1SBtn.UseVisualStyleBackColor = true;
            switch1Opt1SBtn.CheckedChanged += switch1Opt1SBtn_CheckedChanged;
            // 
            // contentPnl
            // 
            contentPnl.BackColor = Color.FromArgb(50, 50, 50);
            contentPnl.Controls.Add(switch1Opt2SBtn);
            contentPnl.Controls.Add(switch1Opt1SBtn);
            contentPnl.Controls.Add(text1Opt2Lbl);
            contentPnl.Controls.Add(switchable1Opt1Lbl);
            contentPnl.Controls.Add(text1Opt1Lbl);
            contentPnl.Location = new Point(150, 50);
            contentPnl.Name = "contentPnl";
            contentPnl.Size = new Size(750, 800);
            contentPnl.TabIndex = 10;
            // 
            // text1Opt2Lbl
            // 
            text1Opt2Lbl.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text1Opt2Lbl.ForeColor = Color.FromArgb(210, 220, 220);
            text1Opt2Lbl.Location = new Point(30, 110);
            text1Opt2Lbl.Name = "text1Opt2Lbl";
            text1Opt2Lbl.Size = new Size(580, 80);
            text1Opt2Lbl.TabIndex = 10;
            text1Opt2Lbl.Text = "Answer with both:  (only exam mode)";
            text1Opt2Lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // switchable1Opt1Lbl
            // 
            switchable1Opt1Lbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            switchable1Opt1Lbl.ForeColor = Color.FromArgb(230, 240, 240);
            switchable1Opt1Lbl.Location = new Point(475, 30);
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
            spacingPnl.Location = new Point(72, 850);
            spacingPnl.Name = "spacingPnl";
            spacingPnl.Size = new Size(44, 50);
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
    }
}