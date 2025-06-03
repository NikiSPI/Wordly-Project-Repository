using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
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
    }
}
