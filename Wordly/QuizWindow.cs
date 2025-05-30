using Newtonsoft.Json;

namespace Wordly
{
    public partial class QuizWindow : Form
    {
        public class WordList
        {
            public required List<string[]> Term;
            public required List<string[]> Meaning;
        }
        public static WordList wl;

        public static List<string> TermStrArr = new List<string>();
        public static List<string> MeaningStrArr = new List<string>();

        public static bool answerWithMeaning = true, answerWithBoth = false;


        public QuizWindow()
        {
            wl = JsonConvert.DeserializeObject<WordList>(File.ReadAllText(ChooseListForm.listFilePath));

            InitializeComponent();
            InitializeByHand();
        }
        private void InitializeByHand()
        {
            TermStrArr = new List<string>();
            MeaningStrArr = new List<string>();
            CreateWordListPnl();

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
                wordContainerInnerPnl.Controls.Add(wp);
            }
            Panel spacingPnl = new Panel();
            spacingPnl.Location = new Point(0, wl.Term.Count * 90);
            spacingPnl.Size = new Size(10, 10);
            wordContainerInnerPnl.Controls.Add(spacingPnl);
            wordContainerInnerPnl.Size = new Size(wordContainerInnerPnl.Width, spacingPnl.Location.Y+spacingPnl.Height);
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
                BackColor = Color.FromArgb(60,60,60);
                Controls.Add(wordTermLbl);
                Controls.Add(wordMeaningLbl);
                Location = new Point(10, yLoc);
                Size = new Size(480, 80);
                // 
                // wordTermLbl
                // 
                wordTermLbl.BackColor = Color.FromArgb(65, 65, 65);
                wordTermLbl.ForeColor = Color.FromArgb(220, 230, 230);
                wordTermLbl.Font = new Font("Cambria", 15F);
                wordTermLbl.Location = new Point(10, 10);
                wordTermLbl.Size = new Size(225, 60);
                wordTermLbl.TextAlign = ContentAlignment.MiddleLeft;
                wordMeaningLbl.CornerRadius = 7;
                AutoSize = false;

                // 
                // wordMeaningLbl
                // 
                wordMeaningLbl.BackColor = Color.FromArgb(65, 65, 65);
                wordMeaningLbl.ForeColor = Color.FromArgb(220, 230, 230);
                wordMeaningLbl.Font = new Font("Cambria", 12F);
                wordMeaningLbl.Location = new Point(245, 10);
                wordMeaningLbl.Size = new Size(225, 60);
                wordMeaningLbl.TextAlign = ContentAlignment.MiddleLeft;
                wordMeaningLbl.CornerRadius = 7;
                AutoSize = false;

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

        private void Option4Btn_Click(object sender, EventArgs e)
        {

        }
    }
}
