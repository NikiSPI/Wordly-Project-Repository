namespace Wordly_alpha
{
    partial class Add_Window
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
            addLbl = new Label();
            SuspendLayout();
            // 
            // addLbl
            // 
            addLbl.AutoSize = true;
            addLbl.BackColor = Color.Transparent;
            addLbl.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addLbl.Location = new Point(197, 200);
            addLbl.Name = "addLbl";
            addLbl.Size = new Size(176, 86);
            addLbl.TabIndex = 2;
            addLbl.Text = "ADD";
            // 
            // Add_Window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SpringGreen;
            ClientSize = new Size(584, 486);
            Controls.Add(addLbl);
            Name = "Add_Window";
            RightToLeftLayout = true;
            Text = "Add_Window";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label addLbl;
    }
}