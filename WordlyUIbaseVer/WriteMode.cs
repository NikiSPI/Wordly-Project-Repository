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
    public partial class WriteMode : Form
    {
        private List<string> Shown;
        private List<string> Answer;
        private List<string[]> AnswerS;

        private int currentCard = 0, correctCount = 0, incorrectCount = 0;

        public WriteMode()
        {
            InitializeComponent();

            if (QuizWindow.answerWithMeaning)
            {
                Shown = QuizWindow.TermStrArr;
                Answer = QuizWindow.MeaningStrArr;
                AnswerS = QuizWindow.wl.Meaning;
            }
            else
            {
                Shown = QuizWindow.MeaningStrArr;
                Answer = QuizWindow.TermStrArr;
                AnswerS = QuizWindow.wl.Term;
            }

            aShownWordLbl.Text = Shown[0];
            UpdateStatPnl();

            aUnderlineTbxPnl.rdus = 1;
            statIntersectionPnl.rdus = 1;
            aAnswerTbx.Focus();
        }

        private void Reset()
        {
            currentCard = 0;
            correctCount = 0;
            incorrectCount = 0;
            UpdateStatPnl();

            aShownWordLbl.Text = Shown[0];
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
            if (aAnswerTbx.Text.Equals(Answer[currentCard]))
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
            if (currentCard >= Shown.Count - 1)
            {
                ShowEndScreen();
            }
            else
            {
                currentCard++;
                UpdateStatPnl();

                aShownWordLbl.Text = Shown[currentCard];
                aAnswerTbx.Clear();
            }
        }

        private void ShowNUpdateCorrectionScreen()
        {
            iShownWordLbl.Text = Shown[currentCard];
            iAnswerWordLbl.Text = aAnswerTbx.Text;
            iCorrectMeaningLbl.Text = Answer[currentCard];
            incorrectPnl.Visible = true;
        }
        private void UpdateStatPnl()
        {
            statNumCorrectLbl.Text = correctCount.ToString();
            statNumWrongLbl.Text = incorrectCount.ToString();
            statNumLeftLbl.Text = currentCard.ToString() + " / " + Shown.Count;
        }


        private void iContinueBtn_Click(object sender, EventArgs e)
        {
            NextWord();
            incorrectPnl.Visible = false;
            aAnswerTbx.Focus();
        }
        private void aAnswerBtn_Click(object sender, EventArgs e)
        {
            aAnswerTbx.Focus();
            wordHanded();
        }


        private void WriteMode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !endPnl.Visible)
            {
                if (incorrectPnl.Visible)
                {
                    NextWord();
                    incorrectPnl.Visible = false;
                    aAnswerTbx.Focus();
                }
                else
                {
                    wordHanded();
                }

                //to surpress the 'ding' sound when pressing enter
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        //|END SCREEN
        private void ShowEndScreen()
        {
            statPnl.Visible = false;
            answerPnl.Visible = false;
            endPnl.Visible = true;
            resultLbl.Text = ((double)(10000 * correctCount / Shown.Count) / 100) + "% " + correctCount + "/" + Shown.Count;
        }
        private void againBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

    }
}
