using System.Windows.Forms;

namespace Wordly
{
    public partial class Creation_Window : Form
    {
        public Creation_Window()
        {
            InitializeComponent();
            inYLoc = termTB.Location.Y;

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

        private void termTB_MaxLineCountReached(object sender, EventArgs e)
        {
            termTB.MaxLineCountReached -= termTB_MaxLineCountReached;

            termMaxLntLbl.Visible = true;
            this.Refresh(); //in order to fix the 'thread.sleep' glitching out

            Thread.Sleep(2000);

            int initLocY = termMaxLntLbl.Location.Y;

            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Interval = 40; //starting speed
            t.Tick += (object sender, EventArgs e) =>
            {
                termMaxLntLbl.Location = new Point(termMaxLntLbl.Location.X, termMaxLntLbl.Location.Y + 2);
                
                if(t.Interval >= 25) //max speed
                    t.Interval -= 5; //acceleration

                if (termMaxLntLbl.Location.Y >= 110)
                {
                    t.Stop();

                    termMaxLntLbl.Visible = false;
                    termMaxLntLbl.Location = new Point(termMaxLntLbl.Location.X, initLocY);

                    termTB.MaxLineCountReached += termTB_MaxLineCountReached;
                }
            };

            termMaxLntLbl.Visible = true;
            t.Start();
        }


        private void meaningTB_MaxLineCountReached(object sender, EventArgs e)
        {
            meaningTB.MaxLineCountReached -= meaningTB_MaxLineCountReached;

            meaningMaxLntLbl.Visible = true;
            this.Refresh(); //in order to fix the 'thread.sleep' glitching out

            Thread.Sleep(2000);

            int initLocY = meaningMaxLntLbl.Location.Y;

            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Interval = 40; //starting speed
            t.Tick += (object sender, EventArgs e) =>
            {
                meaningMaxLntLbl.Location = new Point(meaningMaxLntLbl.Location.X, meaningMaxLntLbl.Location.Y + 2);

                if (t.Interval >= 25) //max speed
                    t.Interval -= 5; //acceleration

                if (meaningMaxLntLbl.Location.Y >= 110)
                {
                    t.Stop();

                    meaningMaxLntLbl.Visible = false;
                    meaningMaxLntLbl.Location = new Point(meaningMaxLntLbl.Location.X, initLocY);

                    meaningTB.MaxLineCountReached += meaningTB_MaxLineCountReached;
                }
            };

            meaningMaxLntLbl.Visible = true;
            t.Start();
        }
    }
}
 