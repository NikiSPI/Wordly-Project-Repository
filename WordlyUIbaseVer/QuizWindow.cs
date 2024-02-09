using Newtonsoft.Json;
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
    public partial class QuizWindow : Form
    {
        private class WordList
        {
            public List<string[]> Term;
            public List<string[]> Meaning;
        }

        private static string folderDir = WordlyForm.projectFolderDir + @"\Word Lists\";

        private WordList wl = JsonConvert.DeserializeObject<WordList>(File.ReadAllText(folderDir + "ABC" + ".json"));


        public QuizWindow()
        {
            InitializeComponent();

            for(int i = 0; i < wl.Term.Count; i++)
            {
                WordPnl wp = new WordPnl(10 + i * 90);
                wp.wordTermLbl.Text = wl.Term[i][0];
                wp.wordMeaningLbl.Text = wl.Meaning[i][0];

                wordContainerPnl.Controls.Add(wp);
            }


        }

        public class WordPnl : Panel
        {
            public Label wordTermLbl = new Label();
            public Label wordMeaningLbl = new Label();

            public WordPnl(int yLoc)
            {
                // 
                // wordSamplePnl
                // 
                Anchor = AnchorStyles.Top | AnchorStyles.Left;
                BackColor = SystemColors.GradientActiveCaption;
                Controls.Add(wordTermLbl);
                Controls.Add(wordMeaningLbl);
                Location = new Point(10, yLoc);
                Name = "wordSamplePnl";
                Size = new Size(480, 80);
                TabIndex = 0;
                // 
                // wordTermLbl
                // 
                wordTermLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                wordTermLbl.BackColor = Color.PowderBlue;
                wordTermLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
                wordTermLbl.Location = new Point(10, 10);
                wordTermLbl.Name = "wordTermLbl";
                wordTermLbl.Size = new Size(225, 60);
                wordTermLbl.TabIndex = 0;
                wordTermLbl.Text = "word 1";
                wordTermLbl.TextAlign = ContentAlignment.MiddleCenter;
                // 
                // wordMeaningLbl
                // 
                wordMeaningLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                wordMeaningLbl.BackColor = Color.PowderBlue;
                wordMeaningLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
                wordMeaningLbl.Location = new Point(245, 10);
                wordMeaningLbl.Name = "wordMeaningLbl";
                wordMeaningLbl.Size = new Size(225, 60);
                wordMeaningLbl.TabIndex = 1;
                wordMeaningLbl.Text = "word 2";
                wordMeaningLbl.TextAlign = ContentAlignment.MiddleCenter;
            }
        }
    }
}
