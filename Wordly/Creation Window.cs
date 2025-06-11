using Newtonsoft.Json;
using System.Diagnostics;
namespace Wordly
{
    public partial class Creation_Window : Form
    {

        public class WordList
        {
            public string name;
            public int count;
            public string termLanguage;
            public string meaningLanguage;

            public List<string[]> Term;
            public List<string[]> Meaning;

        }
        public static WordList wl;


        private char wordSign = '-', pairSign = '\n';// !!!! = Environment.NewLine;

        public Creation_Window()
        {
            InitializeComponent();
            inputTB.perHeightAddition = -1;
            inputTB.initHeightAddition = 6;
            wordSignCB.SelectedIndex = 2;
            pairSignCB.SelectedIndex = 6;

            initTBsYLoc = termTB.Location.Y;
            initMsgLblsYLoc = termMessageLbl.Location.Y;


            wl = new WordList();

            UpdateTable();
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
                termTB.Text = RemoveNewLines_TBStyle(termTB.Text);
                meaningTB.Text = RemoveNewLines_TBStyle(meaningTB.Text);


                if (!string.IsNullOrEmpty(inputTB.Text))
                    if (pairSign == '\n')
                        inputTB.Text += Environment.NewLine;
                    else
                        inputTB.Text += pairSign;

                inputTB.Text += termTB.Text + wordSign + meaningTB.Text;


                termTB.Text = string.Empty;
                meaningTB.Text = string.Empty;

            }
        }



        private void createListBtn_Click(object sender, EventArgs e)
        {
            bool createList = true;
            if (string.IsNullOrEmpty(nameTB.Text))
            {
                nameTB.BorderWidth = 5;
                createList = false;
            }
            if (string.IsNullOrEmpty(inputTB.Text))
            {
                inputTB.PlaceholderText = "You have not entered any words!";
                createList = false;
            }

            if (createList)
            {
                PerformWordListCreation();
            }

        }


        private void PerformWordListCreation()
        {
            UpdateWordList();

            string s = new FileInfo("Word Lists").FullName;

            File.WriteAllText(s + "\\" + nameTB.Text + ".json", JsonConvert.SerializeObject(wl));

        }

        private void UpdateWordList()
        {
            int n = GetNumberOfPairs();

            wl.Term = new List<string[]>(n);
            wl.Meaning = new List<string[]>(n);


            int j;
            string text = inputTB.Text;
            for (int i = 0; i < n; i++)
            {
                string[] termTemp = new string[1];
                string[] meaningTemp = new string[1];


                j = 0;
                while (true)
                {
                    if (text[j] == wordSign)
                    {
                        termTemp[0] = RemoveNewLines_TBStyle(text.Substring(0, j));
                        text = text.Substring(j + 1);


                        break;
                    }

                    j++;
                }

                j = 0;
                while (true)
                {
                    if (text[j] == pairSign)
                    {
                        if (pairSign == '\n')
                        {
                            meaningTemp[0] = text.Substring(0, j - 1);
                        }
                        else
                        {
                            meaningTemp[0] = RemoveNewLines_TBStyle(text.Substring(0, j));
                        }
                        text = text.Substring(j + 1);

                        break;
                    }

                    j++;

                    if (j >= text.Length)
                    {
                        meaningTemp[0] = RemoveNewLines_TBStyle(text);
                        text = string.Empty;

                        break;
                    }
                }


                wl.Term.Add(termTemp);
                wl.Meaning.Add(meaningTemp);
            }


            wl.name = nameTB.Text;
            wl.count = n;
            //wl.termLanguage
            if (termLanguageCB.SelectedItem == null)
                wl.termLanguage = "unknown";
            else
                wl.termLanguage = termLanguageCB.Text;
            //wl.meaningLanguage
            if (meaningLanguageCB.SelectedItem == null)
                wl.meaningLanguage = "unknown";
            else
                wl.meaningLanguage = meaningLanguageCB.Text;


        }

        private int GetNumberOfPairs()
        {
            int n = 0, i = 0;
            while (i < inputTB.Text.Length)
            {
                if (inputTB.Text[i] == wordSign)
                    n++;
                i++;
            }
            return n;
        }


