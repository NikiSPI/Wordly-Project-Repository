using System.ComponentModel.Design;
using System.Diagnostics;
using System.DirectoryServices;
using System.Runtime.InteropServices;

namespace Wordly_alpha
{
    public partial class WordlyForm : Form
    {
        private static StackFrame stackFrame = new StackTrace(new StackFrame(true)).GetFrame(0);
        public static string projectFolderDir = Path.GetDirectoryName(stackFrame.GetFileName());
        private string imagesFolderDir = projectFolderDir + @"\Images\";

        private int lma = 15; //LMA = lighten menubutton amount; the amount of darkening that the selected button gets

        private Home_Window homeWindow;
        private ChooseListForm listChoiceWindow;
        private Add_Window listCreationWindow;
        private Settings_Window settingsWindow;

        public WordlyForm()
        {
            this.
            InitializeComponent();

            homeWindow = (Home_Window)AddFormFunctions(new Home_Window(), true);
            contentPnl.Controls.Add(homeWindow);

            listChoiceWindow = (ChooseListForm)AddFormFunctions(new ChooseListForm());
            contentPnl.Controls.Add(listChoiceWindow);
            listCreationWindow = (Add_Window)AddFormFunctions(new Add_Window());
            contentPnl.Controls.Add(listCreationWindow);
            settingsWindow = (Settings_Window)AddFormFunctions(new Settings_Window());
            contentPnl.Controls.Add(settingsWindow);

            menuHomeBtn.BackColor = Color.FromArgb(menuPnl.BackColor.R + lma, menuPnl.BackColor.G + lma, menuPnl.BackColor.B + lma);
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            ResetBtnColors();
            menuHomeBtn.BackColor = Color.FromArgb(menuPnl.BackColor.R + lma, menuPnl.BackColor.G + lma, menuPnl.BackColor.B + lma);
            menuIndicatorPnl.Location = new Point(0, menuHomeBtn.Location.Y);

            //optBarImage.Image = Image.FromFile(imagesFolderDir + "house.png");

            ResetContentVisibility();
            homeWindow.Visible = true;
        }
        private void startBtn_Click(object sender, EventArgs e)
        {
            ResetBtnColors();
            menuStartBtn.BackColor = Color.FromArgb(menuPnl.BackColor.R + lma, menuPnl.BackColor.G + lma, menuPnl.BackColor.B + lma);
            menuIndicatorPnl.Location = new Point(0, menuStartBtn.Location.Y);

            //optBarImage.Image = Image.FromFile(imagesFolderDir + "language sign.png");

            ResetContentVisibility();
            listChoiceWindow.Visible = true;
        }
        private void createBtn_Click(object sender, EventArgs e)
        {
            ResetBtnColors();
            menuCreateBtn.BackColor = Color.FromArgb(menuPnl.BackColor.R + lma, menuPnl.BackColor.G + lma, menuPnl.BackColor.B + lma);
            menuIndicatorPnl.Location = new Point(0, menuCreateBtn.Location.Y);

            //optBarImage.Image = Image.FromFile(imagesFolderDir + "plus icon.png");

            ResetContentVisibility();
            listCreationWindow.Visible = true;
        }
        private void settingsBtn_Click(object sender, EventArgs e)
        {
            ResetBtnColors();
            menuSettingsBtn.BackColor = Color.FromArgb(menuPnl.BackColor.R + lma, menuPnl.BackColor.G + lma, menuPnl.BackColor.B + lma);
            menuIndicatorPnl.Location = new Point(0, menuSettingsBtn.Location.Y);

            //optBarImage.Image = Image.FromFile(imagesFolderDir + "Settings-icon.png");

            ResetContentVisibility();
            settingsWindow.Visible = true;
        }
        private void quitBtn_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure you want to exit?", "", MessageBoxButtons.YesNo)) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void ResetBtnColors()
        {
            menuHomeBtn.BackColor = menuPnl.BackColor;
            menuStartBtn.BackColor = menuPnl.BackColor;
            menuCreateBtn.BackColor = menuPnl.BackColor;
            menuSettingsBtn.BackColor = menuPnl.BackColor;
        }
        private void ResetContentVisibility()
        {
            homeWindow.Visible = false;
            listChoiceWindow.Visible = false;
            listCreationWindow.Visible = false;
            settingsWindow.Visible = false;
        }
        public static Form AddFormFunctions(Form form, bool isVisible = false)
        {
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.TopMost = true;
            form.Visible = isVisible;
            form.Show();

            return form;
        }


        private void backBtn_Click(object sender, EventArgs e)
        {
            if (homeWindow.Visible)
            {
                //perform undo operation for home window
            }
            else if (listChoiceWindow.Visible)
            {
                listChoiceWindow.UndoFunction();
            }
            else if (listCreationWindow.Visible)
            {
                //perform undo operation for create list window
            }
            else if (settingsWindow.Visible)
            {
                //perform undo operation for settings window
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.FromArgb(1,1,1), ButtonBorderStyle.Solid);
        }
    }







    /*
    // PInvoke declaration
    [DllImport("User32.dll", EntryPoint = "GetDCEx")]
    internal static extern IntPtr GetDCEx(IntPtr hWnd, IntPtr hRgn, int flags);

    // Event Override
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        IntPtr hWnd = this.Handle;
        IntPtr hRgn = IntPtr.Zero;
        IntPtr hdc = this.GetDCEx(hWnd, hRgn, 1027);

        using (Graphics grfx = Graphics.FromHdc(hdc))
        {
            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height -
            1);
            Pen pen = new Pen(Color.Red, 1);
            grfx.DrawRectangle(pen, rect);
        }
    }
    */
}
