using System.Diagnostics;

namespace WordlyUIbaseVer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static StackFrame stackFrame = new StackTrace(new StackFrame(true)).GetFrame(0);
        public static string imgsFolderDir = Path.GetDirectoryName(stackFrame.GetFileName()) + @"\Images\";

        private void homeBtn_Click(object sender, EventArgs e)
        {
            ResetBtnClrs();
            homeBtn.BackColor = Color.FromArgb(192, 192, 0);

            titleLbl.Text = "Home";
            titleLogo.Image = Image.FromFile(imgsFolderDir + "house.png");

            mainPnl.Controls.Clear();
            Main_Window homeWindow = new Main_Window();
            homeWindow.Dock = DockStyle.Fill;
            homeWindow.TopLevel = false;
            homeWindow.TopMost = true;
            homeWindow.FormBorderStyle = FormBorderStyle.None;
            mainPnl.Controls.Add(homeWindow);
            homeWindow.Show();
        }
        private void startBtn_Click(object sender, EventArgs e)
        {
            ResetBtnClrs();
            startBtn.BackColor = Color.FromArgb(192, 192, 0);

            titleLbl.Text = "Menu";
            titleLogo.Image = Image.FromFile(imgsFolderDir + "language sign.png");

            mainPnl.Controls.Clear();
            Quiz_Window quizWindow = new Quiz_Window();
            quizWindow.Dock = DockStyle.Fill;
            quizWindow.TopLevel = false;
            quizWindow.TopMost = true;
            quizWindow.FormBorderStyle = FormBorderStyle.None;
            mainPnl.Controls.Add(quizWindow);
            quizWindow.Show();
        }
        private void createBtn_Click(object sender, EventArgs e)
        {
            ResetBtnClrs();
            createBtn.BackColor = Color.FromArgb(192, 192, 0);

            titleLbl.Text = "Create a New Word List";
            titleLogo.Image = Image.FromFile(imgsFolderDir + "plus icon.png");

            mainPnl.Controls.Clear();
            Add_Window addWindow = new Add_Window();
            addWindow.Dock = DockStyle.Fill;
            addWindow.TopLevel = false;
            addWindow.TopMost = true;
            addWindow.FormBorderStyle = FormBorderStyle.None;
            mainPnl.Controls.Add(addWindow);
            addWindow.Show();
        }

        private void setttingsBtn_Click(object sender, EventArgs e)
        {
            ResetBtnClrs();
            setttingsBtn.BackColor = Color.DarkGray;

            titleLbl.Text = "Settings";
            titleLogo.Image = Image.FromFile(imgsFolderDir + "Settings-icon.png");

            mainPnl.Controls.Clear();
            Settings_Window setWindow = new Settings_Window();
            setWindow.Dock = DockStyle.Fill;
            setWindow.TopLevel = false;
            setWindow.TopMost = true;
            setWindow.FormBorderStyle = FormBorderStyle.None;
            mainPnl.Controls.Add(setWindow);
            setWindow.Show();
        }
        private void quitBtn_Click(object sender, EventArgs e)
        {
            //add message box
        }

        private void ResetBtnClrs()
        {
            homeBtn.BackColor = Color.FromArgb(255, 255, 128);
            startBtn.BackColor = Color.FromArgb(255, 255, 128);
            createBtn.BackColor = Color.FromArgb(255, 255, 128);
            setttingsBtn.BackColor = Color.LightGray;
        }

    }
}
