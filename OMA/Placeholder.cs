using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OMA
{
    class Placeholder:TextBox
    {

        private string placeHolder;
        [Description("Texto para el placeholder")]
        [Category("Placeholder")]

        public string Place
        {
            get { return Place; }   
            set { Place = value; }
        }

        private void txt_Enter( object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt.Text == Place)
            {
                txt.Text = string.Empty;
                txt.ForeColor = Color.Black;
            }
        }
    }
}
