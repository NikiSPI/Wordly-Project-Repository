namespace Experimental
{
    partial class CustomScrollPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            thumb = new RoundedPanel();
            contentPnl = new ContentPanel();
            SuspendLayout();
            // 
            // thumb
            // 
            thumb.Anchor = AnchorStyles.Right;
            thumb.BackColor = Color.Gray;
            thumb.Name = "thumb";
            thumb.Size = new Size(8, 47);
            thumb.TabIndex = 0;
            thumb.MouseDown += Thumb_MouseDown;
            thumb.MouseEnter += Thumb_MouseEnter;
            thumb.MouseLeave += Thumb_MouseLeave;
            thumb.MouseUp += Thumb_MouseUp;
            // 
            // contentPnl
            // 
            contentPnl.AutoScroll = true;
            contentPnl.BackColor = Color.Transparent;
            contentPnl.Dock = DockStyle.Fill;
            contentPnl.Name = "contentPnl";
            contentPnl.Size = new Size(315, 200);
            contentPnl.TabIndex = 0;
            contentPnl.ScrollOccurred += ScrollablePanel_ScrollOccurred;
            // 
            // CustomScrollPanel
            // 
            AutoScroll = true;
            BackColor = Color.LightGray;
            Controls.Add(thumb);
            Name = "ScrollablePanel";
            Size = new Size(315, 200);
            ControlAdded += CustomScrollPanel_ControlAdded;
            HandleCreated += LoadablePanel_HandleCreated;
            ResumeLayout(false);
        }

        #endregion

        private RoundedPanel thumb;
        private ContentPanel contentPnl;
    }

}