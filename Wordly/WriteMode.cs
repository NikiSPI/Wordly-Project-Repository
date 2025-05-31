namespace Wordly
{
    public partial class WriteMode : Form
    {
        private List<string> Showns;
        private List<string> Answers;
        private List<string[]> AnswerS;

        private int currentCard = 0, correctCount = 0, incorrectCount = 0;

        public WriteMode()
        {
            InitializeComponent();

            if (QuizWindow.answerWithMeaning)
            {
                Showns = QuizWindow.TermStrArr;
                Answers = QuizWindow.MeaningStrArr;
                AnswerS = QuizWindow.wl.Meaning;
            }
            else
            {
                Showns = QuizWindow.MeaningStrArr;
                Answers = QuizWindow.TermStrArr;
                AnswerS = QuizWindow.wl.Term;
            }

            aShownWordLbl.Text = Showns[0];
            UpdateStatPnl();

            ActiveControl = aAnswerTbx;
        }

        private void Reset()
        {
            currentCard = 0;
            correctCount = 0;
            incorrectCount = 0;
            UpdateStatPnl();

            aShownWordLbl.Text = Showns[0];
            aAnswerTbx.Clear();
            aAnswerTbx.Focus();

            endPnl.Visible = false;
            answerPnl.Visible = true;
            statPnl.Visible = true;

        }

        private void wordHanded()
        {
            bool wordMatches = false;

            for (int i = 0; i < AnswerS[currentCard].Length; i++)
            {
                if (aAnswerTbx.Text.Equals(AnswerS[currentCard][i]))
                {
                    correctCount++;
                    NextWord();

                    wordMatches = true;
                    break;
                }
            }
            if (aAnswerTbx.Text.Equals(Answers[currentCard]))
            {
                correctCount++;
                NextWord();

                wordMatches = true;
            }


            if (!wordMatches)
            {
                incorrectCount++;
                ShowNUpdateCorrectionScreen();
            }

        }
        private void NextWord()
        {
            if (currentCard >= Showns.Count - 1)
            {
                ShowEndScreen();
            }
            else
            {
                currentCard++;
                UpdateStatPnl();

                aShownWordLbl.Text = Showns[currentCard];
                aAnswerTbx.Clear();
            }
        }

        private void ShowNUpdateCorrectionScreen()
        {
            iShownWordLbl.Text = Showns[currentCard];
            iAnswerWordLbl.Text = aAnswerTbx.Text;
            iCorrectMeaningLbl.Text = Answers[currentCard];
            incorrectPnl.Visible = true;
        }
        private void UpdateStatPnl()
        {
            statNumCorrectLbl.Text = correctCount.ToString();
            statNumWrongLbl.Text = incorrectCount.ToString();
            statNumLeftLbl.Text = currentCard.ToString() + " / " + Showns.Count;
        }


        private void aAnswerBtn_Click(object sender, EventArgs e)
        {
            wordHanded();
        }
        private void iContinueBtn_Click(object sender, EventArgs e)
        {
            NextWord();
            incorrectPnl.Visible = false;
            aAnswerTbx.Focus();
        }

        private void iWasCorrectBtn_Click(object sender, EventArgs e)
        {
            incorrectCount--;
            correctCount++;

            NextWord();
            incorrectPnl.Visible = false;
            aAnswerTbx.Focus();
        }


        private bool ctrlPressed = false;
        private void WriteMode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !endPnl.Visible)
            {
                if (incorrectPnl.Visible)
                {
                    if (ctrlPressed)
                    {
                        iWasCorrectBtn_Click(sender, e);
                    }
                    else
                    {
                        iContinueBtn_Click(sender, e);
                    }
                }
                else
                {
                    wordHanded();
                }

                //to surpress the 'ding' sound when pressing enter
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.ControlKey)
            {
                ctrlPressed = true;
            }
        }

        private void WriteMode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                ctrlPressed = false;
            }
        }

        //|END SCREEN
        private void ShowEndScreen()
        {
            statPnl.Visible = false;
            answerPnl.Visible = false;
            endPnl.Visible = true;
            resultLbl.Text = ((double)(10000 * correctCount / Showns.Count) / 100) + "% " + correctCount + "/" + Showns.Count;
        }
        private void againBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
