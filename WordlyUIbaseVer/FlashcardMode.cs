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
    public partial class FlashcardMode : Form
    {

        private List<string> Shown;
        private List<string> Answer;

        private List<bool> nextCardHistory = new List<bool>();

        private int currentCard = 0, correctCount = 0, incorrectCount = 0;
        private bool isCardFlipped = false;

        private Color frontsideClr = Color.FromArgb(120, 130, 130), backsideClr = Color.FromArgb(100, 110, 110);
        private Color frontsideHoverClr = Color.FromArgb(115, 125, 125), backsideHoverClr = Color.FromArgb(95, 105, 105);
        private Color frontsideForeClr = Color.FromArgb(240, 245, 245), backsideForeClr = Color.FromArgb(220, 225, 225);

        public FlashcardMode()
        {
            InitializeComponent();

            if (QuizWindow.answerWithMeaning)
            {
                Shown = QuizWindow.TermStrArr;
                Answer = QuizWindow.MeaningStrArr;
            }
            else
            {
                Shown = QuizWindow.MeaningStrArr;
                Answer = QuizWindow.TermStrArr;
            }

            flashcardBtn.Text = Shown[currentCard];
            countLbl.Text = "1 / " + Shown.Count;
        }

        private void Reset()
        {
            currentCard = 0;
            correctCount = 0;
            statCorrectLbl.Text = "0";
            incorrectCount = 0;
            statIncorrectLbl.Text = "0";
            nextCardHistory.Clear();
            countLbl.Text = "1 / " + Shown.Count;

            isCardFlipped = false;
            UnflipCard();
            endPnl.Visible = false;
            statPnl.Visible = true;
            countLbl.Visible = true;

        }

        private void NextCard()
        {
        
            if(currentCard < Shown.Count - 1)
            {
                currentCard++;
                UnflipCard();

                countLbl.Text = Convert.ToString(currentCard + 1) + " / " + Shown.Count;
            }
            else if (currentCard == Shown.Count - 1)
            {
                currentCard++;
                
                endPnl.Visible = true;
                statPnl.Visible = false;
                countLbl.Visible = false;

                resultLbl.Text = ((double)(10000 * correctCount / Shown.Count) / 100 ) + "% " + correctCount + "/" + Shown.Count;
            }

        }
        private void PreviousCard()
        {
            if (currentCard > 0)
            {
                currentCard--;
                UnflipCard();

                countLbl.Text = Convert.ToString(currentCard + 1) + " / " + Shown.Count;

                // statPnl undo
                if (nextCardHistory[currentCard])
                {
                    UpdateStatPnl(true, -1);
                }
                else
                {
                    UpdateStatPnl(false, -1);
                }
                nextCardHistory.RemoveAt(currentCard);
            }
        }
        private void FlipCard()
        {
            isCardFlipped = true;

            flashcardBtn.BackColor = backsideClr;
            flashcardBtn.ForeColor = backsideForeClr;
            flashcardBtn.FlatAppearance.MouseOverBackColor = backsideHoverClr;
            flashcardBtn.FlatAppearance.MouseDownBackColor = frontsideClr;

            flashcardBtn.Text = Answer[currentCard];
        }
        public void UnflipCard()
        {
            isCardFlipped = false;

            flashcardBtn.BackColor = frontsideClr;
            flashcardBtn.ForeColor = frontsideForeClr;
            flashcardBtn.FlatAppearance.MouseOverBackColor = frontsideHoverClr;
            flashcardBtn.FlatAppearance.MouseDownBackColor = backsideClr;

            flashcardBtn.Text = Shown[currentCard];
        }

        private void UpdateStatPnl(bool isCorrect, int addOrSubtract = 1)
        {
            if (isCorrect)
            {
                correctCount += addOrSubtract;
                statCorrectLbl.Text = Convert.ToString(correctCount);
            }
            else
            {
                incorrectCount += addOrSubtract;
                statIncorrectLbl.Text = Convert.ToString(incorrectCount);
            }
        }


        private void FlashcardBtn_Click(object sender, EventArgs e)
        {
            if (isCardFlipped)
            {
                UnflipCard();
            }
            else
            {
                FlipCard();
            }
        }

        private void PreviousCardBtn_Click(object sender, EventArgs e)
        {
            PreviousCard();
        }

        private void NextCardBtn_Click(object sender, EventArgs e)
        {
            if(sender == nextCardCBtn)
            {
                UpdateStatPnl(true);
                nextCardHistory.Add(true);
            }
            else
            {
                UpdateStatPnl(false);
                nextCardHistory.Add(false);
            }

            NextCard();
        }

        private void AgainBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void FlashcardMode_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {

                case Keys.Space:

                    if (isCardFlipped)
                    {
                        UnflipCard();
                    }
                    else
                    {
                        FlipCard();
                    }

                    break;

                case Keys.Up:

                    UpdateStatPnl(true);
                    nextCardHistory.Add(true);
                    NextCard();

                    break;

                case Keys.Down:

                    UpdateStatPnl(false);
                    nextCardHistory.Add(false);
                    NextCard();

                    break;

                case Keys.Left:

                    PreviousCard();

                    break;

            }

        }
        private void FlashcardMode_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = true;  //required for the KeyDown method to detect the arrow 
        }

    }
}
