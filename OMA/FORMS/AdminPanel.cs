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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void shop_Click(object sender, EventArgs e)
        {
            Productos ventana = new Productos();
            ventana.Show();
            this.Hide();
        }

        private void regulation_Click(object sender, EventArgs e)
        {
            Regulacion ventana = new Regulacion();
            ventana.Show();
            this.Hide();
        }

        private void OMA_Click(object sender, EventArgs e)
        {
            Index index = new Index();
            index.Show();
            this.Hide();
        }

        private void account_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
            this.Hide();
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

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            if (Program.admin != "yes")
            {
                MessageBox.Show("No tenes jerarquia para entrar aca", "Error");
                Index ventana = new Index();
                ventana.Show();
                this.Hide();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdminUserControl ventana = new AdminUserControl();
            ventana.Show();
            this.Hide();
        }
    }
}
