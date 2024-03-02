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
    public partial class WriteMode : Form
    {

        private List<string[]> TermS;
        private List<string[]> MeaningS;

        private List<string> Term;
        private List<string> Meaning;

        private int currentCard = 0, correctWords = 0, wrongWords = 0;

        public WriteMode(List<string[]> termS, List<string[]> meaningS, List<string> term, List<string> meaning)
        {
            InitializeComponent();

            TermS = termS;
            MeaningS = meaningS;
            Term = term;
            Meaning = meaning;

            aShownWordLbl.Text = Term[0];
            UpdateStatPnl();
        }

        private void wordHanded()
        {
            bool wordMatches = false;

            for (int i = 0; i < MeaningS[currentCard].Length; i++)
            {
                if (aAnswerTbx.Text.Equals(MeaningS[currentCard][i]))
                {
                    correctWords++;
                    NextWord();

                    wordMatches = true;
                    break;
                }
            }

            if (!wordMatches)
            {
                wrongWords++;
                ShowNUpdateCorrectionScreen();
            }

        }
        private void NextWord()
        {
            if (currentCard >= TermS.Count - 1)
            {
                ShowEndScreen();
            }
            else
            {
                currentCard++;
                UpdateStatPnl();

                aShownWordLbl.Text = Term[currentCard];
                aAnswerTbx.Clear();
            }
        }

        private void ShowNUpdateCorrectionScreen()
        {
            iShownWordLbl.Text = Term[currentCard];
            iAnswerWordLbl.Text = aAnswerTbx.Text;
            iCorrectMeaningLbl.Text = Meaning[currentCard];
            incorrectPnl.Visible = true;
        }

        private void UpdateStatPnl()
        {
            statNumCorrectLbl.Text = correctWords.ToString();
            statNumWrongLbl.Text = wrongWords.ToString();
            statNumLeftLbl.Text = currentCard.ToString() + " / " + TermS.Count;
        }


        private void iContinueBtn_Click(object sender, EventArgs e)
        {
            NextWord();
            incorrectPnl.Visible = false;
            aAnswerTbx.Focus();
        }
        private void aAnswerBtn_Click(object sender, EventArgs e)
        {
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
            }
        }
        private void WriteMode_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = true;
        }

        //|END SCREEN
        private void ShowEndScreen()
        {
            statPnl.Visible = false;
            endPnl.Visible = true;
        }
        private void againBtn_Click(object sender, EventArgs e)
        {
            currentCard = 0;
            correctWords = 0;
            wrongWords = 0;
            UpdateStatPnl();

            aShownWordLbl.Text = Term[0];
            aAnswerTbx.Clear();
            aAnswerTbx.Focus();

            endPnl.Visible = false;
            statPnl.Visible = true;
        }

    }
}
