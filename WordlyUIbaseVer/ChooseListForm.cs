using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordlyUIbaseVer
{
    public partial class ChooseListForm : Form
    {
        public ChooseListForm()
        {
            InitializeComponent();
        }

        private void wordList1Btn_Click(object sender, EventArgs e)
        {

            QuizWindow quizWindow = new QuizWindow();
            quizWindow.Dock = DockStyle.Fill;
            quizWindow.TopLevel = false;
            quizWindow.TopMost = true;
            quizWindow.FormBorderStyle = FormBorderStyle.None;

            contentPnl.Controls.Clear();
            contentPnl.Controls.Add(quizWindow);
            quizWindow.Show();

        }
    }
}
