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
    public partial class Regulacion : Form
    {
        public Regulacion()
        {
            InitializeComponent();
        }

        private void prender_Click(object sender, EventArgs e)
        {
            if (prender.BackColor == Color.Lime)
            {
                prender.BackColor = Color.Red;
                prender.ForeColor = Color.White;
            }
            else if (prender.BackColor == Color.Red)
            {
                prender.BackColor = Color.Lime;
                prender.ForeColor = Color.Black;
            }
        }

        private void OMA_Click(object sender, EventArgs e)
        {
            Index ventana = new Index();
            ventana.Show();
            this.Hide();
        }

        private void regulation_Click(object sender, EventArgs e)
        {
            Regulacion ventana = new Regulacion();
            ventana.Show();
            this.Hide();
        }

        private void shop_Click(object sender, EventArgs e)
        {
            Productos ventana = new Productos();
            ventana.Show();
            this.Hide();
        }
    }
}
