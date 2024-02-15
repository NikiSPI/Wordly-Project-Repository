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
    public partial class ChooseListForm : Form
    {

        public static Panel contentPnl;
        public QuizWindow quizWindow;

        public ChooseListForm()
        {
            InitializeComponent();

            InitializeFunctions();

        }
        public void InitializeFunctions()
        {
            CreateContentPnl();

            DirectoryInfo d = new DirectoryInfo(WordlyForm.projectFolderDir + @"\Word Lists\"); //Assuming this is your Folder
            FileInfo[] files = d.GetFiles(); //Getting files

            for (int i = 0; i < 4; i++)
            {
                WordListBtn btn = new WordListBtn(10 + 100 * i, files[i].Name);
                contentPnl.Controls.Add(btn);

                string filePath = files[i].FullName;
                btn.Click += (sender, EventArgs) => { Button_Click(sender, EventArgs, filePath); };
            }

        }
        private void CreateContentPnl()
        {
            // 
            // contentPnl
            // 
            contentPnl = new Panel();
            contentPnl.AutoScroll = true;
            contentPnl.BackColor = SystemColors.ControlLight;
            contentPnl.Dock = DockStyle.Fill;
            contentPnl.Location = new Point(0, 0);
            contentPnl.Name = "contentPnl";
            contentPnl.Size = new Size(800, 600);
            contentPnl.TabIndex = 0;
            Controls.Add(contentPnl);
        }


        private void Button_Click(object sender, EventArgs e, string listFileName)
        {
            WordlyForm.stepsToUndo = 1;

            quizWindow = new QuizWindow(listFileName);
            quizWindow.Dock = DockStyle.Fill;
            quizWindow.TopLevel = false;
            quizWindow.TopMost = true;
            quizWindow.FormBorderStyle = FormBorderStyle.None;

            contentPnl.Controls.Clear();
            contentPnl.Controls.Add(quizWindow);
            quizWindow.Show();
        }


        private class WordListBtn: Button
        {
            public WordListBtn(int yPos, string name)
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                BackColor = Color.Wheat;
                FlatAppearance.BorderSize = 0;
                FlatStyle = FlatStyle.Flat;
                Font = new Font("Yu Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
                Location = new Point(10, yPos);
                Name = "wordListBtn";
                Size = new Size(780, 90);
                TabIndex = 5;
                Text = name.Substring(0, name.Length - 5);
                UseVisualStyleBackColor = false;
            }
        }
    }
}