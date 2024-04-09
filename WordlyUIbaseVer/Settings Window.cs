using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wordly_alpha
{
    public partial class Settings_Window : Form
    {
        public Settings_Window()
        {
            InitializeComponent();
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
