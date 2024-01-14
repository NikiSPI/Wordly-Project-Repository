namespace WordlyUIbaseVer
{
    partial class Main_Window
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
            homeLbl = new Label();
            SuspendLayout();
            // 
            // homeLbl
            // 
            homeLbl.AutoSize = true;
            homeLbl.BackColor = Color.Transparent;
            homeLbl.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            homeLbl.Location = new Point(200, 217);
            homeLbl.Name = "homeLbl";
            homeLbl.Size = new Size(230, 86);
            homeLbl.TabIndex = 0;
            homeLbl.Text = "HOME";
            // 
            // Main_Window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(584, 486);
            Controls.Add(homeLbl);
            Name = "Main_Window";
            Text = "Main_Window";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label homeLbl;
    }
}