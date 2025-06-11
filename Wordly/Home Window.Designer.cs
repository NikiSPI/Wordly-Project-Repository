namespace Wordly
{
    partial class Home_Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_Window));
            backPnl = new Panel();
            contentPnl = new Panel();
            contentTipsPnl = new Panel();
            label1 = new Label();
            tipsTitleSepPnl = new RoundedPanel();
            titleTipsLbl = new Label();
            kbTextFlashcardTitleLbl = new Label();
            iconBox1 = new IconBox();
            panel1 = new Panel();
            roundedPanel2 = new RoundedPanel();
            label3 = new Label();
            roundedPanel1 = new RoundedPanel();
            label2 = new Label();
            iconBox2 = new IconBox();
            backPnl.SuspendLayout();
            contentPnl.SuspendLayout();
            contentTipsPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconBox1).BeginInit();
            panel1.SuspendLayout();
            roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconBox2).BeginInit();
            SuspendLayout();
            // 
            // backPnl
            // 
            backPnl.AutoScroll = true;
            backPnl.Controls.Add(contentPnl);
            backPnl.Dock = DockStyle.Fill;
            backPnl.Location = new Point(0, 0);
            backPnl.Name = "backPnl";
            backPnl.Size = new Size(1050, 650);
            backPnl.TabIndex = 0;
            // 
            // contentPnl
            // 
            contentPnl.Controls.Add(panel1);
            contentPnl.Controls.Add(contentTipsPnl);
            contentPnl.Location = new Point(100, 50);
            contentPnl.Name = "contentPnl";
            contentPnl.Size = new Size(850, 826);
            contentPnl.TabIndex = 0;
            // 
            // contentTipsPnl
            // 
            contentTipsPnl.Controls.Add(label1);
            contentTipsPnl.Controls.Add(tipsTitleSepPnl);
            contentTipsPnl.Controls.Add(titleTipsLbl);
            contentTipsPnl.Controls.Add(kbTextFlashcardTitleLbl);
            contentTipsPnl.Controls.Add(iconBox1);
            contentTipsPnl.Location = new Point(0, 0);
            contentTipsPnl.Name = "contentTipsPnl";
            contentTipsPnl.Size = new Size(850, 267);
            contentTipsPnl.TabIndex = 16;
            // 
            // label1
            // 
            label1.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(210, 220, 220);
            label1.Location = new Point(22, 160);
            label1.Name = "label1";
            label1.Size = new Size(818, 60);
            label1.TabIndex = 15;
            label1.Text = "For more seamless and comfortable experience you can use the built-in Key Binds. A list of them can be found in the bottom part of the Settings menu.";
            // 
            // tipsTitleSepPnl
            // 
            tipsTitleSepPnl.BackColor = Color.FromArgb(210, 250, 250);
            tipsTitleSepPnl.BorderColor = Color.Black;
            tipsTitleSepPnl.BorderThickness = 0F;
            tipsTitleSepPnl.CornerRadius = 1;
            tipsTitleSepPnl.Location = new Point(170, 42);
            tipsTitleSepPnl.Name = "tipsTitleSepPnl";
            tipsTitleSepPnl.Size = new Size(670, 5);
            tipsTitleSepPnl.TabIndex = 9;
            // 
            // titleTipsLbl
            // 
            titleTipsLbl.Font = new Font("Calibri", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleTipsLbl.ForeColor = Color.FromArgb(210, 250, 250);
            titleTipsLbl.ImageAlign = ContentAlignment.MiddleLeft;
            titleTipsLbl.Location = new Point(75, 0);
            titleTipsLbl.Name = "titleTipsLbl";
            titleTipsLbl.Size = new Size(150, 80);
            titleTipsLbl.TabIndex = 8;
            titleTipsLbl.Text = "Tips";
            titleTipsLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // kbTextFlashcardTitleLbl
            // 
            kbTextFlashcardTitleLbl.Font = new Font("Candara", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kbTextFlashcardTitleLbl.ForeColor = Color.FromArgb(235, 245, 245);
            kbTextFlashcardTitleLbl.Location = new Point(24, 80);
            kbTextFlashcardTitleLbl.Name = "kbTextFlashcardTitleLbl";
            kbTextFlashcardTitleLbl.Size = new Size(580, 80);
            kbTextFlashcardTitleLbl.TabIndex = 13;
            kbTextFlashcardTitleLbl.Text = "• Look up the Key Binds";
            kbTextFlashcardTitleLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // iconBox1
            // 
            iconBox1.Image = (Image)resources.GetObject("iconBox1.Image");
            iconBox1.Location = new Point(5, 5);
            iconBox1.MaxSize = new Size(100, 100);
            iconBox1.Name = "iconBox1";
            iconBox1.ReplacementColor = Color.FromArgb(210, 250, 250);
            iconBox1.Resizable = true;
            iconBox1.Size = new Size(70, 70);
            iconBox1.SizeMode = PictureBoxSizeMode.Zoom;
            iconBox1.TabIndex = 1;
            iconBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(roundedPanel2);
            panel1.Controls.Add(roundedPanel1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(iconBox2);
            panel1.Location = new Point(0, 578);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 400);
            panel1.TabIndex = 20;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.FromArgb(50, 50, 50);
            roundedPanel2.BorderColor = Color.Black;
            roundedPanel2.BorderThickness = 0F;
            roundedPanel2.Controls.Add(label3);
            roundedPanel2.CornerRadius = 5;
            roundedPanel2.Dock = DockStyle.Bottom;
            roundedPanel2.Location = new Point(0, 90);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(850, 310);
            roundedPanel2.TabIndex = 21;
            // 
            // label3
            // 
            label3.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(210, 220, 220);
            label3.Location = new Point(275, 100);
            label3.Name = "label3";
            label3.Size = new Size(300, 110);
            label3.TabIndex = 20;
            label3.Text = "*no recent word lists*";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.FromArgb(210, 250, 250);
            roundedPanel1.BorderColor = Color.Black;
            roundedPanel1.BorderThickness = 0F;
            roundedPanel1.CornerRadius = 1;
            roundedPanel1.Location = new Point(335, 42);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(505, 5);
            roundedPanel1.TabIndex = 18;
            // 
            // label2
            // 
            label2.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(210, 250, 250);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(75, 0);
            label2.Name = "label2";
            label2.Size = new Size(300, 80);
            label2.TabIndex = 17;
            label2.Text = "Recent Word Lists";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // iconBox2
            // 
            iconBox2.Image = (Image)resources.GetObject("iconBox2.Image");
            iconBox2.Location = new Point(10, 12);
            iconBox2.MaxSize = new Size(500, 500);
            iconBox2.Name = "iconBox2";
            iconBox2.ReplacementColor = Color.FromArgb(210, 250, 250);
            iconBox2.Resizable = false;
            iconBox2.Size = new Size(60, 60);
            iconBox2.SizeMode = PictureBoxSizeMode.Zoom;
            iconBox2.TabIndex = 19;
            iconBox2.TabStop = false;
            // 
            // Home_Window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            ClientSize = new Size(1050, 650);
            Controls.Add(backPnl);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Home_Window";
            Text = "Main_Window";
            backPnl.ResumeLayout(false);
            contentPnl.ResumeLayout(false);
            contentTipsPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconBox1).EndInit();
            panel1.ResumeLayout(false);
            roundedPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel backPnl;
        private Panel contentPnl;
        private RoundedPanel tipsTitleSepPnl;
        private Label titleTipsLbl;
        private Label kbTextFlashcardTitleLbl;
        private Label label1;
        private Panel contentTipsPnl;
        private Panel panel1;
        private RoundedPanel roundedPanel1;
        private Label label2;
        private IconBox iconBox2;
        private Label label3;
        private RoundedPanel roundedPanel2;
        private IconBox iconBox1;
    }
}