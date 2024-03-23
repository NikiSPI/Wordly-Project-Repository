
namespace WordlyUIbaseVer
{
    partial class WordlyForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuPnl = new Panel();
            menuIndicatorPnl = new Panel();
            menuSettingsBtn = new Button();
            menuQuitBtn = new Button();
            menuCreateBtn = new Button();
            titlePnl = new Panel();
            titleSloganLbl = new Label();
            titleNameLbl = new Label();
            titleLogoImage = new PictureBox();
            menuStartBtn = new Button();
            menuHomeBtn = new Button();
            optBarPnl = new Panel();
            backBtn = new Button();
            optBarImage = new PictureBox();
            contentPnl = new Panel();
            menuPnl.SuspendLayout();
            titlePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)titleLogoImage).BeginInit();
            optBarPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)optBarImage).BeginInit();
            SuspendLayout();
            // 
            // menuPnl
            // 
            menuPnl.BackColor = SystemColors.GradientInactiveCaption;
            menuPnl.Controls.Add(menuIndicatorPnl);
            menuPnl.Controls.Add(menuSettingsBtn);
            menuPnl.Controls.Add(menuQuitBtn);
            menuPnl.Controls.Add(menuCreateBtn);
            menuPnl.Controls.Add(titlePnl);
            menuPnl.Controls.Add(menuStartBtn);
            menuPnl.Controls.Add(menuHomeBtn);
            menuPnl.Dock = DockStyle.Left;
            menuPnl.Location = new Point(0, 0);
            menuPnl.Name = "menuPnl";
            menuPnl.Size = new Size(230, 720);
            menuPnl.TabIndex = 0;
            // 
            // menuIndicatorPnl
            // 
            menuIndicatorPnl.BackColor = Color.Black;
            menuIndicatorPnl.Location = new Point(0, 250);
            menuIndicatorPnl.Name = "menuIndicatorPnl";
            menuIndicatorPnl.Size = new Size(5, 70);
            menuIndicatorPnl.TabIndex = 6;
            // 
            // menuSettingsBtn
            // 
            menuSettingsBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            menuSettingsBtn.BackColor = Color.FromArgb(255, 255, 128);
            menuSettingsBtn.FlatAppearance.BorderSize = 0;
            menuSettingsBtn.FlatStyle = FlatStyle.Flat;
            menuSettingsBtn.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuSettingsBtn.Location = new Point(0, 570);
            menuSettingsBtn.Name = "menuSettingsBtn";
            menuSettingsBtn.Size = new Size(220, 70);
            menuSettingsBtn.TabIndex = 7;
            menuSettingsBtn.Text = " Settings";
            menuSettingsBtn.TextAlign = ContentAlignment.MiddleLeft;
            menuSettingsBtn.UseVisualStyleBackColor = false;
            menuSettingsBtn.Click += settingsBtn_Click;
            // 
            // menuQuitBtn
            // 
            menuQuitBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            menuQuitBtn.BackColor = Color.FromArgb(255, 255, 128);
            menuQuitBtn.FlatAppearance.BorderSize = 0;
            menuQuitBtn.FlatStyle = FlatStyle.Flat;
            menuQuitBtn.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuQuitBtn.Location = new Point(0, 640);
            menuQuitBtn.Name = "menuQuitBtn";
            menuQuitBtn.Size = new Size(220, 70);
            menuQuitBtn.TabIndex = 6;
            menuQuitBtn.Text = " Quit";
            menuQuitBtn.TextAlign = ContentAlignment.MiddleLeft;
            menuQuitBtn.UseVisualStyleBackColor = false;
            menuQuitBtn.Click += quitBtn_Click;
            // 
            // menuCreateBtn
            // 
            menuCreateBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            menuCreateBtn.BackColor = Color.FromArgb(255, 255, 128);
            menuCreateBtn.FlatAppearance.BorderSize = 0;
            menuCreateBtn.FlatStyle = FlatStyle.Flat;
            menuCreateBtn.Font = new Font("Microsoft Sans Serif", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuCreateBtn.Location = new Point(0, 390);
            menuCreateBtn.Name = "menuCreateBtn";
            menuCreateBtn.Size = new Size(220, 70);
            menuCreateBtn.TabIndex = 5;
            menuCreateBtn.Text = " Create List";
            menuCreateBtn.TextAlign = ContentAlignment.MiddleLeft;
            menuCreateBtn.UseVisualStyleBackColor = false;
            menuCreateBtn.Click += createBtn_Click;
            // 
            // titlePnl
            // 
            titlePnl.BackColor = Color.White;
            titlePnl.Controls.Add(titleSloganLbl);
            titlePnl.Controls.Add(titleNameLbl);
            titlePnl.Controls.Add(titleLogoImage);
            titlePnl.Dock = DockStyle.Top;
            titlePnl.Location = new Point(0, 0);
            titlePnl.Name = "titlePnl";
            titlePnl.Size = new Size(230, 240);
            titlePnl.TabIndex = 8;
            // 
            // titleSloganLbl
            // 
            titleSloganLbl.Dock = DockStyle.Fill;
            titleSloganLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleSloganLbl.Location = new Point(0, 186);
            titleSloganLbl.Name = "titleSloganLbl";
            titleSloganLbl.Padding = new Padding(0, 0, 0, 15);
            titleSloganLbl.Size = new Size(230, 54);
            titleSloganLbl.TabIndex = 12;
            titleSloganLbl.Text = "something";
            titleSloganLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // titleNameLbl
            // 
            titleNameLbl.Dock = DockStyle.Top;
            titleNameLbl.Font = new Font("Times New Roman", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleNameLbl.Location = new Point(0, 120);
            titleNameLbl.Name = "titleNameLbl";
            titleNameLbl.Size = new Size(230, 66);
            titleNameLbl.TabIndex = 11;
            titleNameLbl.Text = "Wordly";
            titleNameLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // titleLogoImage
            // 
            titleLogoImage.Dock = DockStyle.Top;
            titleLogoImage.Image = Properties.Resources.logo;
            titleLogoImage.Location = new Point(0, 0);
            titleLogoImage.Name = "titleLogoImage";
            titleLogoImage.Size = new Size(230, 120);
            titleLogoImage.SizeMode = PictureBoxSizeMode.Zoom;
            titleLogoImage.TabIndex = 9;
            titleLogoImage.TabStop = false;
            // 
            // menuStartBtn
            // 
            menuStartBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            menuStartBtn.BackColor = Color.FromArgb(255, 255, 128);
            menuStartBtn.FlatAppearance.BorderSize = 0;
            menuStartBtn.FlatStyle = FlatStyle.Flat;
            menuStartBtn.Font = new Font("Microsoft Sans Serif", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStartBtn.Location = new Point(0, 320);
            menuStartBtn.Name = "menuStartBtn";
            menuStartBtn.Size = new Size(220, 70);
            menuStartBtn.TabIndex = 4;
            menuStartBtn.Text = " Start Quiz";
            menuStartBtn.TextAlign = ContentAlignment.MiddleLeft;
            menuStartBtn.UseVisualStyleBackColor = false;
            menuStartBtn.Click += startBtn_Click;
            // 
            // menuHomeBtn
            // 
            menuHomeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            menuHomeBtn.BackColor = Color.FromArgb(192, 192, 0);
            menuHomeBtn.FlatAppearance.BorderSize = 0;
            menuHomeBtn.FlatStyle = FlatStyle.Flat;
            menuHomeBtn.Font = new Font("Microsoft Sans Serif", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuHomeBtn.Location = new Point(0, 250);
            menuHomeBtn.Name = "menuHomeBtn";
            menuHomeBtn.Size = new Size(220, 70);
            menuHomeBtn.TabIndex = 1;
            menuHomeBtn.Text = " Home";
            menuHomeBtn.TextAlign = ContentAlignment.MiddleLeft;
            menuHomeBtn.UseVisualStyleBackColor = false;
            menuHomeBtn.Click += homeBtn_Click;
            // 
            // optBarPnl
            // 
            optBarPnl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            optBarPnl.BackColor = Color.MistyRose;
            optBarPnl.Controls.Add(backBtn);
            optBarPnl.Controls.Add(optBarImage);
            optBarPnl.Dock = DockStyle.Top;
            optBarPnl.Location = new Point(230, 0);
            optBarPnl.Name = "optBarPnl";
            optBarPnl.Size = new Size(1050, 70);
            optBarPnl.TabIndex = 1;
            // 
            // backBtn
            // 
            backBtn.Anchor = AnchorStyles.Left;
            backBtn.BackColor = Color.Linen;
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backBtn.Image = Properties.Resources.backArrow;
            backBtn.ImageAlign = ContentAlignment.MiddleLeft;
            backBtn.Location = new Point(10, 15);
            backBtn.Name = "backBtn";
            backBtn.RightToLeft = RightToLeft.Yes;
            backBtn.Size = new Size(108, 40);
            backBtn.TabIndex = 2;
            backBtn.Text = "BACK";
            backBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // optBarImage
            // 
            optBarImage.BackgroundImageLayout = ImageLayout.Zoom;
            optBarImage.Dock = DockStyle.Right;
            optBarImage.Image = Properties.Resources.house;
            optBarImage.Location = new Point(981, 0);
            optBarImage.Name = "optBarImage";
            optBarImage.Size = new Size(69, 70);
            optBarImage.SizeMode = PictureBoxSizeMode.Zoom;
            optBarImage.TabIndex = 1;
            optBarImage.TabStop = false;
            // 
            // contentPnl
            // 
            contentPnl.Dock = DockStyle.Fill;
            contentPnl.Location = new Point(230, 70);
            contentPnl.Name = "contentPnl";
            contentPnl.Size = new Size(1050, 650);
            contentPnl.TabIndex = 2;
            // 
            // WordlyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(contentPnl);
            Controls.Add(optBarPnl);
            Controls.Add(menuPnl);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "WordlyForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            menuPnl.ResumeLayout(false);
            titlePnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)titleLogoImage).EndInit();
            optBarPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)optBarImage).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private Panel menuPnl;
        private Panel optBarPnl;
        private Panel contentPnl;
        private PictureBox optBarImage;
        private Panel menuIndicatorPnl;
        private Button menuCreateBtn;
        private Button menuStartBtn;
        private Button menuHomeBtn;
        private PictureBox titleLogoImage;
        private Panel titlePnl;
        private Label titleNameLbl;
        private Label titleSloganLbl;
        private Button menuQuitBtn;
        private Button menuSettingsBtn;
        private Button backBtn;
    }
}
