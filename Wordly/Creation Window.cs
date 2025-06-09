using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

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


        
        private string separateWordSign = "-", separatePairSign = Environment.NewLine;

        public Creation_Window()
        {
            InitializeComponent();
            initTBsYLoc = termTB.Location.Y;
            initMsgLblsYLoc = termMessageLbl.Location.Y;



        }






        private void addWordPairBtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(termTB.Text))
            {
                PopTermMessage("Term is not entered! ", 2000);
            }
            else if (string.IsNullOrEmpty(meaningTB.Text))
            {
                PopMeaningMessage("Meaning is not entered! ", 2000);
            }

            else
            {
                for(int i = 0; i < termTB.Text.Length; i++)
                    if (termTB.Text[i] == '\n')
                    {
                        termTB.Text = termTB.Text.Substring(0, i - 1);
                        break;
                    }
                for (int i = 0; i < meaningTB.Text.Length; i++)
                    if (meaningTB.Text[i] == '\n')
                    {
                        meaningTB.Text = termTB.Text.Substring(0, i - 1);
                        break;
                    }


                if (!string.IsNullOrEmpty(inputTB.Text))
                    inputTB.Text += separatePairSign;

                inputTB.Text += termTB.Text + separateWordSign + meaningTB.Text;


                termTB.Text = string.Empty;
                meaningTB.Text = string.Empty;

            }
        }










        private int initMsgLblsYLoc;

        private System.Windows.Forms.Timer t1 = new();
        private void PopTermMessage(string message, int waitTime)
        {
            t1.Stop();


            termMessageLbl.Text = message;
            termMessageLbl.Location = new Point(termMessageLbl.Location.X, initMsgLblsYLoc); //to make sure
            termMessageLbl.Visible = true;
            this.Refresh(); //in order to fix the 'thread.sleep' glitching out
            termMessageLbl.Refresh(); //in order to fix autosize glitching out


            t1 = new();
            t1.Interval = waitTime; //in miliseconds
            t1.Tick += (object sender, EventArgs e) =>
            {
                t1.Stop();


                t1 = new();
                t1.Interval = 40; //starting speed
                t1.Tick += (object sender, EventArgs e) =>
                {
                    termMessageLbl.Location = new Point(termMessageLbl.Location.X, termMessageLbl.Location.Y + 2);
                    
                    if (t1.Interval >= 25) //max speed
                        t1.Interval -= 5; //acceleration

                    if (termMessageLbl.Location.Y >= 110)
                    {
                        t1.Stop();

                        termMessageLbl.Visible = false;
                        termMessageLbl.Location = new Point(termMessageLbl.Location.X, initMsgLblsYLoc);
                    }
                };

                termMessageLbl.Visible = true;
                t1.Start();
            };
            t1.Start();
        }

        private System.Windows.Forms.Timer t2 = new();
        public void PopMeaningMessage(string message, int waitTime)
        {
            t2.Stop();

            meaningMessageLbl.Location = new Point(meaningMessageLbl.Location.X, initMsgLblsYLoc);
            meaningMessageLbl.Visible = true;
            this.Refresh(); //in order to fix the 'thread.sleep' glitching out
            meaningMessageLbl.Refresh(); //in order to fix autosize glitching out


            t2 = new();
            t2.Interval = waitTime; //in miliseconds
            t2.Tick += (object sender, EventArgs e) =>
            {
                t2.Stop();


                t2 = new();
                t2.Interval = 40; //starting speed
                t2.Tick += (object sender, EventArgs e) =>
                {
                    meaningMessageLbl.Location = new Point(meaningMessageLbl.Location.X, meaningMessageLbl.Location.Y + 2);

                    if (t2.Interval >= 25) //max speed
                        t2.Interval -= 5; //acceleration

                    if (meaningMessageLbl.Location.Y >= 110)
                    {
                        t2.Stop();

                        meaningMessageLbl.Visible = false;
                        meaningMessageLbl.Location = new Point(meaningMessageLbl.Location.X, initMsgLblsYLoc);
                    }
                };

                meaningMessageLbl.Visible = true;
                t2.Start();
            };
            t2.Start();
        }
        




        // |Automatic alignment|
        private int initTBsYLoc; //initial Y location
        private void termTB_LineCountChanged(object sender, EventArgs e)
        {
            termTB.Location = new Point(termTB.Location.X, initTBsYLoc - (termTB.PreferredHeight + 1) / 2 * (termTB.LineCount() - 1));

        }
        private void meaningTB_LineCountChanged(object sender, EventArgs e)
        {
            meaningTB.Location = new Point(meaningTB.Location.X, initTBsYLoc - (meaningTB.PreferredHeight + 1) / 2 * (meaningTB.LineCount() - 1));

        }


        // |Max line reached|
        private void termTB_MaxLineCountReached(object sender, EventArgs e)
        {
            PopTermMessage("Term is too long! ", 2000);
        }

        private void meaningTB_MaxLineCountReached(object sender, EventArgs e)
        {
            PopMeaningMessage("Meaning is too long! ", 2000);            
        }

    }
}
 