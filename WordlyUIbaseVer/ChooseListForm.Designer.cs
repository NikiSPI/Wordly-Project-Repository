namespace WordlyUIbaseVer
{
    partial class ChooseListForm
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
            contentPnl = new Panel();
            wordList5Btn = new Button();
            wordList4Btn = new Button();
            wordList3Btn = new Button();
            wordList1Btn = new Button();
            wordList2Btn = new Button();
            contentPnl.SuspendLayout();
            SuspendLayout();
            // 
            // contentPnl
            // 
            contentPnl.AutoScroll = true;
            contentPnl.BackColor = SystemColors.ControlLight;
            contentPnl.Controls.Add(wordList5Btn);
            contentPnl.Controls.Add(wordList4Btn);
            contentPnl.Controls.Add(wordList3Btn);
            contentPnl.Controls.Add(wordList1Btn);
            contentPnl.Controls.Add(wordList2Btn);
            contentPnl.Dock = DockStyle.Fill;
            contentPnl.Location = new Point(0, 0);
            contentPnl.Name = "contentPnl";
            contentPnl.Size = new Size(800, 600);
            contentPnl.TabIndex = 0;
            // 
            // wordList5Btn
            // 
            wordList5Btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            wordList5Btn.BackColor = Color.Wheat;
            wordList5Btn.FlatAppearance.BorderSize = 0;
            wordList5Btn.FlatStyle = FlatStyle.Flat;
            wordList5Btn.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            wordList5Btn.Location = new Point(10, 410);
            wordList5Btn.Name = "wordList5Btn";
            wordList5Btn.Size = new Size(780, 90);
            wordList5Btn.TabIndex = 8;
            wordList5Btn.Text = "Word List 5";
            wordList5Btn.UseVisualStyleBackColor = false;
            // 
            // wordList4Btn
            // 
            wordList4Btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            wordList4Btn.BackColor = Color.Wheat;
            wordList4Btn.FlatAppearance.BorderSize = 0;
            wordList4Btn.FlatStyle = FlatStyle.Flat;
            wordList4Btn.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            wordList4Btn.Location = new Point(10, 310);
            wordList4Btn.Name = "wordList4Btn";
            wordList4Btn.Size = new Size(780, 90);
            wordList4Btn.TabIndex = 7;
            wordList4Btn.Text = "Word List 4";
            wordList4Btn.UseVisualStyleBackColor = false;
            // 
            // wordList3Btn
            // 
            wordList3Btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            wordList3Btn.BackColor = Color.Wheat;
            wordList3Btn.FlatAppearance.BorderSize = 0;
            wordList3Btn.FlatStyle = FlatStyle.Flat;
            wordList3Btn.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            wordList3Btn.Location = new Point(10, 210);
            wordList3Btn.Name = "wordList3Btn";
            wordList3Btn.Size = new Size(780, 90);
            wordList3Btn.TabIndex = 6;
            wordList3Btn.Text = "Word List 3";
            wordList3Btn.UseVisualStyleBackColor = false;
            // 
            // wordList1Btn
            // 
            wordList1Btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            wordList1Btn.BackColor = Color.Wheat;
            wordList1Btn.FlatAppearance.BorderSize = 0;
            wordList1Btn.FlatStyle = FlatStyle.Flat;
            wordList1Btn.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            wordList1Btn.Location = new Point(10, 10);
            wordList1Btn.Name = "wordList1Btn";
            wordList1Btn.Size = new Size(780, 90);
            wordList1Btn.TabIndex = 5;
            wordList1Btn.Text = "Word List 1";
            wordList1Btn.UseVisualStyleBackColor = false;
            wordList1Btn.Click += wordList1Btn_Click;
            // 
            // wordList2Btn
            // 
            wordList2Btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            wordList2Btn.BackColor = Color.Wheat;
            wordList2Btn.FlatAppearance.BorderSize = 0;
            wordList2Btn.FlatStyle = FlatStyle.Flat;
            wordList2Btn.Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            wordList2Btn.Location = new Point(10, 110);
            wordList2Btn.Name = "wordList2Btn";
            wordList2Btn.Size = new Size(780, 90);
            wordList2Btn.TabIndex = 5;
            wordList2Btn.Text = "Word List 2";
            wordList2Btn.UseVisualStyleBackColor = false;
            // 
            // ChooseListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(contentPnl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChooseListForm";
            Text = "ChooseListForm";
            contentPnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel contentPnl;
        private Button wordList5Btn;
        private Button wordList4Btn;
        private Button wordList3Btn;
        private Button wordList1Btn;
        private Button wordList2Btn;
    }
}