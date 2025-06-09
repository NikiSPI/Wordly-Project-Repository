using System.Windows.Forms;

namespace Wordly
{
    public partial class Creation_Window : Form
    {

        public class WordList
        {
            public required List<string[]> Term;
            public required List<string[]> Meaning;
        }
        public static WordList wl;

        public static List<string> TermStrArr = new List<string>();
        public static List<string> MeaningStrArr = new List<string>();


        
        private char separateWordChar = '-', separatePairChar = '\n';

        public Creation_Window()
        {
            InitializeComponent();
            inYLoc = termTB.Location.Y;



        }






        private void addWordPairBtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(termTB.Text))
            {
                termMessageLbl.Text = "Term is not entered! ";

                if (!termMessagePopped)
                    popTermMessage(2000);
            }
            else if (string.IsNullOrEmpty(meaningTB.Text))
            {
                meaningMessageLbl.Text = "Meaning is not entered! ";

                if (!meaningMessagePopped)
                    popMeaningMessage(2000);
            }

            else
            {
                inputTB.Text = termTB.Text + separateWordChar + meaningTB.Text + separatePairChar + inputTB.Text;

                termTB.Text = string.Empty;
                meaningTB.Text = string.Empty;

            }
        }









        private bool termMessagePopped = false;
        private void popTermMessage(int waitTime)
        {
            termMessagePopped = true;

            this.Refresh();
            termMessageLbl.Visible = true;
            termMessageLbl.Refresh(); //in order to fix the 'thread.sleep' glitching out
            //this.Refresh();

            Thread.Sleep(waitTime); //in miliseconds

            int initLocY = termMessageLbl.Location.Y;

            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Interval = 40; //starting speed
            t.Tick += (object sender, EventArgs e) =>
            {
                termMessageLbl.Location = new Point(termMessageLbl.Location.X, termMessageLbl.Location.Y + 2);

                if (t.Interval >= 25) //max speed
                    t.Interval -= 5; //acceleration

                if (termMessageLbl.Location.Y >= 110)
                {
                    t.Stop();

                    termMessageLbl.Visible = false;
                    termMessageLbl.Location = new Point(termMessageLbl.Location.X, initLocY);

                    termMessagePopped = false;
                }
            };

            termMessageLbl.Visible = true;
            t.Start();
        }
        private bool meaningMessagePopped = false;
        public void popMeaningMessage(int waitTime)
        {
            meaningMessagePopped = true;

            meaningMessageLbl.Visible = true;
            this.Refresh(); //in order to fix the 'thread.sleep' glitching out

            Thread.Sleep(waitTime);

            int initLocY = meaningMessageLbl.Location.Y;

            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Interval = 40; //starting speed
            t.Tick += (object sender, EventArgs e) =>
            {
                meaningMessageLbl.Location = new Point(meaningMessageLbl.Location.X, meaningMessageLbl.Location.Y + 2);

                if (t.Interval >= 25) //max speed
                    t.Interval -= 5; //acceleration

                if (meaningMessageLbl.Location.Y >= 110)
                {
                    t.Stop();

                    meaningMessageLbl.Visible = false;
                    meaningMessageLbl.Location = new Point(meaningMessageLbl.Location.X, initLocY);

                    meaningMessagePopped = false;
                }
            };

            meaningMessageLbl.Visible = true;
            t.Start();
        }

        // |Automatic alignment|
        private int inYLoc; //initial Y location
        private void termTB_LineCountChanged(object sender, EventArgs e)
        {
            termTB.Location = new Point(termTB.Location.X, inYLoc - (termTB.PreferredHeight + 1) / 2 * (termTB.LineCount() - 1));

        }
        private void meaningTB_LineCountChanged(object sender, EventArgs e)
        {
            meaningTB.Location = new Point(meaningTB.Location.X, inYLoc - (meaningTB.PreferredHeight + 1) / 2 * (meaningTB.LineCount() - 1));

        }


        // |Max line reached|
        private void termTB_MaxLineCountReached(object sender, EventArgs e)
        {
            termMessageLbl.Text = "Term is too long! ";

            if (!termMessagePopped)
                popTermMessage(2000);
        }

        private void meaningTB_MaxLineCountReached(object sender, EventArgs e)
        {
            meaningMessageLbl.Text = "Meaning is too long! ";

            if (!meaningMessagePopped)
                popMeaningMessage(2000);
        }

    }
}
 