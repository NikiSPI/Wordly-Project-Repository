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
            termLngLbl = new Label();
            meaningLngLbl = new Label();
            termLanguageCB = new ComboBox();
            meaningLanguageCB = new ComboBox();
            roundedPanel1 = new RoundedPanel();
            meaningMessageLbl = new RoundedLabel();
            termMessageLbl = new RoundedLabel();
            roundedPanel4 = new RoundedPanel();
            meaningTB = new AdvancedTextBox();
            roundedPanel2 = new RoundedPanel();
            termTB = new AdvancedTextBox();
            addWordPairBtn = new RoundedButton();
            inputTB = new AdvancedTextBox();
            createListBtn = new RoundedButton();
            tablePnl = new RoundedPanel();
            inputTBPnl = new RoundedPanel();
            label5 = new Label();
            label6 = new Label();
            wordSignCB = new ComboBox();
            pairSignCB = new ComboBox();
            marginLbl = new Label();
            borderTPnl = new RoundedPanel();
            refreshingLbl = new Label();
            label2 = new Label();
            roundedPanel1.SuspendLayout();
            roundedPanel4.SuspendLayout();
            roundedPanel2.SuspendLayout();
            inputTBPnl.SuspendLayout();
            borderTPnl.SuspendLayout();
            SuspendLayout();
            // 
            // nameTB
            // 
            nameTB.AutomaticResize = false;
            nameTB.BorderColor = Color.Transparent;
            nameTB.BorderStyle = BorderStyle.FixedSingle;
            nameTB.BorderWidth = 0;
            nameTB.Font = new Font("Segoe UI", 18F);
            nameTB.ForeColor = Color.Black;
            nameTB.Location = new Point(245, 22);
            nameTB.MaxLineCount = 10;
            nameTB.Name = "nameTB";
            nameTB.PlaceholderText = "Type here:";
            nameTB.Size = new Size(260, 39);
            nameTB.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(213, 37);
            label1.TabIndex = 1;
            label1.Text = "Word List Name:";
            // 
            // termLngLbl
            // 
            termLngLbl.AutoSize = true;
            termLngLbl.Font = new Font("Segoe UI", 18F);
            termLngLbl.ForeColor = Color.White;
            termLngLbl.Location = new Point(63, 87);
            termLngLbl.Name = "termLngLbl";
            termLngLbl.Size = new Size(183, 32);
            termLngLbl.TabIndex = 2;
            termLngLbl.Text = "Term Language:";
            // 
            // meaningLngLbl
            // 
            meaningLngLbl.AutoSize = true;
            meaningLngLbl.Font = new Font("Segoe UI", 18F);
            meaningLngLbl.ForeColor = Color.White;
            meaningLngLbl.Location = new Point(63, 129);
            meaningLngLbl.Name = "meaningLngLbl";
            meaningLngLbl.Size = new Size(225, 32);
            meaningLngLbl.TabIndex = 3;
            meaningLngLbl.Text = "Meaning Language:";
            // 
            // termLanguageCB
            // 
            termLanguageCB.DropDownStyle = ComboBoxStyle.DropDownList;
            termLanguageCB.ForeColor = Color.Black;
            termLanguageCB.FormattingEnabled = true;
            termLanguageCB.Items.AddRange(new object[] { "Bulgarian", "Deutsch", "English", "Español", "Another" });
            termLanguageCB.Location = new Point(324, 137);
            termLanguageCB.Name = "termLanguageCB";
            termLanguageCB.Size = new Size(143, 23);
            termLanguageCB.TabIndex = 4;
            // 
            // meaningLanguageCB
            // 
            meaningLanguageCB.DropDownStyle = ComboBoxStyle.DropDownList;
            meaningLanguageCB.ForeColor = Color.Black;
            meaningLanguageCB.FormattingEnabled = true;
            meaningLanguageCB.Items.AddRange(new object[] { "Bulgarian", "Deutsch", "English", "Español", "Another" });
            meaningLanguageCB.Location = new Point(324, 96);
            meaningLanguageCB.Name = "meaningLanguageCB";
            meaningLanguageCB.Size = new Size(143, 23);
            meaningLanguageCB.TabIndex = 5;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.FromArgb(52, 52, 52);
            roundedPanel1.BorderColor = Color.Black;
            roundedPanel1.BorderThickness = 0F;
            roundedPanel1.Controls.Add(meaningMessageLbl);
            roundedPanel1.Controls.Add(termMessageLbl);
            roundedPanel1.Controls.Add(roundedPanel4);
            roundedPanel1.Controls.Add(roundedPanel2);
            roundedPanel1.CornerRadius = 30;
            roundedPanel1.Location = new Point(197, 450);
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
            roundedPanel4.BackColor = Color.FromArgb(45, 45, 45);
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
            meaningTB.BackColor = Color.FromArgb(45, 45, 45);
            meaningTB.BorderColor = Color.Empty;
            meaningTB.BorderStyle = BorderStyle.None;
            meaningTB.BorderWidth = 1;
            meaningTB.Font = new Font("Segoe UI", 15F);
            meaningTB.ForeColor = Color.WhiteSmoke;
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
            roundedPanel2.BackColor = Color.FromArgb(45, 45, 45);
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
            termTB.BackColor = Color.FromArgb(45, 45, 45);
            termTB.BorderColor = Color.Empty;
            termTB.BorderStyle = BorderStyle.None;
            termTB.BorderWidth = 1;
            termTB.Font = new Font("Segoe UI", 15F);
            termTB.ForeColor = Color.WhiteSmoke;
            termTB.Location = new Point(20, 20);
            termTB.MaxLineCount = 3;
            termTB.Multiline = true;
            termTB.Name = "termTB";
            termTB.Size = new Size(310, 29);
            termTB.TabIndex = 0;
            termTB.LineCountChanged += termTB_LineCountChanged;
            termTB.MaxLineCountReached += termTB_MaxLineCountReached;
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
            addWordPairBtn.Location = new Point(108, 470);
            addWordPairBtn.Name = "addWordPairBtn";
            addWordPairBtn.Size = new Size(70, 70);
            addWordPairBtn.TabIndex = 8;
            addWordPairBtn.UseVisualStyleBackColor = false;
            addWordPairBtn.Click += addWordPairBtn_Click;
            // 
            // inputTB
            // 
            inputTB.AutomaticResize = true;
            inputTB.BackColor = Color.FromArgb(50, 50, 50);
            inputTB.BorderColor = Color.Empty;
            inputTB.BorderStyle = BorderStyle.None;
            inputTB.BorderWidth = 0;
            inputTB.Font = new Font("Segoe UI", 12F);
            inputTB.ForeColor = Color.White;
            inputTB.Location = new Point(0, 0);
            inputTB.MaxLength = 1000000;
            inputTB.MaxLineCount = 1000;
            inputTB.Multiline = true;
            inputTB.Name = "inputTB";
            inputTB.Size = new Size(450, 400);
            inputTB.TabIndex = 9;
            inputTB.SizeChanged += inputTB_SizeChanged;
            inputTB.TextChanged += inputTB_TextChanged;
            // 
            // createListBtn
            // 
            createListBtn.BackColor = Color.WhiteSmoke;
            createListBtn.BorderColor = Color.Black;
            createListBtn.BorderThickness = 0F;
            createListBtn.CornerRadius = 15;
            createListBtn.FlatAppearance.BorderColor = Color.WhiteSmoke;
            createListBtn.FlatAppearance.BorderSize = 0;
            createListBtn.FlatStyle = FlatStyle.Flat;
            createListBtn.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            createListBtn.ForeColor = Color.FromArgb(50, 60, 60);
            createListBtn.Location = new Point(108, 328);
            createListBtn.Name = "createListBtn";
            createListBtn.Size = new Size(200, 70);
            createListBtn.TabIndex = 10;
            createListBtn.Text = "Create";
            createListBtn.UseVisualStyleBackColor = false;
            createListBtn.Click += createListBtn_Click;
            // 
            // tablePnl
            // 
            tablePnl.BackColor = Color.FromArgb(43, 48, 48);
            tablePnl.BorderColor = Color.Gray;
            tablePnl.BorderThickness = 0F;
            tablePnl.CornerRadius = 10;
            tablePnl.Location = new Point(2, 2);
            tablePnl.Name = "tablePnl";
            tablePnl.Size = new Size(900, 30);
            tablePnl.TabIndex = 11;
            // 
            // inputTBPnl
            // 
            inputTBPnl.AutoScroll = true;
            inputTBPnl.AutoScrollMargin = new Size(0, 200);
            inputTBPnl.BackColor = Color.FromArgb(50, 50, 50);
            inputTBPnl.BorderColor = Color.Black;
            inputTBPnl.BorderThickness = 0F;
            inputTBPnl.Controls.Add(inputTB);
            inputTBPnl.CornerRadius = 10;
            inputTBPnl.Location = new Point(539, 20);
            inputTBPnl.Name = "inputTBPnl";
            inputTBPnl.Size = new Size(467, 400);
            inputTBPnl.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(63, 191);
            label5.Name = "label5";
            label5.Size = new Size(286, 32);
            label5.TabIndex = 13;
            label5.Text = "Term-Meaning Separator:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(63, 235);
            label6.Name = "label6";
            label6.Size = new Size(235, 32);
            label6.TabIndex = 14;
            label6.Text = "Wordpairs Separator:";
            // 
            // wordSignCB
            // 
            wordSignCB.DropDownStyle = ComboBoxStyle.DropDownList;
            wordSignCB.Font = new Font("Segoe UI", 18F);
            wordSignCB.ForeColor = Color.Black;
            wordSignCB.FormattingEnabled = true;
            wordSignCB.Items.AddRange(new object[] { ",", ";", "-", "=", "/", "_" });
            wordSignCB.Location = new Point(373, 190);
            wordSignCB.Name = "wordSignCB";
            wordSignCB.Size = new Size(94, 40);
            wordSignCB.TabIndex = 15;
            wordSignCB.SelectionChangeCommitted += wordSignCB_SelectionChangeCommitted;
            // 
            // pairSignCB
            // 
            pairSignCB.DropDownStyle = ComboBoxStyle.DropDownList;
            pairSignCB.Font = new Font("Segoe UI", 18F);
            pairSignCB.ForeColor = Color.Black;
            pairSignCB.FormattingEnabled = true;
            pairSignCB.Items.AddRange(new object[] { ",", ";", "-", "=", "/", "_", "Enter" });
            pairSignCB.Location = new Point(373, 234);
            pairSignCB.Name = "pairSignCB";
            pairSignCB.Size = new Size(94, 40);
            pairSignCB.TabIndex = 16;
            pairSignCB.SelectionChangeCommitted += pairSignCB_SelectionChangeCommitted;
            // 
            // marginLbl
            // 
            marginLbl.Location = new Point(0, 0);
            marginLbl.Name = "marginLbl";
            marginLbl.Size = new Size(0, 0);
            marginLbl.TabIndex = 18;
            // 
            // borderTPnl
            // 
            borderTPnl.AutoScroll = true;
            borderTPnl.BackColor = Color.Gray;
            borderTPnl.BorderColor = Color.Black;
            borderTPnl.BorderThickness = 0F;
            borderTPnl.Controls.Add(tablePnl);
            borderTPnl.CornerRadius = 12;
            borderTPnl.Location = new Point(73, 586);
            borderTPnl.Name = "borderTPnl";
            borderTPnl.Size = new Size(904, 34);
            borderTPnl.TabIndex = 19;
            // 
            // refreshingLbl
            // 
            refreshingLbl.AutoSize = true;
            refreshingLbl.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            refreshingLbl.ForeColor = Color.Gainsboro;
            refreshingLbl.Location = new Point(75, 563);
            refreshingLbl.Name = "refreshingLbl";
            refreshingLbl.Size = new Size(92, 21);
            refreshingLbl.TabIndex = 20;
            refreshingLbl.Text = "Refreshing...";
            refreshingLbl.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(395, 401);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 21;
            // 
            // Creation_Window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMargin = new Size(0, 30);
            BackColor = Color.FromArgb(60, 60, 60);
            ClientSize = new Size(1050, 650);
            Controls.Add(label2);
            Controls.Add(marginLbl);
            Controls.Add(pairSignCB);
            Controls.Add(wordSignCB);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(createListBtn);
            Controls.Add(addWordPairBtn);
            Controls.Add(roundedPanel1);
            Controls.Add(meaningLanguageCB);
            Controls.Add(termLanguageCB);
            Controls.Add(meaningLngLbl);
            Controls.Add(termLngLbl);
            Controls.Add(label1);
            Controls.Add(nameTB);
            Controls.Add(inputTBPnl);
            Controls.Add(borderTPnl);
            Controls.Add(refreshingLbl);
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
            borderTPnl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AdvancedTextBox nameTB;
        private Label label1;
        private Label termLngLbl;
        private Label meaningLngLbl;
        private ComboBox termLanguageCB;
        private ComboBox meaningLanguageCB;
        private RoundedPanel roundedPanel1;
        private RoundedPanel roundedPanel4;
        private RoundedPanel roundedPanel2;
        private AdvancedTextBox termTB;
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
        private Label marginLbl;
        private RoundedPanel borderTPnl;
        private Label refreshingLbl;
        private Label label2;
    }
}