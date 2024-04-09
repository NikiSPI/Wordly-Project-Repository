
using RoundedComponents;

namespace Wordly_alpha 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordlyForm));
            menuPnl = new Panel();
            label1 = new Label();
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
            backBtn = new RoundedButton();
            contentPnl = new Panel();
            menuPnl.SuspendLayout();
            titlePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)titleLogoImage).BeginInit();
            optBarPnl.SuspendLayout();
            SuspendLayout();
            // 
            // menuPnl
            // 
            menuPnl.BackColor = Color.FromArgb(30, 30, 30);
            menuPnl.Controls.Add(label1);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveBorder;
            label1.Location = new Point(62, 450);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 9;
            label1.Text = "(coming soon)";
            // 
            // menuIndicatorPnl
            // 
            menuIndicatorPnl.BackColor = Color.FromArgb(190, 200, 200);
            menuIndicatorPnl.Location = new Point(0, 255);
            menuIndicatorPnl.Name = "menuIndicatorPnl";
            menuIndicatorPnl.Size = new Size(5, 70);
            menuIndicatorPnl.TabIndex = 6;
            // 
            // menuSettingsBtn
            // 
            menuSettingsBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            menuSettingsBtn.BackColor = Color.FromArgb(30, 30, 30);
            menuSettingsBtn.FlatAppearance.BorderSize = 0;
            menuSettingsBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(70, 70, 70);
            menuSettingsBtn.FlatStyle = FlatStyle.Flat;
            menuSettingsBtn.Font = new Font("Calibri", 27.75F, FontStyle.Bold);
            menuSettingsBtn.ForeColor = Color.FromArgb(190, 200, 200);
            menuSettingsBtn.Location = new Point(0, 570);
            menuSettingsBtn.Name = "menuSettingsBtn";
            menuSettingsBtn.Size = new Size(230, 70);
            menuSettingsBtn.TabIndex = 0;
            menuSettingsBtn.TabStop = false;
            menuSettingsBtn.Text = " Settings";
            menuSettingsBtn.TextAlign = ContentAlignment.MiddleLeft;
            menuSettingsBtn.UseMnemonic = false;
            menuSettingsBtn.UseVisualStyleBackColor = false;
            menuSettingsBtn.Click += settingsBtn_Click;
            // 
            // menuQuitBtn
            // 
            menuQuitBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            menuQuitBtn.BackColor = Color.FromArgb(30, 30, 30);
            menuQuitBtn.FlatAppearance.BorderColor = Color.FromArgb(30, 30, 30);
            menuQuitBtn.FlatAppearance.BorderSize = 0;
            menuQuitBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(70, 70, 70);
            menuQuitBtn.FlatStyle = FlatStyle.Flat;
            menuQuitBtn.Font = new Font("Calibri", 27.75F, FontStyle.Bold);
            menuQuitBtn.ForeColor = Color.FromArgb(190, 200, 200);
            menuQuitBtn.Location = new Point(0, 640);
            menuQuitBtn.Name = "menuQuitBtn";
            menuQuitBtn.Size = new Size(230, 70);
            menuQuitBtn.TabIndex = 0;
            menuQuitBtn.TabStop = false;
            menuQuitBtn.Text = " Quit";
            menuQuitBtn.TextAlign = ContentAlignment.MiddleLeft;
            menuQuitBtn.UseMnemonic = false;
            menuQuitBtn.UseVisualStyleBackColor = false;
            menuQuitBtn.Click += quitBtn_Click;
            // 
            // menuCreateBtn
            // 
            menuCreateBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            menuCreateBtn.BackColor = Color.FromArgb(30, 30, 30);
            menuCreateBtn.FlatAppearance.BorderColor = Color.FromArgb(30, 30, 30);
            menuCreateBtn.FlatAppearance.BorderSize = 0;
            menuCreateBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 30, 30);
            menuCreateBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 30);
            menuCreateBtn.FlatStyle = FlatStyle.Flat;
            menuCreateBtn.Font = new Font("Calibri", 27.75F, FontStyle.Bold);
            menuCreateBtn.ForeColor = Color.FromArgb(190, 200, 200);
            menuCreateBtn.Location = new Point(0, 395);
            menuCreateBtn.Name = "menuCreateBtn";
            menuCreateBtn.Size = new Size(230, 70);
            menuCreateBtn.TabIndex = 0;
            menuCreateBtn.TabStop = false;
            menuCreateBtn.Text = " Create List";
            menuCreateBtn.TextAlign = ContentAlignment.MiddleLeft;
            menuCreateBtn.UseMnemonic = false;
            menuCreateBtn.UseVisualStyleBackColor = false;
            // 
            // titlePnl
            // 
            titlePnl.BackColor = Color.Transparent;
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
            titleSloganLbl.BackColor = Color.Transparent;
            titleSloganLbl.Dock = DockStyle.Fill;
            titleSloganLbl.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleSloganLbl.ForeColor = Color.FromArgb(210, 235, 235);
            titleSloganLbl.Location = new Point(0, 170);
            titleSloganLbl.Name = "titleSloganLbl";
            titleSloganLbl.Padding = new Padding(0, 0, 0, 15);
            titleSloganLbl.Size = new Size(230, 70);
            titleSloganLbl.TabIndex = 12;
            titleSloganLbl.Text = "The Ultimate\r\n Word Check Helper";
            titleSloganLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // titleNameLbl
            // 
            titleNameLbl.BackColor = Color.Transparent;
            titleNameLbl.Dock = DockStyle.Top;
            titleNameLbl.Font = new Font("Times New Roman", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleNameLbl.ForeColor = Color.FromArgb(210, 250, 250);
            titleNameLbl.Location = new Point(0, 100);
            titleNameLbl.Name = "titleNameLbl";
            titleNameLbl.Size = new Size(230, 70);
            titleNameLbl.TabIndex = 11;
            titleNameLbl.Text = "Wordly";
            titleNameLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // titleLogoImage
            // 
            titleLogoImage.BackColor = Color.Transparent;
            titleLogoImage.Dock = DockStyle.Top;
            titleLogoImage.Image = Properties.Resources.defaultProfilePicWhite;
            titleLogoImage.Location = new Point(0, 0);
            titleLogoImage.Name = "titleLogoImage";
            titleLogoImage.Size = new Size(230, 100);
            titleLogoImage.SizeMode = PictureBoxSizeMode.Zoom;
            titleLogoImage.TabIndex = 9;
            titleLogoImage.TabStop = false;
            // 
            // menuStartBtn
            // 
            menuStartBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            menuStartBtn.BackColor = Color.FromArgb(30, 30, 30);
            menuStartBtn.FlatAppearance.BorderSize = 0;
            menuStartBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(70, 70, 70);
            menuStartBtn.FlatStyle = FlatStyle.Flat;
            menuStartBtn.Font = new Font("Calibri", 27.75F, FontStyle.Bold);
            menuStartBtn.ForeColor = Color.FromArgb(190, 200, 200);
            menuStartBtn.Location = new Point(0, 325);
            menuStartBtn.Name = "menuStartBtn";
            menuStartBtn.Size = new Size(230, 70);
            menuStartBtn.TabIndex = 0;
            menuStartBtn.TabStop = false;
            menuStartBtn.Text = " Start Quiz";
            menuStartBtn.TextAlign = ContentAlignment.MiddleLeft;
            menuStartBtn.UseMnemonic = false;
            menuStartBtn.UseVisualStyleBackColor = false;
            menuStartBtn.Click += startBtn_Click;
            // 
            // menuHomeBtn
            // 
            menuHomeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            menuHomeBtn.BackColor = Color.FromArgb(30, 30, 30);
            menuHomeBtn.FlatAppearance.BorderSize = 0;
            menuHomeBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 60);
            menuHomeBtn.FlatStyle = FlatStyle.Flat;
            menuHomeBtn.Font = new Font("Calibri", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuHomeBtn.ForeColor = Color.FromArgb(190, 200, 200);
            menuHomeBtn.Location = new Point(0, 255);
            menuHomeBtn.Name = "menuHomeBtn";
            menuHomeBtn.Size = new Size(230, 70);
            menuHomeBtn.TabIndex = 0;
            menuHomeBtn.TabStop = false;
            menuHomeBtn.Text = " Home";
            menuHomeBtn.TextAlign = ContentAlignment.MiddleLeft;
            menuHomeBtn.UseMnemonic = false;
            menuHomeBtn.UseVisualStyleBackColor = false;
            menuHomeBtn.Click += homeBtn_Click;
            // 
            // optBarPnl
            // 
            optBarPnl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            optBarPnl.BackColor = Color.FromArgb(40, 40, 40);
            optBarPnl.Controls.Add(backBtn);
            optBarPnl.Dock = DockStyle.Top;
            optBarPnl.ForeColor = Color.DimGray;
            optBarPnl.Location = new Point(230, 0);
            optBarPnl.Name = "optBarPnl";
            optBarPnl.Size = new Size(1050, 70);
            optBarPnl.TabIndex = 1;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.FromArgb(220, 230, 230);
            backBtn.FlatAppearance.BorderColor = Color.FromArgb(220, 230, 230);
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(170, 180, 180);
            backBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 210, 210);
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backBtn.ForeColor = Color.Black;
            backBtn.Image = Properties.Resources.arrowLeft;
            backBtn.ImageAlign = ContentAlignment.MiddleRight;
            backBtn.Location = new Point(15, 15);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(110, 40);
            backBtn.TabIndex = 0;
            backBtn.TabStop = false;
            backBtn.Text = " BACK";
            backBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // contentPnl
            // 
            contentPnl.BackColor = Color.FromArgb(60, 60, 60);
            contentPnl.Dock = DockStyle.Fill;
            contentPnl.ForeColor = Color.Transparent;
            contentPnl.Location = new Point(230, 70);
            contentPnl.Name = "contentPnl";
            contentPnl.Size = new Size(1050, 650);
            contentPnl.TabIndex = 2;
            // 
            // WordlyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1280, 720);
            Controls.Add(contentPnl);
            Controls.Add(optBarPnl);
            Controls.Add(menuPnl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "WordlyForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Wordly (alpha)";
            menuPnl.ResumeLayout(false);
            menuPnl.PerformLayout();
            titlePnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)titleLogoImage).EndInit();
            optBarPnl.ResumeLayout(false);
            ResumeLayout(false);
        }


        #endregion

        private Panel menuPnl;
        private Panel optBarPnl;
        private Panel contentPnl;
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
        private RoundedButton backBtn;
        private Label label1;
    }
}
