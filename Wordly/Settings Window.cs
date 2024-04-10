namespace Wordly
{
    public partial class Settings_Window : Form
    {
        public Settings_Window()
        {
            InitializeComponent();

            kbTitleSepPnl.rdus = 1;
        }

        private void switch1Opt1SBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (switch1Opt1SBtn.Checked)
            {
                switchable1Opt1Lbl.Text = "Meaning";
                QuizWindow.answerWithMeaning = true;
            }
            else
            {
                switchable1Opt1Lbl.Text = "Term";
                QuizWindow.answerWithMeaning = false;
            }
        }

        private void switch1Opt2SBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (switch1Opt2SBtn.Checked)
            {
                QuizWindow.answerWithBoth = true;
            }
            else
            {
                QuizWindow.answerWithBoth = false;
            }

        }
    }
}
