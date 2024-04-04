using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordlyUIbaseVer;

namespace MYP_extension
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

        private bool answerWithMeaning = false, answerWithBoth = true;

        public static Color defaultTableTbxClr = Color.White, defaultTilesTbxClr = Color.White;
        private Color incorrectAnswerClr = Color.MistyRose, selectedBtnClr = Color.FromArgb(230,230,230);

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
            selectTableBtn.BackgroundImage = WordlyUIbaseVer.Properties.Resources.tableBtnBackgroundImg;
            selectTableBtn.BackgroundImageLayout = ImageLayout.Zoom;
            selectTableBtn.BackColor = selectedBtnClr;

            selectTilesBtn.BackgroundImage = WordlyUIbaseVer.Properties.Resources.tilesBtnBackgroundImg;
            selectTilesBtn.BackgroundImageLayout = ImageLayout.Zoom;
            selectTilesBtn.BackColor = Color.Transparent;
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
            if (answerWithBoth)
            {
                loopNum = wordCount / 2;

                indicatorLang1ALbl.Text = "Term";
                indicatorLang1BLbl.Text = "Definition";
            }
            else if (answerWithMeaning)
            {
                loopNum = wordCount;

                indicatorLang1ALbl.Text = "Term";
                indicatorLang1BLbl.Text = "Definition";
                indicatorLang2ALbl.Text = "Term";
                indicatorLang2BLbl.Text = "Definition";
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
                    wordTextBoxes[i].BackColor = defaultTableTbxClr;
                    wordTilePanels[i].answerWordTbx.BackColor = defaultTilesTbxClr;
                }
                else
                {
                    wordTextBoxes[i].BackColor = incorrectAnswerClr;
                    wordTilePanels[i].answerWordTbx.BackColor = incorrectAnswerClr;
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

                case Keys.ControlKey:

                    ctrlPressed = true;

                    break;

                case Keys.Enter:

                    if (ctrlPressed)
                    {
                        SubmitBtn_Click();
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

        private void SubmitBtn_Click(object sender = null, EventArgs e = null)
        {
            if (MessageBox.Show("Are you sure you want to submit your answers?", "Wordly / Exam Mode", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                updateAnswers();
                checkResults();
            }
        }
        private void selectTableBtn_Click(object sender, EventArgs e)
        {
            updateAnswers();

            selectTableBtn.BackColor = selectedBtnClr;
            selectTilesBtn.BackColor = Color.Transparent;

            viewTablePnl.Visible = true;
            viewTilesPnl.Visible = false;
        }
        private void selectTilesButton_Click(object sender, EventArgs e)
        {
            updateAnswers();

            selectTilesBtn.BackColor = selectedBtnClr;
            selectTableBtn.BackColor = Color.Transparent;

            viewTablePnl.Visible = false;
            viewTilesPnl.Visible = true;
        }


        private class TableLabel : Label
        {
            public TableLabel(int x, int y)
            {
                BorderStyle = BorderStyle.FixedSingle;
                Location = new Point(x, y);
                Size = new Size(226, 21);
                TextAlign = ContentAlignment.MiddleLeft;
                Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
                BackColor = ExamMode.defaultTableTbxClr;
            }
        }
        private class TableBox : TextBox
        {
            public TableBox(int x, int y)
            {
                Location = new Point(x, y);
                AutoSize = false;
                Size = new Size(225, 21);
                BorderStyle = BorderStyle.FixedSingle;
                Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
                BackColor = ExamMode.defaultTableTbxClr;
            }
        }

        private class TilePanel : Panel
        {
            public Label shownWordLbl = new Label();
            public TextBox answerWordTbx = new TextBox();

            public TilePanel()
            {
                // 
                // TilePanel
                // 
                Location = new Point(25, 25);
                Size = new Size(850, 200);
                BackColor = Color.WhiteSmoke;

                Controls.Add(shownWordLbl);
                Controls.Add(answerWordTbx);

                // 
                // shownWordLbl
                // 
                shownWordLbl.Location = new Point(50, 30);
                shownWordLbl.Size = new Size(750, 50);
                shownWordLbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                shownWordLbl.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
                shownWordLbl.TextAlign = ContentAlignment.MiddleLeft;

                // 
                // answerWordTbx
                // 
                answerWordTbx.Location = new Point(50, 120);
                answerWordTbx.Size = new Size(750, 36);
                answerWordTbx.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                answerWordTbx.BorderStyle = BorderStyle.None;
                answerWordTbx.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);

            }
        }
    }

}
