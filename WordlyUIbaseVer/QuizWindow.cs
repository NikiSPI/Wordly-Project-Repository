using Newtonsoft.Json;
using RoundedComponents;
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
    public partial class QuizWindow : Form
    {
        public class WordList
        {
            public List<string[]> Term;
            public List<string[]> Meaning;
        }
        public static WordList wl;

        private string fileDir;

        public static List<string> TermStrArr = new List<string>();
        public static List<string> MeaningStrArr = new List<string>();

        public static bool answerWithMeaning = false, answerWithBoth = false;


        public QuizWindow(string file)
        {
            fileDir = file;
            wl = JsonConvert.DeserializeObject<WordList>(File.ReadAllText(fileDir));

            InitializeComponent();
            InitializeByHand();
        }
        private void InitializeByHand()
        {
            TermStrArr = new List<string>();
            MeaningStrArr = new List<string>();
            CreateWordListPnl();

            wordListTitleSepPnl.rdus = 1;
        }
        public void Reset()
        {
            Controls.Clear();
            InitializeComponent();
            InitializeByHand();
        }


        private void CreateWordListPnl()
        {
            for (int i = 0; i < wl.Term.Count; i++)
            {
                TermStrArr.Add(CreateWordString(wl.Term[i], " / "));
                MeaningStrArr.Add(CreateWordString(wl.Meaning[i], ", "));

                WordPnl wp = new WordPnl(10 + i * 90);
                wp.wordTermLbl.Text = TermStrArr[i];
                wp.wordMeaningLbl.Text = MeaningStrArr[i];
                wordContainerPnl.Controls.Add(wp);
            }
            Panel spacingPnl = new Panel();
            spacingPnl.Location = new Point(0, wl.Term.Count * 90);
            spacingPnl.Size = new Size(10, 10);
            wordContainerPnl.Controls.Add(spacingPnl);
        }
        private string CreateWordString(string[] arr, string separate)
        {
            string combinedStr = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                combinedStr += separate + arr[i];
            }

            return combinedStr;
        }
        private class WordPnl : RoundedPanel
        {
            public RoundedLabel wordTermLbl = new();
            public RoundedLabel wordMeaningLbl = new();

            public WordPnl(int yLoc)
            {
                // 
                // wordSamplePnl
                // 
                Anchor = AnchorStyles.Top | AnchorStyles.Left;
                BackColor = Color.FromArgb(55, 55, 55);
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
                wordTermLbl.BackColor = Color.FromArgb(65, 65, 65);
                wordTermLbl.ForeColor = Color.FromArgb(200, 210, 210);
                wordTermLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
                wordTermLbl.Location = new Point(10, 10);
                wordTermLbl.Name = "wordTermLbl";
                wordTermLbl.Size = new Size(225, 60);
                wordTermLbl.TabIndex = 0;
                wordTermLbl.Text = "word 1";
                wordTermLbl.TextAlign = ContentAlignment.MiddleLeft;

                rdus = 7;
                // 
                // wordMeaningLbl
                // 
                wordMeaningLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                wordMeaningLbl.BackColor = Color.FromArgb(65, 65, 65);
                wordMeaningLbl.ForeColor = Color.FromArgb(200, 210, 210);
                wordMeaningLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
                wordMeaningLbl.Location = new Point(245, 10);
                wordMeaningLbl.Name = "wordMeaningLbl";
                wordMeaningLbl.Size = new Size(225, 60);
                wordMeaningLbl.TabIndex = 1;
                wordMeaningLbl.Text = "word 2";
                wordMeaningLbl.TextAlign = ContentAlignment.MiddleLeft;

                rdus = 7;
            }
        }



        private void Option1Btn_Click(object sender, EventArgs e) //FLASHCARDS
        {
            ChooseListForm.stepsToUndo = 2;

            FlashcardMode flashcardWindow = new FlashcardMode();
            flashcardWindow.Dock = DockStyle.Fill;
            flashcardWindow.TopLevel = false;
            flashcardWindow.TopMost = true;
            flashcardWindow.FormBorderStyle = FormBorderStyle.None;

            flashcardWindow.backBtn.Click += (sender, e) =>
            {
                ChooseListForm.stepsToUndo = 1;
                Reset();
            };

            Controls.Clear();
            Controls.Add(flashcardWindow);
            flashcardWindow.Show();
        }

        private void Option2Btn_Click(object sender, EventArgs e) //WRITE
        {
            ChooseListForm.stepsToUndo = 2;

            WriteMode writeWindow = new WriteMode();
            writeWindow.Dock = DockStyle.Fill;
            writeWindow.TopLevel = false;
            writeWindow.TopMost = true;
            writeWindow.FormBorderStyle = FormBorderStyle.None;

            writeWindow.eBackBtn.Click += (sender, e) =>
            {
                ChooseListForm.stepsToUndo = 1;
                Reset();
            };
            Controls.Clear();
            Controls.Add(writeWindow);
            writeWindow.Show();
        }

        private void Option3Btn_Click(object sender, EventArgs e)
        {
            ChooseListForm.stepsToUndo = 2;

            ExamMode examWindow = new ExamMode();
            examWindow.Dock = DockStyle.Fill;
            examWindow.TopLevel = false;
            examWindow.TopMost = true;
            examWindow.FormBorderStyle = FormBorderStyle.None;

            Controls.Clear();
            Controls.Add(examWindow);
            examWindow.Show();
        }

    }
}
