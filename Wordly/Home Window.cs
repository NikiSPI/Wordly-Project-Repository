using Microsoft.Web.WebView2.WinForms;
namespace Wordly
{
    public partial class Home_Window : Form
    {
        WebView2 webView;
        public Home_Window()
        {
            InitializeComponent();
        }

        private void Home_Window_Load(object sender, EventArgs e)
        {

            this.BeginInvoke((MethodInvoker)delegate
            {
                backPnl.AutoScrollPosition = new Point(0, 0);
            });
        }
    }
}
