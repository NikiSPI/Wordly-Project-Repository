namespace Wordly
{
    partial class Creation_Window
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
            nameTB = new AdvancedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            termLanguageCB = new ComboBox();
            meaningLanguageCB = new ComboBox();
            roundedPanel1 = new RoundedPanel();
            meaningMessageLbl = new RoundedLabel();
            termMessageLbl = new RoundedLabel();
            roundedPanel4 = new RoundedPanel();
            meaningTB = new AdvancedTextBox();
            roundedPanel2 = new RoundedPanel();
            termTB = new AdvancedTextBox();
            label4 = new Label();
            addWordPairBtn = new RoundedButton();
            inputTB = new AdvancedTextBox();
            createListBtn = new RoundedButton();
            tablePnl = new RoundedPanel();
            inputTBPnl = new RoundedPanel();
            label5 = new Label();
            label6 = new Label();
            wordSignCB = new ComboBox();
            pairSignCB = new ComboBox();
            roundedButton1 = new RoundedButton();
            marginLbl = new Label();
            roundedPanel1.SuspendLayout();
            roundedPanel4.SuspendLayout();
            roundedPanel2.SuspendLayout();
            inputTBPnl.SuspendLayout();
            SuspendLayout();
            // 
            // nameTB
            // 
            nameTB.AutomaticResize = false;
            nameTB.BorderColor = Color.Transparent;
            nameTB.BorderStyle = BorderStyle.FixedSingle;
            nameTB.BorderWidth = 0;
            nameTB.Font = new Font("Segoe UI", 20F);
            nameTB.Location = new Point(305, 56);
            nameTB.MaxLineCount = 10;
            nameTB.Name = "nameTB";
            nameTB.PlaceholderText = "Type here";
            nameTB.Size = new Size(228, 43);
            nameTB.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(56, 58);
            label1.Name = "label1";
            label1.Size = new Size(213, 37);
            label1.TabIndex = 1;
            label1.Text = "Word List Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(56, 109);
            label2.Name = "label2";
            label2.Size = new Size(204, 37);
            label2.TabIndex = 2;
            label2.Text = "Term Language:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(56, 165);
            label3.Name = "label3";
            label3.Size = new Size(252, 37);
            label3.TabIndex = 3;
            label3.Text = "Meaning Language:";
            // 
            // termLanguageCB
            // 
            termLanguageCB.FormattingEnabled = true;
            termLanguageCB.Items.AddRange(new object[] { "Bulgarian", "Deutsch", "English", "Español" });
            termLanguageCB.Location = new Point(318, 123);
            termLanguageCB.Name = "termLanguageCB";
            termLanguageCB.Size = new Size(143, 23);
            termLanguageCB.TabIndex = 4;
            termLanguageCB.Text = "Select Here:";
            // 
            // meaningLanguageCB
            // 
            meaningLanguageCB.FormattingEnabled = true;
            meaningLanguageCB.Items.AddRange(new object[] { "Bulgarian", "Deutsch", "English", "Español" });
            meaningLanguageCB.Location = new Point(329, 180);
            meaningLanguageCB.Name = "meaningLanguageCB";
            meaningLanguageCB.Size = new Size(143, 23);
            meaningLanguageCB.TabIndex = 5;
            meaningLanguageCB.Text = "Select Here:";
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = SystemColors.Highlight;
            roundedPanel1.BorderColor = Color.Black;
            roundedPanel1.BorderThickness = 0F;
            roundedPanel1.Controls.Add(meaningMessageLbl);
            roundedPanel1.Controls.Add(termMessageLbl);
            roundedPanel1.Controls.Add(roundedPanel4);
            roundedPanel1.Controls.Add(roundedPanel2);
            roundedPanel1.CornerRadius = 15;
            roundedPanel1.Location = new Point(222, 495);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(750, 110);
            roundedPanel1.TabIndex = 6;
            // 
            // meaningMessageLbl
            // 
            meaningMessageLbl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            meaningMessageLbl.AutoSize = true;
            meaningMessageLbl.BackColor = Color.Salmon;
            meaningMessageLbl.BorderColor = Color.Black;
            meaningMessageLbl.BorderThickness = 0F;
            meaningMessageLbl.CornerRadius = 4;
            meaningMessageLbl.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            meaningMessageLbl.ForeColor = Color.Black;
            meaningMessageLbl.Location = new Point(576, 87);
            meaningMessageLbl.Name = "meaningMessageLbl";
            meaningMessageLbl.Size = new Size(142, 19);
            meaningMessageLbl.TabIndex = 3;
            meaningMessageLbl.Text = "Meaning is too long! ";
            meaningMessageLbl.Visible = false;
            // 
            // termMessageLbl
            // 
            termMessageLbl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            termMessageLbl.AutoSize = true;
            termMessageLbl.BackColor = Color.Salmon;
            termMessageLbl.BorderColor = Color.Black;
            termMessageLbl.BorderThickness = 0F;
            termMessageLbl.CornerRadius = 4;
            termMessageLbl.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            termMessageLbl.ForeColor = Color.Black;
            termMessageLbl.Location = new Point(231, 87);
            termMessageLbl.Name = "termMessageLbl";
            termMessageLbl.Size = new Size(119, 19);
            termMessageLbl.TabIndex = 1;
            termMessageLbl.Text = "Term is too long! ";
            termMessageLbl.Visible = false;
            // 
            // roundedPanel4
            // 
            roundedPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            roundedPanel4.BackColor = Color.RosyBrown;
            roundedPanel4.BorderColor = Color.Black;
            roundedPanel4.BorderThickness = 0F;
            roundedPanel4.Controls.Add(meaningTB);
            roundedPanel4.CornerRadius = 15;
            roundedPanel4.Location = new Point(385, 20);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(350, 70);
            roundedPanel4.TabIndex = 2;
            // 
            // meaningTB
            // 
            meaningTB.AutomaticResize = true;
            meaningTB.BackColor = Color.RosyBrown;
            meaningTB.BorderColor = Color.Empty;
            meaningTB.BorderStyle = BorderStyle.None;
            meaningTB.BorderWidth = 1;
            meaningTB.Font = new Font("Segoe UI", 15F);
            meaningTB.Location = new Point(20, 20);
            meaningTB.MaxLineCount = 3;
            meaningTB.Multiline = true;
            meaningTB.Name = "meaningTB";
            meaningTB.Size = new Size(310, 29);
            meaningTB.TabIndex = 1;
            meaningTB.LineCountChanged += meaningTB_LineCountChanged;
            meaningTB.MaxLineCountReached += meaningTB_MaxLineCountReached;
            // 
            // roundedPanel2
            // 
            roundedPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            roundedPanel2.BackColor = Color.RosyBrown;
            roundedPanel2.BorderColor = Color.Black;
            roundedPanel2.BorderThickness = 0F;
            roundedPanel2.Controls.Add(termTB);
            roundedPanel2.CornerRadius = 15;
            roundedPanel2.Location = new Point(15, 20);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(350, 70);
            roundedPanel2.TabIndex = 0;
            // 
            // termTB
            // 
            termTB.AutomaticResize = true;
            termTB.BackColor = Color.RosyBrown;
            termTB.BorderColor = Color.Empty;
            termTB.BorderStyle = BorderStyle.None;
            termTB.BorderWidth = 1;
            termTB.Font = new Font("Segoe UI", 15F);
            termTB.Location = new Point(20, 20);
            termTB.MaxLineCount = 3;
            termTB.Multiline = true;
            termTB.Name = "termTB";
            termTB.Size = new Size(310, 29);
            termTB.TabIndex = 0;
            termTB.LineCountChanged += termTB_LineCountChanged;
            termTB.MaxLineCountReached += termTB_MaxLineCountReached;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 35F);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(52, 62);
            label4.TabIndex = 7;
            label4.Text = "0";
            // 
            // addWordPairBtn
            // 
            addWordPairBtn.BackColor = Color.Chartreuse;
            addWordPairBtn.BackgroundImage = Properties.Resources.plusSign;
            addWordPairBtn.BackgroundImageLayout = ImageLayout.Zoom;
            addWordPairBtn.BorderColor = Color.Black;
            addWordPairBtn.BorderThickness = 0F;
            addWordPairBtn.CornerRadius = 20;
            addWordPairBtn.FlatAppearance.BorderColor = Color.Chartreuse;
            addWordPairBtn.FlatAppearance.BorderSize = 0;
            addWordPairBtn.FlatStyle = FlatStyle.Flat;
            addWordPairBtn.Location = new Point(103, 515);
            addWordPairBtn.Name = "addWordPairBtn";
            addWordPairBtn.Size = new Size(70, 70);
            addWordPairBtn.TabIndex = 8;
            addWordPairBtn.UseVisualStyleBackColor = false;
            addWordPairBtn.Click += addWordPairBtn_Click;
            // 
            // inputTB
            // 
            inputTB.AutomaticResize = true;
            inputTB.BackColor = Color.Yellow;
            inputTB.BorderColor = Color.Empty;
            inputTB.BorderStyle = BorderStyle.None;
            inputTB.BorderWidth = 0;
            inputTB.Font = new Font("Segoe UI", 12F);
            inputTB.Location = new Point(0, 0);
            inputTB.MaxLength = 1000000;
            inputTB.MaxLineCount = 1000;
            inputTB.Multiline = true;
            inputTB.Name = "inputTB";
            inputTB.Size = new Size(450, 400);
            inputTB.TabIndex = 9;
            inputTB.SizeChanged += inputTB_SizeChanged;
            // 
            // createListBtn
            // 
            createListBtn.BackColor = Color.White;
            createListBtn.BorderColor = Color.Black;
            createListBtn.BorderThickness = 0F;
            createListBtn.CornerRadius = 5;
            createListBtn.FlatAppearance.BorderColor = Color.White;
            createListBtn.FlatAppearance.BorderSize = 0;
            createListBtn.FlatStyle = FlatStyle.Flat;
            createListBtn.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createListBtn.Location = new Point(56, 399);
            createListBtn.Name = "createListBtn";
            createListBtn.Size = new Size(125, 62);
            createListBtn.TabIndex = 10;
            createListBtn.Text = "Create";
            createListBtn.UseVisualStyleBackColor = false;
            createListBtn.Click += createListBtn_Click;
            // 
            // tablePnl
            // 
            tablePnl.BackColor = Color.HotPink;
            tablePnl.BorderColor = Color.Black;
            tablePnl.BorderThickness = 0F;
            tablePnl.CornerRadius = 10;
            tablePnl.Location = new Point(94, 628);
            tablePnl.Name = "tablePnl";
            tablePnl.Size = new Size(900, 30);
            tablePnl.TabIndex = 11;
            // 
            // inputTBPnl
            // 
            inputTBPnl.AutoScroll = true;
            inputTBPnl.AutoScrollMargin = new Size(0, 200);
            inputTBPnl.BackColor = Color.Yellow;
            inputTBPnl.BorderColor = Color.Black;
            inputTBPnl.BorderThickness = 0F;
            inputTBPnl.Controls.Add(inputTB);
            inputTBPnl.CornerRadius = 10;
            inputTBPnl.Location = new Point(539, 28);
            inputTBPnl.Name = "inputTBPnl";
            inputTBPnl.Size = new Size(467, 400);
            inputTBPnl.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F);
            label5.Location = new Point(28, 247);
            label5.Name = "label5";
            label5.Size = new Size(377, 32);
            label5.TabIndex = 13;
            label5.Text = "Sign for term-meaning separation";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(28, 298);
            label6.Name = "label6";
            label6.Size = new Size(316, 32);
            label6.TabIndex = 14;
            label6.Text = "Sign for wordpair separation";
            // 
            // wordSignCB
            // 
            wordSignCB.Font = new Font("Segoe UI", 20F);
            wordSignCB.FormattingEnabled = true;
            wordSignCB.Items.AddRange(new object[] { ",", ";", "-", "=", "/", "_" });
            wordSignCB.Location = new Point(426, 247);
            wordSignCB.Name = "wordSignCB";
            wordSignCB.Size = new Size(94, 45);
            wordSignCB.TabIndex = 15;
            wordSignCB.SelectionChangeCommitted += wordSignCB_SelectionChangeCommitted;
            // 
            // pairSignCB
            // 
            pairSignCB.Font = new Font("Segoe UI", 20F);
            pairSignCB.FormattingEnabled = true;
            pairSignCB.Items.AddRange(new object[] { ",", ";", "-", "=", "/", "_", "Enter" });
            pairSignCB.Location = new Point(426, 298);
            pairSignCB.Name = "pairSignCB";
            pairSignCB.Size = new Size(94, 45);
            pairSignCB.TabIndex = 16;
            pairSignCB.SelectionChangeCommitted += pairSignCB_SelectionChangeCommitted;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.White;
            roundedButton1.BorderColor = Color.Black;
            roundedButton1.BorderThickness = 0F;
            roundedButton1.CornerRadius = 5;
            roundedButton1.FlatAppearance.BorderColor = Color.White;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Location = new Point(300, 415);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(75, 23);
            roundedButton1.TabIndex = 17;
            roundedButton1.Text = "roundedButton1";
            roundedButton1.UseVisualStyleBackColor = false;
            roundedButton1.Click += roundedButton1_Click;
            // 
            // marginLbl
            // 
            marginLbl.Location = new Point(0, 0);
            marginLbl.Name = "marginLbl";
            marginLbl.Size = new Size(0, 0);
            marginLbl.TabIndex = 18;
            // 
            // Creation_Window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMargin = new Size(0, 50);
            BackColor = Color.Green;
            ClientSize = new Size(1050, 650);
            Controls.Add(marginLbl);
            Controls.Add(roundedButton1);
            Controls.Add(pairSignCB);
            Controls.Add(wordSignCB);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tablePnl);
            Controls.Add(createListBtn);
            Controls.Add(addWordPairBtn);
            Controls.Add(label4);
            Controls.Add(roundedPanel1);
            Controls.Add(meaningLanguageCB);
            Controls.Add(termLanguageCB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nameTB);
            Controls.Add(inputTBPnl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Creation_Window";
            Text = "Creation_Window";
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            roundedPanel4.ResumeLayout(false);
            roundedPanel4.PerformLayout();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            inputTBPnl.ResumeLayout(false);
            inputTBPnl.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AdvancedTextBox nameTB;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox termLanguageCB;
        private ComboBox meaningLanguageCB;
        private RoundedPanel roundedPanel1;
        private RoundedPanel roundedPanel4;
        private RoundedPanel roundedPanel2;
        private AdvancedTextBox termTB;
        private Label label4;
        private AdvancedTextBox meaningTB;
        private RoundedButton addWordPairBtn;
        private RoundedLabel termMessageLbl;
        private RoundedLabel meaningMessageLbl;
        private AdvancedTextBox inputTB;
        private RoundedButton createListBtn;
        private RoundedPanel tablePnl;
        private RoundedPanel inputTBPnl;
        private Label label5;
        private Label label6;
        private ComboBox wordSignCB;
        private ComboBox pairSignCB;
        private RoundedButton roundedButton1;
        private Label marginLbl;
    }
}