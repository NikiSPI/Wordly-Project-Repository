using Newtonsoft.Json;
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
    public partial class QuizWindow : Form
    {
        private class WordList
        {
            public List<string[]> Term;
            public List<string[]> Meaning;
        }

        private WordList wl;

        private string fileDir;

        private List<string> TermStr = new List<string>();
        private List<string> MeaningStr = new List<string>();

        public QuizWindow(string file)
        {
            InitializeComponent();

            fileDir = file;

            CreateWordListPnl();
        }

        public void Reset()
        {
            Controls.Clear();
            InitializeComponent();
            CreateWordListPnl();
        }

        private void Option1Btn_Click(object sender, EventArgs e) //FLASHCARDS
        {
            WordlyForm.stepsToUndo = 2;

            FlashcardMode flashcardWindow = new FlashcardMode();
            flashcardWindow.Dock = DockStyle.Fill;
            flashcardWindow.TopLevel = false;
            flashcardWindow.TopMost = true;
            flashcardWindow.FormBorderStyle = FormBorderStyle.None;

            flashcardWindow.backBtn.Click += FlashcardBackBtn_Click;

            flashcardWindow.Term = TermStr;
            flashcardWindow.Meaning = MeaningStr;
            flashcardWindow.UnflipCard();

            Controls.Clear();
            Controls.Add(flashcardWindow);
            flashcardWindow.Show();
        }
        private void FlashcardBackBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }


        private void CreateWordListPnl()
        {
            wl = JsonConvert.DeserializeObject<WordList>(File.ReadAllText(fileDir));

            for (int i = 0; i < wl.Term.Count; i++)
            {
                WordPnl wp = new WordPnl(10 + i * 90);
                wp.wordTermLbl.Text = CreateWordString(wl.Term[i]);
                wp.wordMeaningLbl.Text = CreateWordString(wl.Meaning[i]);

                TermStr.Add(CreateWordString(wl.Term[i]));
                MeaningStr.Add(CreateWordString(wl.Meaning[i]));

                wordContainerPnl.Controls.Add(wp);
            }
        }
        private string CreateWordString(string[] arr)
        {
            string combinedStr = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                combinedStr += ", " + arr[i];
            }

            return combinedStr;
        }
        private class WordPnl : Panel
        {
            public Label wordTermLbl = new Label();
            public Label wordMeaningLbl = new Label();

            public WordPnl(int yLoc)
            {
                // 
                // wordSamplePnl
                // 
                Anchor = AnchorStyles.Top | AnchorStyles.Left;
                BackColor = SystemColors.GradientActiveCaption;
                Controls.Add(wordTermLbl);
                Controls.Add(wordMeaningLbl);
                Location = new Point(10, yLoc);
                Name = "wordSamplePnl";
                Size = new Size(480, 80);
                TabIndex = 0;
                // 
                // wordTermLbl
                // 
                wordTermLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                wordTermLbl.BackColor = Color.PowderBlue;
                wordTermLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
                wordTermLbl.Location = new Point(10, 10);
                wordTermLbl.Name = "wordTermLbl";
                wordTermLbl.Size = new Size(225, 60);
                wordTermLbl.TabIndex = 0;
                wordTermLbl.Text = "word 1";
                wordTermLbl.TextAlign = ContentAlignment.MiddleCenter;
                // 
                // wordMeaningLbl
                // 
                wordMeaningLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                wordMeaningLbl.BackColor = Color.PowderBlue;
                wordMeaningLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
                wordMeaningLbl.Location = new Point(245, 10);
                wordMeaningLbl.Name = "wordMeaningLbl";
                wordMeaningLbl.Size = new Size(225, 60);
                wordMeaningLbl.TabIndex = 1;
                wordMeaningLbl.Text = "word 2";
                wordMeaningLbl.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

    }
}