        private void UpdateTable()
        {
            int tempASPy = this.AutoScrollPosition.Y;


            UpdateWordList();
            int n = GetNumberOfPairs();

            if (tablePnl.Controls.Count != 0 && tablePnl.Controls[0].ForeColor == Color.Gray)
                tablePnl.Controls.Clear();

            int initControlCount = tablePnl.Controls.Count;
            if (n > tablePnl.Controls.Count / 2)
            {
                for (int i = 0; i < n - initControlCount / 2; i++)
                {
                    AddTablePair();
                }
            }
            else if (n < tablePnl.Controls.Count / 2)
            {
                for (int i = 0; i < initControlCount / 2 - n; i++)
                {
                    RemoveTablePair();
                }
            }


            if (n == 0)
            {
                AddTablePair();
                tablePnl.Controls[0].Text = "Term";
                tablePnl.Controls[0].Font = new Font("Segoe UI", 15F, FontStyle.Italic);
                tablePnl.Controls[0].ForeColor = Color.Gray;
                tablePnl.Controls[1].Text = "Meaning";
                tablePnl.Controls[1].Font = new Font("Segoe UI", 15F, FontStyle.Italic);
                tablePnl.Controls[1].ForeColor = Color.Gray;
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    tablePnl.Controls[i * 2].Text = wl.Term[i][0];
                    tablePnl.Controls[i * 2 + 1].Text = wl.Meaning[i][0];
                }
            }

            tablePnl.Height = tablePnl.Controls.Count / 2 * tableLabelHeight;


            this.AutoScrollPosition = new Point(0, -tempASPy);
        }

        private void AddTablePair()
        {
            tablePnl.Controls.Add(TableLabel((tablePnl.Controls.Count / 2) * tableLabelHeight, true));
            tablePnl.Controls.Add(TableLabel((tablePnl.Controls.Count / 2) * tableLabelHeight, false));
        }
        private void RemoveTablePair()
        {
            tablePnl.Controls.RemoveAt(tablePnl.Controls.Count - 1);
            tablePnl.Controls.RemoveAt(tablePnl.Controls.Count - 1);
        }

        private int tableLabelHeight = 30;
        private Label TableLabel(int y, bool isLeft)
        {
            Label lbl = new Label();
            lbl.BorderStyle = BorderStyle.FixedSingle;
            lbl.Font = new Font("Segoe UI", 15F);
            lbl.Location = new Point(450 * Convert.ToInt32(!isLeft), y);
            lbl.Size = new Size(450 + Convert.ToInt32(isLeft), tableLabelHeight);
            lbl.ForeColor = Color.White;

            return lbl;
        }




























        private string RemoveNewLines_TBStyle(string s)
        {
            for (int i = 0; i < s.Length; i++)
                if (s[i] == '\n')
                    return s.Substring(0, i - 1);

            return s;
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

        private void inputTB_SizeChanged(object sender, EventArgs e)
        {
            if (inputTB.Size.Height < inputTBPnl.Size.Height)
                inputTB.Size = new Size(inputTB.Size.Width, inputTBPnl.Size.Height);
        }

        private void wordSignCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (wordSignCB.SelectedIndex == pairSignCB.SelectedIndex)
            {
                wordSignCB.SelectedIndex = 2;
                pairSignCB.SelectedIndex = 6;
            }
            else if (wordSignCB.SelectedItem.ToString() == "Enter")
                wordSign = '\n';
            else
                wordSign = wordSignCB.SelectedItem.ToString()[0];
        }

        private void pairSignCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (wordSignCB.SelectedIndex == pairSignCB.SelectedIndex)
            {
                label4.Text = "cannot";
                wordSignCB.SelectedIndex = 2;
                pairSignCB.SelectedIndex = 6;
            }
            else if (pairSignCB.SelectedItem.ToString() == "Enter")
                pairSign = '\n';
            else
                pairSign = pairSignCB.SelectedItem.ToString()[0];

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }
    }
}
 