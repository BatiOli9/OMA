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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Index ventana = new Index();
            ventana.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Productos ventana = new Productos();
            ventana.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Regulacion ventana = new Regulacion();
            ventana.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

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

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Ecommerce ventana = new Ecommerce();
            ventana.Show();
        }

        private void Productos_Load(object sender, EventArgs e)
        {

        }
    }
}
