using RoundedComponents;

namespace Wordly_alpha
{
    partial class ExamMode
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
            viewTablePnl = new RoundedPanel();
            tableContentPnl = new Panel();
            indicationPnl = new Panel();
            indicatorLang2BLbl = new Label();
            indicatorLang2ALbl = new Label();
            indicatorLang1BLbl = new Label();
            indicatorLang1ALbl = new Label();
            submitBtn = new RoundedButton();
            textResultLbl = new Label();
            resultLbl = new Label();
            selectTilesBtn = new RoundedButton();
            selectTableBtn = new RoundedButton();
            viewTilesPnl = new RoundedPanel();
            viewTablePnl.SuspendLayout();
            indicationPnl.SuspendLayout();
            SuspendLayout();
            // 
            // viewTablePnl
            // 
            viewTablePnl.BackColor = Color.FromArgb(55, 55, 55);
            viewTablePnl.Controls.Add(tableContentPnl);
            viewTablePnl.Controls.Add(indicationPnl);
            viewTablePnl.Location = new Point(75, 75);
            viewTablePnl.Name = "viewTablePnl";
            viewTablePnl.Size = new Size(900, 550);
            viewTablePnl.TabIndex = 0;
            // 
            // tableContentPnl
            // 
            tableContentPnl.BackColor = Color.FromArgb(55, 55, 55);
            tableContentPnl.Dock = DockStyle.Fill;
            tableContentPnl.Location = new Point(0, 50);
            tableContentPnl.Name = "tableContentPnl";
            tableContentPnl.Size = new Size(900, 500);
            tableContentPnl.TabIndex = 21;
            // 
            // indicationPnl
            // 
            indicationPnl.BackColor = Color.FromArgb(70, 70, 70);
            indicationPnl.Controls.Add(indicatorLang2BLbl);
            indicationPnl.Controls.Add(indicatorLang2ALbl);
            indicationPnl.Controls.Add(indicatorLang1BLbl);
            indicationPnl.Controls.Add(indicatorLang1ALbl);
            indicationPnl.Dock = DockStyle.Top;
            indicationPnl.Location = new Point(0, 0);
            indicationPnl.Name = "indicationPnl";
            indicationPnl.Size = new Size(900, 50);
            indicationPnl.TabIndex = 20;
            // 
            // indicatorLang2BLbl
            // 
            indicatorLang2BLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            indicatorLang2BLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            indicatorLang2BLbl.ForeColor = Color.FromArgb(210, 220, 220);
            indicatorLang2BLbl.Location = new Point(675, 0);
            indicatorLang2BLbl.Name = "indicatorLang2BLbl";
            indicatorLang2BLbl.Size = new Size(225, 50);
            indicatorLang2BLbl.TabIndex = 3;
            indicatorLang2BLbl.Text = "Term";
            indicatorLang2BLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // indicatorLang2ALbl
            // 
            indicatorLang2ALbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            indicatorLang2ALbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            indicatorLang2ALbl.ForeColor = Color.FromArgb(210, 220, 220);
            indicatorLang2ALbl.Location = new Point(450, 0);
            indicatorLang2ALbl.Name = "indicatorLang2ALbl";
            indicatorLang2ALbl.Size = new Size(225, 50);
            indicatorLang2ALbl.TabIndex = 2;
            indicatorLang2ALbl.Text = "Meaning";
            indicatorLang2ALbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // indicatorLang1BLbl
            // 
            indicatorLang1BLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            indicatorLang1BLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            indicatorLang1BLbl.ForeColor = Color.FromArgb(210, 220, 220);
            indicatorLang1BLbl.Location = new Point(225, 0);
            indicatorLang1BLbl.Name = "indicatorLang1BLbl";
            indicatorLang1BLbl.Size = new Size(225, 50);
            indicatorLang1BLbl.TabIndex = 1;
            indicatorLang1BLbl.Text = "Term";
            indicatorLang1BLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // indicatorLang1ALbl
            // 
            indicatorLang1ALbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            indicatorLang1ALbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            indicatorLang1ALbl.ForeColor = Color.FromArgb(210, 220, 220);
            indicatorLang1ALbl.Location = new Point(0, 0);
            indicatorLang1ALbl.Name = "indicatorLang1ALbl";
            indicatorLang1ALbl.Size = new Size(225, 50);
            indicatorLang1ALbl.TabIndex = 0;
            indicatorLang1ALbl.Text = "Meaning";
            indicatorLang1ALbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // submitBtn
            // 
            submitBtn.BackColor = Color.FromArgb(210, 230, 230);
            submitBtn.FlatAppearance.BorderColor = Color.FromArgb(210, 230, 230);
            submitBtn.FlatStyle = FlatStyle.Flat;
            submitBtn.Font = new Font("Calibri", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submitBtn.ForeColor = Color.FromArgb(50, 50, 50);
            submitBtn.Location = new Point(425, 13);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(200, 50);
            submitBtn.TabIndex = 1;
            submitBtn.TabStop = false;
            submitBtn.Text = "Submit";
            submitBtn.UseMnemonic = false;
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += SubmitBtn_Click;
            // 
            // textResultLbl
            // 
            textResultLbl.CausesValidation = false;
            textResultLbl.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textResultLbl.ForeColor = Color.FromArgb(240, 250, 250);
            textResultLbl.Location = new Point(675, 8);
            textResultLbl.Name = "textResultLbl";
            textResultLbl.Size = new Size(150, 30);
            textResultLbl.TabIndex = 2;
            textResultLbl.Text = " Result:";
            textResultLbl.TextAlign = ContentAlignment.MiddleCenter;
            textResultLbl.Visible = false;
            // 
            // resultLbl
            // 
            resultLbl.CausesValidation = false;
            resultLbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultLbl.ForeColor = Color.FromArgb(240, 250, 250);
            resultLbl.Location = new Point(675, 35);
            resultLbl.Name = "resultLbl";
            resultLbl.Size = new Size(150, 30);
            resultLbl.TabIndex = 3;
            resultLbl.Text = "100% 50/50";
            resultLbl.TextAlign = ContentAlignment.MiddleCenter;
            resultLbl.Visible = false;
            // 
            // selectTilesBtn
            // 
            selectTilesBtn.BackColor = Color.Silver;
            selectTilesBtn.FlatAppearance.BorderColor = Color.Silver;
            selectTilesBtn.FlatAppearance.BorderSize = 0;
            selectTilesBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 95, 95);
            selectTilesBtn.FlatStyle = FlatStyle.Flat;
            selectTilesBtn.Location = new Point(10, 140);
            selectTilesBtn.Name = "selectTilesBtn";
            selectTilesBtn.Size = new Size(56, 56);
            selectTilesBtn.TabIndex = 4;
            selectTilesBtn.TabStop = false;
            selectTilesBtn.UseMnemonic = false;
            selectTilesBtn.UseVisualStyleBackColor = false;
            selectTilesBtn.Click += selectTilesButton_Click;
            // 
            // selectTableBtn
            // 
            selectTableBtn.BackColor = Color.LightGray;
            selectTableBtn.FlatAppearance.BorderColor = Color.LightGray;
            selectTableBtn.FlatAppearance.BorderSize = 0;
            selectTableBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 95, 95);
            selectTableBtn.FlatStyle = FlatStyle.Flat;
            selectTableBtn.Location = new Point(10, 75);
            selectTableBtn.Name = "selectTableBtn";
            selectTableBtn.Size = new Size(56, 56);
            selectTableBtn.TabIndex = 5;
            selectTableBtn.TabStop = false;
            selectTableBtn.UseMnemonic = false;
            selectTableBtn.UseVisualStyleBackColor = false;
            selectTableBtn.Click += selectTableBtn_Click;
            // 
            // viewTilesPnl
            // 
            viewTilesPnl.AutoScroll = true;
            viewTilesPnl.BackColor = Color.FromArgb(80, 80, 80);
            viewTilesPnl.Location = new Point(75, 75);
            viewTilesPnl.Name = "viewTilesPnl";
            viewTilesPnl.Size = new Size(917, 550);
            viewTilesPnl.TabIndex = 0;
            viewTilesPnl.Visible = false;
            // 
            // ExamMode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(60, 60, 60);
            ClientSize = new Size(1050, 650);
            Controls.Add(viewTilesPnl);
            Controls.Add(selectTableBtn);
            Controls.Add(selectTilesBtn);
            Controls.Add(resultLbl);
            Controls.Add(textResultLbl);
            Controls.Add(submitBtn);
            Controls.Add(viewTablePnl);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "ExamMode";
            Text = "ExamMode";
            KeyDown += ExamMode_KeyDown;
            KeyUp += ExamMode_KeyUp;
            viewTablePnl.ResumeLayout(false);
            indicationPnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private RoundedPanel viewTablePnl;
        private Panel indicationPnl;
        private Label indicatorLang2BLbl;
        private Label indicatorLang2ALbl;
        private Label indicatorLang1BLbl;
        private Label indicatorLang1ALbl;
        private RoundedButton submitBtn;
        private Label textResultLbl;
        private Label resultLbl;
        private Panel tableContentPnl;
        private Panel panel1;
        private RoundedButton selectTilesBtn;
        private RoundedButton selectTableBtn;
        private RoundedPanel viewTilesPnl;
    }
}