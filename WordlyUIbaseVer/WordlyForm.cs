using System.Diagnostics;
using System.DirectoryServices;

namespace WordlyUIbaseVer
{
    public partial class WordlyForm : Form
    {
        private static StackFrame stackFrame = new StackTrace(new StackFrame(true)).GetFrame(0);
        public static string projectFolderDir = Path.GetDirectoryName(stackFrame.GetFileName());
        private string imagesFolderDir = projectFolderDir + @"\Images\";

        private Home_Window     homeWindow;
        private ChooseListForm  listChoiceWindow;
        private Add_Window      listCreationWindow;
        private Settings_Window settingsWindow;

        public static int stepsToUndo = 0;

        public WordlyForm()
        {
            InitializeComponent();

            homeWindow = (Home_Window)AddFormFunctions(new Home_Window(), true);
            contentPnl.Controls.Add(homeWindow);

            listChoiceWindow = (ChooseListForm)AddFormFunctions(new ChooseListForm());
            contentPnl.Controls.Add(listChoiceWindow);
            listCreationWindow = (Add_Window)AddFormFunctions(new Add_Window());
            contentPnl.Controls.Add(listCreationWindow);
            settingsWindow = (Settings_Window)AddFormFunctions(new Settings_Window());
            contentPnl.Controls.Add(settingsWindow);
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            ResetBtnColors();
            menuHomeBtn.BackColor = Color.FromArgb(192, 192, 0);
            menuIndicatorPnl.Location = new Point(menuInnerPnl.Location.X, menuHomeBtn.Location.Y + titlePnl.Height + 10);

            optBarImage.Image = Image.FromFile(imagesFolderDir + "house.png");

            ResetContentVisibility();
            homeWindow.Visible = true;
        }
        private void startBtn_Click(object sender, EventArgs e)
        {
            ResetBtnColors();
            menuStartBtn.BackColor = Color.FromArgb(192, 192, 0);
            menuIndicatorPnl.Location = new Point(menuInnerPnl.Location.X, menuStartBtn.Location.Y + titlePnl.Height + 10);
            
            optBarImage.Image = Image.FromFile(imagesFolderDir + "language sign.png");

            ResetContentVisibility();
            listChoiceWindow.Visible = true;
        }
        private void createBtn_Click(object sender, EventArgs e)
        {
            ResetBtnColors();
            menuCreateBtn.BackColor = Color.FromArgb(192, 192, 0);
            menuIndicatorPnl.Location = new Point(menuInnerPnl.Location.X, menuCreateBtn.Location.Y + titlePnl.Height + 10);

            optBarImage.Image = Image.FromFile(imagesFolderDir + "plus icon.png");

            ResetContentVisibility();
            listCreationWindow.Visible = true;
        }
        private void settingsBtn_Click(object sender, EventArgs e)
        {
            ResetBtnColors();
            menuSettingsBtn.BackColor = Color.FromArgb(192, 192, 0);
            menuIndicatorPnl.Location = new Point(menuInnerPnl.Location.X, menuSettingsBtn.Location.Y + titlePnl.Height + 10);
            
            optBarImage.Image = Image.FromFile(imagesFolderDir + "Settings-icon.png");

            ResetContentVisibility();
            settingsWindow.Visible = true;
        }
        private void quitBtn_Click(object sender, EventArgs e)
        {
            //add message box
            Environment.Exit(0);
        }

        private void ResetBtnColors()
        {
            menuHomeBtn.BackColor = Color.FromArgb(255, 255, 128);
            menuStartBtn.BackColor = Color.FromArgb(255, 255, 128);
            menuCreateBtn.BackColor = Color.FromArgb(255, 255, 128);
            menuSettingsBtn.BackColor = Color.FromArgb(255, 255, 128);
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

            if (stepsToUndo <= 0) {} //nothing to undo

            else if (menuHomeBtn.BackColor == Color.FromArgb(192, 192, 0))
            {
                //perform undo operation for home window
            }
            else if (menuStartBtn.BackColor == Color.FromArgb(192, 192, 0))
            {
                if(stepsToUndo == 1)
                {
                    listChoiceWindow.Controls.Clear();
                    listChoiceWindow.InitializeComponent();
                    listChoiceWindow.InitializeFunctions();
                }

                else if(stepsToUndo == 2)
                {
                    listChoiceWindow.quizWindow.Reset();
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

        

    }
}
