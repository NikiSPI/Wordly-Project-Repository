namespace Wordly
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
        public void InitializeComponent()
        {
            contentPnl = new Experimental.CustomScrollPanel();
            SuspendLayout();
            // 
            // contentPnl
            // 
            contentPnl.AutoScroll = true;
            contentPnl.BackColor = Color.FromArgb(40, 40, 40);
            contentPnl.Location = new Point(125, 50);
            contentPnl.Name = "contentPnl";
            contentPnl.PanelRadius = 10;
            contentPnl.Size = new Size(817, 550);
            contentPnl.TabIndex = 6;
            contentPnl.ThumbColor = Color.FromArgb(210, 220, 220);
            contentPnl.ThumbColorChange_Hold = 30;
            contentPnl.ThumbColorChange_Hover = 20;
            contentPnl.ThumbHoldEnlargement = new Size(1, 1);
            contentPnl.ThumbMargin = new Size(4, 8);
            contentPnl.ThumbMinHeight = 50;
            contentPnl.ThumbRadius = 3;
            contentPnl.ThumbWidth = 7;
            // 
            // ChooseListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            ClientSize = new Size(1050, 650);
            Controls.Add(contentPnl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChooseListForm";
            Text = "ChooseListForm";
            ResumeLayout(false);
        }

        #endregion

        private Experimental.CustomScrollPanel contentPnl;
    }
}