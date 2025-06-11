namespace Wordly
{
    public partial class WordlyForm : Form
    {
        private int lma = 20; //LMA = lighten menubutton amount; the amount of darkening that the selected button gets

        private Home_Window homeWindow;
        private ChooseListForm listChoiceWindow;
        private Creation_Window listCreationWindow;
        private Settings_Window settingsWindow;

        public WordlyForm()
        {
            InitializeComponent();

            homeWindow = (Home_Window)AddFormFunctions(new Home_Window(), true);
            contentPnl.Controls.Add(homeWindow);

            listChoiceWindow = (ChooseListForm)AddFormFunctions(new ChooseListForm());
            contentPnl.Controls.Add(listChoiceWindow);
            listCreationWindow = (Creation_Window)AddFormFunctions(new Creation_Window());
            contentPnl.Controls.Add(listCreationWindow);
            settingsWindow = (Settings_Window)AddFormFunctions(new Settings_Window());
            contentPnl.Controls.Add(settingsWindow);

            menuHomeBtn.BackColor = Color.FromArgb(menuPnl.BackColor.R + lma, menuPnl.BackColor.G + lma, menuPnl.BackColor.B + lma);
            menuHomeBtn.ForeColor = Color.FromArgb(menuPnl.ForeColor.R - lma, menuPnl.ForeColor.G - lma, menuPnl.ForeColor.B - lma);
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            UpdateMenuLayout(0);

            ResetContentVisibility();
            homeWindow.Visible = true;

        }
        private void startBtn_Click(object sender, EventArgs e)
        {
            UpdateMenuLayout(1);

            ResetContentVisibility();
            listChoiceWindow.Visible = true;

            listChoiceWindow.Reset();
        }
        private void createBtn_Click(object sender, EventArgs e)
        {
            UpdateMenuLayout(2);

            ResetContentVisibility();
            listCreationWindow.Visible = true;

        }
        private void settingsBtn_Click(object sender, EventArgs e)
        {
            UpdateMenuLayout(3);

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

        private void UpdateMenuLayout(int select)
        {
            menuHomeBtn.BackColor = menuPnl.BackColor;
            menuStartBtn.BackColor = menuPnl.BackColor;
            menuCreateBtn.BackColor = menuPnl.BackColor;
            menuSettingsBtn.BackColor = menuPnl.BackColor;

            menuHomeBtn.ForeColor = menuPnl.ForeColor;
            menuStartBtn.ForeColor = menuPnl.ForeColor;
            menuCreateBtn.ForeColor = menuPnl.ForeColor;
            menuSettingsBtn.ForeColor = menuPnl.ForeColor;

            switch (select)
            {
                case 0: //home

                    menuHomeBtn.BackColor = Color.FromArgb(menuPnl.BackColor.R + lma, menuPnl.BackColor.G + lma, menuPnl.BackColor.B + lma);
                    menuHomeBtn.ForeColor = Color.FromArgb(menuPnl.ForeColor.R - lma, menuPnl.ForeColor.G - lma, menuPnl.ForeColor.B - lma);
                    menuIndicatorPnl.Location = new Point(menuIndicatorPnl.Location.X, menuHomeBtn.Location.Y);

                    //optBarImage.Image = Image.FromFile(imagesFolderDir + "house.png");

                    break;

                case 1: //start quiz

                    menuStartBtn.BackColor = Color.FromArgb(menuPnl.BackColor.R + lma, menuPnl.BackColor.G + lma, menuPnl.BackColor.B + lma);
                    menuStartBtn.ForeColor = Color.FromArgb(menuPnl.ForeColor.R - lma, menuPnl.ForeColor.G - lma, menuPnl.ForeColor.B - lma);
                    menuIndicatorPnl.Location = new Point(menuIndicatorPnl.Location.X, menuStartBtn.Location.Y);

                    //optBarImage.Image = Image.FromFile(imagesFolderDir + "language sign.png");

                    break;

                case 2: //create quiz

                    menuCreateBtn.BackColor = Color.FromArgb(menuPnl.BackColor.R + lma, menuPnl.BackColor.G + lma, menuPnl.BackColor.B + lma);
                    menuCreateBtn.ForeColor = Color.FromArgb(menuPnl.ForeColor.R - lma, menuPnl.ForeColor.G - lma, menuPnl.ForeColor.B - lma);
                    menuIndicatorPnl.Location = new Point(menuIndicatorPnl.Location.X, menuCreateBtn.Location.Y);

                    //optBarImage.Image = Image.FromFile(imagesFolderDir + "plus icon.png");

                    break;

                case 3: //settings

                    menuSettingsBtn.BackColor = Color.FromArgb(menuPnl.BackColor.R + lma, menuPnl.BackColor.G + lma, menuPnl.BackColor.B + lma);
                    menuSettingsBtn.ForeColor = Color.FromArgb(menuPnl.ForeColor.R - lma, menuPnl.ForeColor.G - lma, menuPnl.ForeColor.B - lma);
                    menuIndicatorPnl.Location = new Point(menuIndicatorPnl.Location.X, menuSettingsBtn.Location.Y);

                    //optBarImage.Image = Image.FromFile(imagesFolderDir + "Settings-icon.png");

                    break;


            }
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
    }
}
