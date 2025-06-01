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
            richTextBox1 = new RichTextBox();
            roundedPanel2 = new RoundedPanel();
            termTB = new AdvancedTextBox();
            label4 = new Label();
            roundedPanel1.SuspendLayout();
            roundedPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // advancedTextBox1
            // 
            advancedTextBox1.AutomaticResize = false;
            advancedTextBox1.BorderColor = Color.Empty;
            advancedTextBox1.BorderStyle = BorderStyle.FixedSingle;
            advancedTextBox1.Font = new Font("Segoe UI", 25F);
            advancedTextBox1.Location = new Point(459, 77);
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
            roundedPanel1.Controls.Add(termTB);
            roundedPanel1.Controls.Add(roundedPanel4);
            roundedPanel1.Controls.Add(roundedPanel2);
            roundedPanel1.CornerRadius = 15;
            roundedPanel1.Location = new Point(114, 450);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(832, 775);
            roundedPanel1.TabIndex = 6;
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.Salmon;
            roundedPanel4.BorderColor = Color.Black;
            roundedPanel4.BorderThickness = 0F;
            roundedPanel4.Controls.Add(richTextBox1);
            roundedPanel4.CornerRadius = 5;
            roundedPanel4.Location = new Point(445, 40);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(351, 66);
            roundedPanel4.TabIndex = 2;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(25, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox1.Size = new Size(310, 60);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.SandyBrown;
            roundedPanel2.BorderColor = Color.Black;
            roundedPanel2.BorderThickness = 0F;
            roundedPanel2.CornerRadius = 5;
            roundedPanel2.Location = new Point(47, 40);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(355, 70);
            roundedPanel2.TabIndex = 0;
            // 
            // termTB
            // 
            termTB.AutomaticResize = true;
            termTB.BackColor = Color.LightCoral;
            termTB.BorderColor = Color.Empty;
            termTB.BorderStyle = BorderStyle.None;
            termTB.Font = new Font("Segoe UI", 15F);
            termTB.Location = new Point(47, 61);
            termTB.Multiline = true;
            termTB.Name = "termTB";
            termTB.Size = new Size(349, 29);
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
            roundedPanel1.PerformLayout();
            roundedPanel4.ResumeLayout(false);
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
        private RichTextBox richTextBox1;
        private Label label4;
    }
}