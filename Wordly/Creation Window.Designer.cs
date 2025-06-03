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
            advancedTextBox1 = new AdvancedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            roundedPanel1 = new RoundedPanel();
            roundedPanel4 = new RoundedPanel();
            meaningTB = new AdvancedTextBox();
            roundedPanel2 = new RoundedPanel();
            termTB = new AdvancedTextBox();
            label4 = new Label();
            roundedPanel1.SuspendLayout();
            roundedPanel4.SuspendLayout();
            roundedPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // advancedTextBox1
            // 
            advancedTextBox1.AutomaticResize = false;
            advancedTextBox1.BorderColor = Color.Empty;
            advancedTextBox1.BorderStyle = BorderStyle.FixedSingle;
            advancedTextBox1.Font = new Font("Segoe UI", 25F);
            advancedTextBox1.Location = new Point(459, 77);
            advancedTextBox1.MaxLineCount = 10;
            advancedTextBox1.Name = "advancedTextBox1";
            advancedTextBox1.PlaceholderText = "Type here";
            advancedTextBox1.Size = new Size(284, 52);
            advancedTextBox1.TabIndex = 0;
            advancedTextBox1.Text = "gfhdf";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(96, 72);
            label1.Name = "label1";
            label1.Size = new Size(315, 54);
            label1.TabIndex = 1;
            label1.Text = "Word List Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 25F);
            label2.Location = new Point(96, 144);
            label2.Name = "label2";
            label2.Size = new Size(256, 46);
            label2.TabIndex = 2;
            label2.Text = "Term Language:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 25F);
            label3.Location = new Point(96, 212);
            label3.Name = "label3";
            label3.Size = new Size(314, 46);
            label3.TabIndex = 3;
            label3.Text = "Meaning Language:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bulgarian", "Deutsch", "English", "Español" });
            comboBox1.Location = new Point(600, 165);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(143, 23);
            comboBox1.TabIndex = 4;
            comboBox1.Text = "Select Here:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Bulgarian", "Deutsch", "English", "Español" });
            comboBox2.Location = new Point(600, 233);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(143, 23);
            comboBox2.TabIndex = 5;
            comboBox2.Text = "Select Here:";
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = SystemColors.Highlight;
            roundedPanel1.BorderColor = Color.Black;
            roundedPanel1.BorderThickness = 0F;
            roundedPanel1.Controls.Add(roundedPanel4);
            roundedPanel1.Controls.Add(roundedPanel2);
            roundedPanel1.CornerRadius = 15;
            roundedPanel1.Location = new Point(100, 450);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(850, 110);
            roundedPanel1.TabIndex = 6;
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.RosyBrown;
            roundedPanel4.BorderColor = Color.Black;
            roundedPanel4.BorderThickness = 0F;
            roundedPanel4.Controls.Add(meaningTB);
            roundedPanel4.CornerRadius = 15;
            roundedPanel4.Location = new Point(440, 20);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(380, 70);
            roundedPanel4.TabIndex = 2;
            // 
            // meaningTB
            // 
            meaningTB.AutomaticResize = true;
            meaningTB.BackColor = Color.RosyBrown;
            meaningTB.BorderColor = Color.Empty;
            meaningTB.BorderStyle = BorderStyle.None;
            meaningTB.Font = new Font("Segoe UI", 15F);
            meaningTB.Location = new Point(20, 20);
            meaningTB.MaxLineCount = 10;
            meaningTB.Multiline = true;
            meaningTB.Name = "meaningTB";
            meaningTB.Size = new Size(340, 29);
            meaningTB.TabIndex = 1;
            meaningTB.LineCountChanged += meaningTB_LineCountChanged;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.RosyBrown;
            roundedPanel2.BorderColor = Color.Black;
            roundedPanel2.BorderThickness = 0F;
            roundedPanel2.Controls.Add(termTB);
            roundedPanel2.CornerRadius = 15;
            roundedPanel2.Location = new Point(30, 0);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(380, 110);
            roundedPanel2.TabIndex = 0;
            // 
            // termTB
            // 
            termTB.AutomaticResize = true;
            termTB.BackColor = Color.IndianRed;
            termTB.BorderColor = Color.Empty;
            termTB.BorderStyle = BorderStyle.None;
            termTB.Font = new Font("Segoe UI", 15F);
            termTB.Location = new Point(27, 20);
            termTB.MaxLineCount = 3;
            termTB.Multiline = true;
            termTB.Name = "termTB";
            termTB.Size = new Size(340, 29);
            termTB.TabIndex = 0;
            termTB.LineCountChanged += termTB_LineCountChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 35F);
            label4.Location = new Point(342, 345);
            label4.Name = "label4";
            label4.Size = new Size(52, 62);
            label4.TabIndex = 7;
            label4.Text = "0";
            // 
            // Creation_Window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Green;
            ClientSize = new Size(1050, 650);
            Controls.Add(label4);
            Controls.Add(roundedPanel1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(advancedTextBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Creation_Window";
            Text = "Creation_Window";
            roundedPanel1.ResumeLayout(false);
            roundedPanel4.ResumeLayout(false);
            roundedPanel4.PerformLayout();
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AdvancedTextBox advancedTextBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private RoundedPanel roundedPanel1;
        private RoundedPanel roundedPanel4;
        private RoundedPanel roundedPanel2;
        private AdvancedTextBox termTB;
        private Label label4;
        private AdvancedTextBox meaningTB;
    }
}