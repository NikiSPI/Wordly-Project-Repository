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

        public List<string> Term;
        public List<string> Meaning;

        private int currentCard = 0;
        private bool isCardFlipped = false;

        public FlashcardMode()
        {
            InitializeComponent();
        }

        private void FlashcardBtn_Click(object sender, EventArgs e)
        {
            if (isCardFlipped)
            {
                UnflipCard();
            }
            else
            {
                isCardFlipped = true;
                flashcardBtn.BackColor = Color.LawnGreen;
                flashcardBtn.Text = Meaning[currentCard];
            }
        }

        private void PreviousCardBtn_Click(object sender, EventArgs e)
        {
            if (currentCard > 0)
            {
                currentCard--;
                UnflipCard();
            }
        }

        private void NextCardBtn_Click(object sender, EventArgs e)
        {
            currentCard++;
            if (currentCard >= Term.Count)
            {
                EndPnl.Visible = true;
            }
            else
            {
                UnflipCard();
            }
        }

        public void UnflipCard()
        {
            isCardFlipped = false;
            flashcardBtn.BackColor = Color.YellowGreen;
            flashcardBtn.Text = Term[currentCard];
        }

        private void AgainBtn_Click(object sender, EventArgs e)
        {
            currentCard = 0;
            isCardFlipped = false;

            UnflipCard();
            EndPnl.Visible = false;
        }

    }
}
