namespace Wordly
{
    public partial class ChooseListForm : Form
    {
        public static int stepsToUndo = 0;

        public QuizWindow quizWindow;
        public static string? listFilePath;

        private static Color buttonBackclr = Color.FromArgb(42, 42, 42);
        private static Color buttonForeclr = Color.FromArgb(210, 220, 220);

        public ChooseListForm()
        {
            InitializeComponent();

            InitializeFunctions();
        }
        public void InitializeFunctions()
        {
            string fullname = new FileInfo("Word Lists").FullName; //the name of the folder that is seeked

            DirectoryInfo d = new DirectoryInfo(fullname); //Assuming this is your Folder
            FileInfo[] files = d.GetFiles(); //Getting files
            
            for (int i = 0; i < files.Length; i++)
            {
                WordListBtn btn = new WordListBtn(10 + 110 * i, files[i].Name);
                contentPnl.Controls.Add(btn);

                string filePath = files[i].FullName;
                btn.Click += (sender, EventArgs) => { Button_Click(sender, EventArgs, filePath); };
            }

        }


        private void Button_Click(object sender, EventArgs e, string filePath)
        {
            stepsToUndo = 1;

            listFilePath = filePath;

            quizWindow = new QuizWindow();
            quizWindow.Dock = DockStyle.Fill;
            quizWindow.TopLevel = false;
            quizWindow.TopMost = true;
            quizWindow.FormBorderStyle = FormBorderStyle.None;

            Controls.Clear();
            Controls.Add(quizWindow);
            quizWindow.Show();
        }


        private class WordListBtn : RoundedButton
        {
            public WordListBtn(int yPos, string name)
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                BackColor = buttonBackclr;
                ForeColor = buttonForeclr;
                FlatAppearance.BorderSize = 0;
                FlatAppearance.MouseOverBackColor = Color.FromArgb(buttonBackclr.R + 0, buttonBackclr.G + 5, buttonBackclr.B + 5);
                FlatAppearance.MouseDownBackColor = Color.FromArgb(buttonBackclr.R + 15, buttonBackclr.G + 15, buttonBackclr.B + 15);
                FlatStyle = FlatStyle.Flat;
                Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
                Location = new Point(10, yPos);
                Name = "wordListBtn";
                Size = new Size(780, 100);
                TabStop = false;
                UseMnemonic = false;
                Text = name.Substring(0, name.Length - 5);
                UseVisualStyleBackColor = false;
                CornerRadius = 20;
            }
        }


        public void UndoFunction()
        {
            if (stepsToUndo == 1)
            {
                Controls.Clear();
                InitializeComponent();
                InitializeFunctions();
            }

            else if (stepsToUndo == 2)
            {
                quizWindow.Reset();
            }

            stepsToUndo--;
        }
    }
}