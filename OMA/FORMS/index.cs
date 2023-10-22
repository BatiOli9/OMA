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
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            if (Program.admin == "yes")
            {
                MessageBox.Show("Bienvenido Administrador");
                adminLbl.Text = "Usuario Administrador";
                btnControl.Show();
            }
            else
            {
                adminLbl.Text = "";
                btnControl.Hide();
            }
        }


        private void shopButton_Click(object sender, EventArgs e)
        {
            Productos ventana = new Productos();
            ventana.Show();
            this.Hide();
        }

        private void shopButtonInterface_Click(object sender, EventArgs e)
        {
            Productos ventana = new Productos();
            ventana.Show();
            this.Hide();
        }

        private void shop_Click(object sender, EventArgs e)
        {
            Productos ventana = new Productos();
            ventana.Show();
            this.Hide();
        }

        private void OMA_Click(object sender, EventArgs e)
        {
            // Index ventana = new Index();
            // ventana.Show();
            // this.Hide();
        }

        private void regulation_Click(object sender, EventArgs e)
        {
            Regulacion ventana = new Regulacion();
            ventana.Show();
            this.Hide();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void account_Click(object sender, EventArgs e)
        {
            User ventana = new User();
            ventana.Show();
            this.Hide();
        }

        private void adminLbl_Click(object sender, EventArgs e)
        {

        }

        private void settings_Click(object sender, EventArgs e)
        {
            Welcome ventana = new Welcome();
            ventana.Show();
            this.Hide();
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            AdminPanel panel = new AdminPanel();
            panel.Show();
            this.Hide();
        }
    }
}