using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMA.FORMS
{
    public partial class Ecommerce : Form
    {

        private WebBrowser WebBrowser;
        public Ecommerce()
        {
            InitializeComponent();

            WebBrowser = new WebBrowser();

            this.Controls.Add(WebBrowser);

            WebBrowser.Size = new System.Drawing.Size(800, 600);
            WebBrowser.Location = new System.Drawing.Point(10, 10);

            WebBrowser.Navigate("https://https://shoter.net");
        }
    }
}
