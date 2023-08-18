using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OMA.FORMS
{
    public partial class Welcome : Form
    {

        public Welcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Register ventana = new Register();
            ventana.Show();
            this.Hide();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            
        }
    }
}
