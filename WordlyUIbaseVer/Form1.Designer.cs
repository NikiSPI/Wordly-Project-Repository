namespace WordlyUIbaseVer
{
    partial class Form1
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
            optionsPnl = new Panel();
            selectedButtonPnl = new Panel();
            setttingsBtn = new Button();
            quitBtn = new Button();
            createBtn = new Button();
            startBtn = new Button();
            homeBtn = new Button();
            userPnl = new Panel();
            usernameLbl = new Label();
            somethingLbl = new Label();
            logo = new PictureBox();
            titleLabel = new Panel();
            titleLogo = new PictureBox();
            titleLbl = new Label();
            mainPnl = new Panel();
            optionsPnl.SuspendLayout();
            userPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            titleLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)titleLogo).BeginInit();
            SuspendLayout();
            // 
            // optionsPnl
            // 
            optionsPnl.BackColor = SystemColors.GradientInactiveCaption;
            optionsPnl.Controls.Add(selectedButtonPnl);
            optionsPnl.Controls.Add(setttingsBtn);
            optionsPnl.Controls.Add(quitBtn);
            optionsPnl.Controls.Add(createBtn);
            optionsPnl.Controls.Add(startBtn);
            optionsPnl.Controls.Add(homeBtn);
            optionsPnl.Controls.Add(userPnl);
            optionsPnl.Dock = DockStyle.Left;
            optionsPnl.Location = new Point(0, 0);
            optionsPnl.Name = "optionsPnl";
            optionsPnl.Size = new Size(200, 600);
            optionsPnl.TabIndex = 0;
            // 
            // selectedButtonPnl
            // 
            selectedButtonPnl.BackColor = Color.Black;
            selectedButtonPnl.Location = new Point(0, 200);
            selectedButtonPnl.Name = "selectedButtonPnl";
            selectedButtonPnl.Size = new Size(5, 50);
            selectedButtonPnl.TabIndex = 6;
            // 
            // setttingsBtn
            // 
            setttingsBtn.BackColor = Color.LightGray;
            setttingsBtn.Dock = DockStyle.Bottom;
            setttingsBtn.FlatAppearance.BorderSize = 0;
            setttingsBtn.FlatStyle = FlatStyle.Flat;
            setttingsBtn.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            setttingsBtn.Location = new Point(0, 500);
            setttingsBtn.Name = "setttingsBtn";
            setttingsBtn.Size = new Size(200, 50);
            setttingsBtn.TabIndex = 5;
            setttingsBtn.Text = "Setttings";
            setttingsBtn.UseVisualStyleBackColor = false;
            setttingsBtn.Click += setttingsBtn_Click;
            // 
            // quitBtn
            // 
            quitBtn.BackColor = Color.LightGray;
            quitBtn.Dock = DockStyle.Bottom;
            quitBtn.FlatAppearance.BorderSize = 0;
            quitBtn.FlatStyle = FlatStyle.Flat;
            quitBtn.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quitBtn.Location = new Point(0, 550);
            quitBtn.Name = "quitBtn";
            quitBtn.Size = new Size(200, 50);
            quitBtn.TabIndex = 4;
            quitBtn.Text = "Quit";
            quitBtn.UseVisualStyleBackColor = false;
            quitBtn.Click += quitBtn_Click;
            // 
            // createBtn
            // 
            createBtn.BackColor = Color.FromArgb(255, 255, 128);
            createBtn.Dock = DockStyle.Top;
            createBtn.FlatAppearance.BorderSize = 0;
            createBtn.FlatStyle = FlatStyle.Flat;
            createBtn.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createBtn.Location = new Point(0, 300);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(200, 50);
            createBtn.TabIndex = 3;
            createBtn.Text = "Create Word List";
            createBtn.UseVisualStyleBackColor = false;
            createBtn.Click += createBtn_Click;
            // 
            // startBtn
            // 
            startBtn.BackColor = Color.FromArgb(255, 255, 128);
            startBtn.Dock = DockStyle.Top;
            startBtn.FlatAppearance.BorderSize = 0;
            startBtn.FlatStyle = FlatStyle.Flat;
            startBtn.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startBtn.Location = new Point(0, 250);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(200, 50);
            startBtn.TabIndex = 2;
            startBtn.Text = "Start Quiz";
            startBtn.UseVisualStyleBackColor = false;
            startBtn.Click += startBtn_Click;
            // 
            // homeBtn
            // 
            homeBtn.BackColor = Color.FromArgb(255, 255, 128);
            homeBtn.Dock = DockStyle.Top;
            homeBtn.FlatAppearance.BorderSize = 0;
            homeBtn.FlatStyle = FlatStyle.Flat;
            homeBtn.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            homeBtn.Location = new Point(0, 200);
            homeBtn.Name = "homeBtn";
            homeBtn.Size = new Size(200, 50);
            homeBtn.TabIndex = 1;
            homeBtn.Text = "Home";
            homeBtn.UseVisualStyleBackColor = false;
            homeBtn.Click += homeBtn_Click;
            // 
            // userPnl
            // 
            userPnl.Controls.Add(usernameLbl);
            userPnl.Controls.Add(somethingLbl);
            userPnl.Controls.Add(logo);
            userPnl.Dock = DockStyle.Top;
            userPnl.Location = new Point(0, 0);
            userPnl.Name = "userPnl";
            userPnl.Size = new Size(200, 200);
            userPnl.TabIndex = 0;
            // 
            // usernameLbl
            // 
            usernameLbl.AutoSize = true;
            usernameLbl.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameLbl.Location = new Point(47, 112);
            usernameLbl.Name = "usernameLbl";
            usernameLbl.Size = new Size(105, 24);
            usernameLbl.TabIndex = 3;
            usernameLbl.Text = "Username";
            // 
            // somethingLbl
            // 
            somethingLbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            somethingLbl.AutoSize = true;
            somethingLbl.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            somethingLbl.Location = new Point(60, 148);
            somethingLbl.Name = "somethingLbl";
            somethingLbl.Size = new Size(77, 18);
            somethingLbl.TabIndex = 2;
            somethingLbl.Text = "something";
            // 
            // logo
            // 
            logo.Dock = DockStyle.Top;
            logo.Image = Properties.Resources.Android_O_Preview_Logo;
            logo.Location = new Point(0, 0);
            logo.Name = "logo";
            logo.Size = new Size(200, 100);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.MistyRose;
            titleLabel.Controls.Add(titleLogo);
            titleLabel.Controls.Add(titleLbl);
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Location = new Point(200, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(600, 75);
            titleLabel.TabIndex = 1;
            // 
            // titleLogo
            // 
            titleLogo.Dock = DockStyle.Right;
            titleLogo.Image = Properties.Resources.house;
            titleLogo.Location = new Point(525, 0);
            titleLogo.Name = "titleLogo";
            titleLogo.Size = new Size(75, 75);
            titleLogo.SizeMode = PictureBoxSizeMode.Zoom;
            titleLogo.TabIndex = 1;
            titleLogo.TabStop = false;
            // 
            // titleLbl
            // 
            titleLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            titleLbl.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLbl.ImageAlign = ContentAlignment.MiddleRight;
            titleLbl.Location = new Point(10, 0);
            titleLbl.Name = "titleLbl";
            titleLbl.RightToLeft = RightToLeft.No;
            titleLbl.Size = new Size(515, 75);
            titleLbl.TabIndex = 0;
            titleLbl.Text = "Home";
            titleLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // mainPnl
            // 
            mainPnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPnl.Location = new Point(200, 75);
            mainPnl.Name = "mainPnl";
            mainPnl.Size = new Size(600, 525);
            mainPnl.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(mainPnl);
            Controls.Add(titleLabel);
            Controls.Add(optionsPnl);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            optionsPnl.ResumeLayout(false);
            userPnl.ResumeLayout(false);
            userPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            titleLabel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)titleLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel optionsPnl;
        private Panel userPnl;
        private PictureBox logo;
        private Label somethingLbl;
        private Button createBtn;
        private Button startBtn;
        private Button homeBtn;
        private Button quitBtn;
        private Button setttingsBtn;
        private Label usernameLbl;
        private Panel titleLabel;
        private Label titleLbl;
        private Panel mainPnl;
        private PictureBox titleLogo;
        private Panel selectedButtonPnl;
    }
}
