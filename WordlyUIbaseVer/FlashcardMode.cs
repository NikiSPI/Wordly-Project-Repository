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
    public partial class FlashcardMode : Form
    {

        private List<string> Term;
        private List<string> Meaning;

        private int currentCard = 0;
        private bool isCardFlipped = false;

        public FlashcardMode(List<string> term, List<string> meaning)
        {
            InitializeComponent();

            Term = term;
            Meaning = meaning;

            flashcardBtn.Text = Term[currentCard];
        }

        private void NextCard()
        {
            if (currentCard >= Term.Count - 1)
            {
                EndPnl.Visible = true;
                flashcardBtn.BackColor = Color.White;
            }
            else
            {
                currentCard++;
                UnflipCard();
            }
        }
        private void PreviousCard()
        {
            if (currentCard > 0)
            {
                currentCard--;
                UnflipCard();
            }
        }
        private void FlipCard()
        {
            isCardFlipped = true;
            flashcardBtn.BackColor = Color.LawnGreen;
            flashcardBtn.Text = Meaning[currentCard];
        }
        public void UnflipCard()
        {
            isCardFlipped = false;
            flashcardBtn.BackColor = Color.YellowGreen;
            flashcardBtn.Text = Term[currentCard];
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
            NextCard();
        }

        private void AgainBtn_Click(object sender, EventArgs e)
        {
            currentCard = 0;
            isCardFlipped = false;

            UnflipCard();
            EndPnl.Visible = false;
        }

        private void FlashcardMode_KeyDown(object sender, KeyEventArgs e)
        {
            Focus();

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
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
            else if (e.KeyCode == Keys.Right)
            {
                NextCard();
            }
            else if (e.KeyCode == Keys.Left)
            {
                PreviousCard();
            }

        }
        private void FlashcardMode_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) 
        {
            e.IsInputKey = true;  //required for the KeyDown method to detect the arrow 
        }

    }
}
