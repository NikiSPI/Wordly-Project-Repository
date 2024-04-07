namespace Wordly_alpha

{
    partial class Settings_Window
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
            setLbl = new Label();
            SuspendLayout();
            // 
            // setLbl
            // 
            setLbl.AutoSize = true;
            setLbl.BackColor = Color.Transparent;
            setLbl.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            setLbl.Location = new Point(130, 208);
            setLbl.Name = "setLbl";
            setLbl.Size = new Size(338, 86);
            setLbl.TabIndex = 2;
            setLbl.Text = "SETTINGS";
            // 
            // Settings_Window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            ClientSize = new Size(584, 486);
            Controls.Add(setLbl);
            Name = "Settings_Window";
            Text = "Settings_Window";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label setLbl;
    }
}