namespace Wordly_alpha
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
            tipsTitleSepPnl = new RoundedComponents.RoundedPanel();
            pictureBox1 = new PictureBox();
            titleTipsLbl = new Label();
            kbTextFlashcardTitleLbl = new Label();
            panel1 = new Panel();
            roundedPanel2 = new RoundedComponents.RoundedPanel();
            label3 = new Label();
            roundedPanel1 = new RoundedComponents.RoundedPanel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            backPnl.SuspendLayout();
            contentPnl.SuspendLayout();
            contentTipsPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            contentPnl.Controls.Add(contentTipsPnl);
            contentPnl.Controls.Add(panel1);
            contentPnl.Location = new Point(100, 50);
            contentPnl.Name = "contentPnl";
            contentPnl.Size = new Size(850, 750);
            contentPnl.TabIndex = 0;
            // 
            // contentTipsPnl
            // 
            contentTipsPnl.Controls.Add(label1);
            contentTipsPnl.Controls.Add(tipsTitleSepPnl);
            contentTipsPnl.Controls.Add(pictureBox1);
            contentTipsPnl.Controls.Add(titleTipsLbl);
            contentTipsPnl.Controls.Add(kbTextFlashcardTitleLbl);
            contentTipsPnl.Location = new Point(0, 0);
            contentTipsPnl.Name = "contentTipsPnl";
            contentTipsPnl.Size = new Size(850, 220);
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
            tipsTitleSepPnl.Location = new Point(170, 42);
            tipsTitleSepPnl.Name = "tipsTitleSepPnl";
            tipsTitleSepPnl.Size = new Size(670, 5);
            tipsTitleSepPnl.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.HW_light_bulb_white;
            pictureBox1.Location = new Point(5, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
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
            // panel1
            // 
            panel1.Controls.Add(roundedPanel2);
            panel1.Controls.Add(roundedPanel1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(0, 270);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 400);
            panel1.TabIndex = 20;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.FromArgb(50, 50, 50);
            roundedPanel2.Controls.Add(label3);
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
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.HW_recent_lists_white;
            pictureBox2.Location = new Point(10, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // Home_Window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            ClientSize = new Size(1050, 650);
            Controls.Add(backPnl);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Home_Window";
            Text = "Main_Window";
            backPnl.ResumeLayout(false);
            contentPnl.ResumeLayout(false);
            contentTipsPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            roundedPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel backPnl;
        private Panel contentPnl;
        private RoundedComponents.RoundedPanel tipsTitleSepPnl;
        private Label titleTipsLbl;
        private Label kbTextFlashcardTitleLbl;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel contentTipsPnl;
        private Panel panel1;
        private RoundedComponents.RoundedPanel roundedPanel1;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label3;
        private RoundedComponents.RoundedPanel roundedPanel2;
    }
}