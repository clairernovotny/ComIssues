using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEControl;

namespace NetCoreTestApp
{
    public partial class Form1 : Form
    {
        HtmlControl html;
        public Form1()
        {
            
            InitializeComponent();

            html = new HtmlControl();
            html.Dock = DockStyle.Fill;
            html.Size = new Size(300, 300);

            Controls.Clear();
            Controls.Add(html);
            Controls.Add(buttonExit);



            html.CommandStateChanged += HtmlOnCommandStateChanged;

            HtmlControl.SetInternetFeatureEnabled(
                InternetFeatureList.FEATURE_TABBED_BROWSING,
                SetFeatureFlag.SET_FEATURE_ON_PROCESS, true);
        }

        void HtmlOnCommandStateChanged(object sender, BrowserCommandStateChangeEvent e)
        {

            var state = e.command;

        }

        

        private void buttonExit_Click(object sender, EventArgs e)
        {
            html.Navigate("https://www.bing.com");
        }
    }
}
