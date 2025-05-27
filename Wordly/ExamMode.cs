namespace Wordly
{
    public partial class ExamMode : Form
    {
        private const int wordCount = 50;

        private TableLabel[] wordLabels = new TableLabel[wordCount];
        private TableBox[] wordTextBoxes = new TableBox[wordCount];
        private TilePanel[] wordTilePanels = new TilePanel[wordCount];

        private List<string> shown = new List<string> { };
        private List<string> required = new List<string> { };

        private string[] answers = new string[50];

        private Color incorrectAnswerTableClr, incorrectAnswerTilesClr, selectedBtnClr;
        private int RAOI = 40; //RAOI = rednessAmountOnIncorrect

        public ExamMode()
        {
            InitializeComponent();
            InitializeComponentsByHand();

            randomizeWords();
            switchAnswerWords();

            setUpTable();
            setUpTiles();
        }

        private void InitializeComponentsByHand()
        {
            incorrectAnswerTableClr = Color.FromArgb(TableBox.backClr.R + RAOI / 3, TableBox.backClr.G, TableBox.backClr.B);
            incorrectAnswerTilesClr = Color.FromArgb(viewTilesPnl.ForeColor.R - 10 + RAOI, viewTilesPnl.ForeColor.G - 20, viewTilesPnl.ForeColor.B - 20);

            selectedBtnClr = Color.FromArgb(BackColor.R + 10, BackColor.G + 15, BackColor.B + 15);

            selectTableBtn.BackgroundImage = Properties.Resources.tableBtnBackgroundImgWhite;
            selectTableBtn.BackgroundImageLayout = ImageLayout.Zoom;
            selectTableBtn.BackColor = selectedBtnClr;

            selectTilesBtn.BackgroundImage = Properties.Resources.tilesBtnBackgroundImgWhite;
            selectTilesBtn.BackgroundImageLayout = ImageLayout.Zoom;
            selectTilesBtn.BackColor = BackColor;
        }

        private void randomizeWords()
        {
            Random rand = new Random();

            List<string> termTemp = QuizWindow.TermStrArr;
            List<string> meaningTemp = QuizWindow.MeaningStrArr;
            int tempRand;

            for (int i = 0; i < wordCount; i++)
            {
                answers[i] = "";

                tempRand = rand.Next(0, QuizWindow.TermStrArr.Count());

                required.Add(termTemp[tempRand]);
                shown.Add(meaningTemp[tempRand]);

                termTemp.RemoveAt(tempRand);
                meaningTemp.RemoveAt(tempRand);
            }
        }

        private void switchAnswerWords()
        {
            int loopNum = 0;
            if (QuizWindow.answerWithBoth)
            {
                loopNum = wordCount / 2;

                indicatorLang1ALbl.Text = "Term";
                indicatorLang1BLbl.Text = "Meaning";
            }
            else if (QuizWindow.answerWithMeaning)
            {
                loopNum = wordCount;

                indicatorLang1ALbl.Text = "Term";
                indicatorLang1BLbl.Text = "Meaning";
                indicatorLang2ALbl.Text = "Term";
                indicatorLang2BLbl.Text = "Meaning";
            }

            string temp;
            for (int i = 0; i < loopNum; i++)
            {
                temp = required[i];
                required[i] = shown[i];
                shown[i] = temp;
            }
        }

        private void setUpTable()
        {
            //first column
            setUpTableColumn();

            //second column
            setUpTableColumn(true);

        }
        private void setUpTableColumn(bool isSecondRow = false)
        {
            int addX = 0;
            int addI = 0;
            if (isSecondRow)
            {
                addX = 450;
                addI = wordCount / 2;
            }

            for (int i = addI; i < wordCount / 2 + addI; i++)
            {
                wordLabels[i] = new TableLabel(addX, (i - addI) * 20 - 1);
                tableContentPnl.Controls.Add(wordLabels[i]);
                wordLabels[i].Text = shown[i];

                wordTextBoxes[i] = new TableBox(addX + 225, (i - addI) * 20 - 1);
                tableContentPnl.Controls.Add(wordTextBoxes[i]);
            }
        }

        private void setUpTiles()
        {
            for (int i = 0; i < wordCount; i++)
            {
                wordTilePanels[i] = new TilePanel();
                wordTilePanels[i].Location = new Point(25, 25 + i * (wordTilePanels[i].Height + 25));
                viewTilesPnl.Controls.Add(wordTilePanels[i]);

                wordTilePanels[i].shownWordLbl.Text = i + 1 + ". " + shown[i];
            }
        }

        private void updateAnswers()
        {
            for (int i = 0; i < wordCount; i++)
            {
                if (!answers[i].Equals(wordTextBoxes[i].Text))
                {
                    answers[i] = wordTextBoxes[i].Text;
                }
                else if (!answers[i].Equals(wordTilePanels[i].answerWordTbx.Text))
                {
                    answers[i] = wordTilePanels[i].answerWordTbx.Text;
                }

                wordTextBoxes[i].Text = answers[i];
                wordTilePanels[i].answerWordTbx.Text = answers[i];
            }
        }
        private void checkResults()
        {
            int correctAnswers = 0;

            for (int i = 0; i < shown.Count(); i++)
            {
                if (answers[i].Equals(required[i]))
                {
                    correctAnswers++;
                    wordTextBoxes[i].BackColor = wordTextBoxes[i].BackColor;
                    wordTilePanels[i].underlinePnl.BackColor = wordTilePanels[i].answerWordTbx.ForeColor;
                }
                else
                {
                    wordTextBoxes[i].BackColor = incorrectAnswerTableClr;
                    wordTilePanels[i].underlinePnl.BackColor = incorrectAnswerTilesClr;
                }
            }
            resultLbl.Text = Math.Round((double)correctAnswers / (double)wordCount * 100) + "% " + correctAnswers + "/" + wordCount;

            textResultLbl.Visible = true;
            resultLbl.Visible = true;
        }



        private bool ctrlPressed = false;
        private int checkFocused()
        {
            for (int i = 0; i < wordCount; i++)
            {
                if (wordTextBoxes[i].Focused)
                {
                    return i;
                }
            }
            return -1;
        }
        private void ExamMode_KeyDown(object sender, KeyEventArgs e)
        {
            int i = checkFocused();

            switch (e.KeyCode)
            {
                case Keys.Down:

                    if (i < wordCount - 1)
                    {
                        wordTextBoxes[i + 1].Focus();
                    }

                    break;

                case Keys.Up:

                    if (i > 0)
                    {
                        wordTextBoxes[i - 1].Focus();
                    }

                    break;

                case Keys.Left:

                    if (i >= wordCount / 2)
                    {
                        wordTextBoxes[i - wordCount / 2].Focus();
                    }

                    break;

                case Keys.Right:

                    if (i < wordCount / 2)
                    {
                        wordTextBoxes[i + wordCount / 2].Focus();
                    }

                    break;

                case Keys.Tab:

                    if (ctrlPressed)
                    {
                        if (viewTilesPnl.Visible)
                        {
                            selectTableBtn_Click(sender, e);
                        }
                        else
                        {
                            selectTilesButton_Click(sender, e);
                        }
                    }

                    break;

                case Keys.ControlKey:

                    ctrlPressed = true;

                    break;

                case Keys.Enter:

                    if (ctrlPressed)
                    {
                        SubmitBtn_Click(sender, e);
                    }

                    break;
            }

        }
        private void ExamMode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                ctrlPressed = false;
            }

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to submit your answers?", "Wordly \\ Exam Mode", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                updateAnswers();
                checkResults();
            }
        }
        private void selectTableBtn_Click(object sender, EventArgs e)
        {
            updateAnswers();

            selectTableBtn.BackColor = selectedBtnClr;
            selectTilesBtn.BackColor = BackColor;

            viewTilesPnl.Visible = false;
        }
        private void selectTilesButton_Click(object sender, EventArgs e)
        {
            updateAnswers();

            selectTableBtn.BackColor = BackColor;
            selectTilesBtn.BackColor = selectedBtnClr;

            viewTilesPnl.Visible = true;
        }


        private class TableLabel : Label
        {
            private Color backClr = Color.FromArgb(65, 65, 65);
            private Color foreClr = Color.FromArgb(220, 230, 230);
            private Color borderClr = Color.FromArgb(30,30,30);

            public TableLabel(int x, int y)
            {
                Location = new Point(x, y);
                Size = new Size(226, 21);
                TextAlign = ContentAlignment.MiddleLeft;
                Font = new Font("Cambria", 10.5F);
                BackColor = backClr;
                ForeColor = foreClr;
                Paint += this_Paint;
            }
            void this_Paint(object sender, PaintEventArgs e)
            {
                ControlPaint.DrawBorder(e.Graphics, DisplayRectangle, borderClr, ButtonBorderStyle.Solid); ;
            }
        }
        private class TableBox : AdvancedTextBox
        {
            public static Color backClr = Color.FromArgb(65, 65, 65);
            private Color foreClr = Color.FromArgb(220, 230, 230);
            private Color borderClr = Color.FromArgb(30, 30, 30);


            public TableBox(int x, int y)
            {
                BorderStyle = BorderStyle.FixedSingle;
                Location = new Point(x, y);
                Size = new Size(225, 21);
                Font = new Font("Candara", 11F);
                BackColor = backClr;
                ForeColor = foreClr;

                BorderColor = borderClr;
            }
        }

        private class TilePanel : RoundedPanel
        {
            private Color pnlBackClr = Color.FromArgb(70,70,70);
            private Color foreClr = Color.FromArgb(220,230,230);

            public Label shownWordLbl = new Label();
            public TextBox answerWordTbx = new();
            public RoundedPanel underlinePnl = new();

            public TilePanel()
            {
                // 
                // TilePanel
                // 
                Location = new Point(25, 25);
                Size = new Size(850, 200);
                BackColor = pnlBackClr;

                Controls.Add(shownWordLbl);
                Controls.Add(answerWordTbx);
                Controls.Add(underlinePnl);

                // 
                // shownWordLbl
                //                 
                shownWordLbl.ForeColor = foreClr;
                shownWordLbl.Location = new Point(50, 30);
                shownWordLbl.Size = new Size(750, 100);
                shownWordLbl.Font = new Font("Calibri", 22F);
                shownWordLbl.TextAlign = ContentAlignment.TopLeft;

                // 
                // answerWordTbx
                // 
                answerWordTbx.BackColor = BackColor;
                answerWordTbx.ForeColor = foreClr;
                answerWordTbx.Location = new Point(50, 120);
                answerWordTbx.Size = new Size(750, 36);
                answerWordTbx.BorderStyle = BorderStyle.None;
                answerWordTbx.Font = new Font("Candara", 22F);
                //
                // underlinePnl
                //
                underlinePnl.BackColor = foreClr;
                underlinePnl.Location = new Point(answerWordTbx.Location.X, answerWordTbx.Location.Y + answerWordTbx.Height);
                underlinePnl.Size = new Size(answerWordTbx.Width, 5);
                underlinePnl.CornerRadius = 1;

            }
        }
    }

}
