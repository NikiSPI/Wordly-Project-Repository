using System.Diagnostics;

namespace WordlyUIbaseVer
{
    public partial class WordlyForm : Form
    {
        private static StackFrame stackFrame = new StackTrace(new StackFrame(true)).GetFrame(0);
        public static string projectFolderDir = Path.GetDirectoryName(stackFrame.GetFileName());
        private string imagesFolderDir = projectFolderDir + @"\Images\";

        private Form ContentWindow;

        public static int stepsToUndo = 0;

        public WordlyForm()
        {
            InitializeComponent();

            SetContentPnl(new Main_Window());
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            ResetBtnClrs();
            menuHomeBtn.BackColor = Color.FromArgb(192, 192, 0);
            menuIndicatorPnl.Location = new Point(menuInnerPnl.Location.X, menuHomeBtn.Location.Y + titlePnl.Height + 10);

            optBarImage.Image = Image.FromFile(imagesFolderDir + "house.png");

            SetContentPnl(new Main_Window());
        }
        private void startBtn_Click(object sender, EventArgs e)
        {
            ResetBtnClrs();
            menuStartBtn.BackColor = Color.FromArgb(192, 192, 0);
            menuIndicatorPnl.Location = new Point(menuInnerPnl.Location.X, menuStartBtn.Location.Y + titlePnl.Height + 10);
            
            optBarImage.Image = Image.FromFile(imagesFolderDir + "language sign.png");

            SetContentPnl(new ChooseListForm());
        }
        private void createBtn_Click(object sender, EventArgs e)
        {
            ResetBtnClrs();
            menuCreateBtn.BackColor = Color.FromArgb(192, 192, 0);
            menuIndicatorPnl.Location = new Point(menuInnerPnl.Location.X, menuCreateBtn.Location.Y + titlePnl.Height + 10);

            optBarImage.Image = Image.FromFile(imagesFolderDir + "plus icon.png");

            SetContentPnl(new Add_Window());
        }
        private void settingsBtn_Click(object sender, EventArgs e)
        {
            ResetBtnClrs();
            menuSettingsBtn.BackColor = Color.FromArgb(192, 192, 0);
            menuIndicatorPnl.Location = new Point(menuInnerPnl.Location.X, menuSettingsBtn.Location.Y + titlePnl.Height + 10);
            
            optBarImage.Image = Image.FromFile(imagesFolderDir + "Settings-icon.png");

            SetContentPnl(new Settings_Window());
        }
        private void quitBtn_Click(object sender, EventArgs e)
        {
            //add message box
            Environment.Exit(0);
        }


        private void backBtn_Click(object sender, EventArgs e)
        {

            if (stepsToUndo <= 0) {} //nothing to undo

            else if (menuHomeBtn.BackColor == Color.FromArgb(192, 192, 0))
            {
                //perform undo operation for home window
            }
            else if (menuStartBtn.BackColor == Color.FromArgb(192, 192, 0))
            {
                if(stepsToUndo == 1)
                {
                    SetContentPnl(new ChooseListForm());                    
                }
                
                else if(stepsToUndo == 2)
                {
                    
                }
            }
            else if (menuCreateBtn.BackColor == Color.FromArgb(192, 192, 0))
            {
                //perform undo operation for create list window
            }
            else if (menuSettingsBtn.BackColor == Color.FromArgb(192, 192, 0))
            {
                //perform undo operation for settings window
            }

            stepsToUndo--;
        }

        private void SetContentPnl(Form content)
        {
            stepsToUndo = 0;

            ContentWindow = content;
            ContentWindow.FormBorderStyle = FormBorderStyle.None;
            ContentWindow.Dock = DockStyle.Fill;
            ContentWindow.TopLevel = false;
            ContentWindow.TopMost = true;

            contentPnl.Controls.Clear();
            contentPnl.Controls.Add(ContentWindow);
            ContentWindow.Show();
        }

        private void ResetBtnClrs()
        {
            menuHomeBtn.BackColor = Color.FromArgb(255, 255, 128);
            menuStartBtn.BackColor = Color.FromArgb(255, 255, 128);
            menuCreateBtn.BackColor = Color.FromArgb(255, 255, 128);
            menuSettingsBtn.BackColor = Color.FromArgb(255, 255, 128);
        }

    }
}
