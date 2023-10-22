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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();

            string username = Program.username;
            string password = Program.password;
            string mail = Program.mail;
            string admin = Program.admin;

            correoUser.Text = mail;
            nameUser.Text = username;

            if (Program.admin == "yes")
            {
                adminLbl.Text = "Usuario Administrador";
                btnControl.Show();
                adminPanel.Show();
            }
            else
            {
                adminPanel.Hide();
                adminLbl.Text = "";
                btnControl.Hide();
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

        private void account_Click(object sender, EventArgs e)
        {
            User ventana = new User();
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

        private void button3_Click(object sender, EventArgs e)
        {
            ChangePass ventana = new ChangePass();
            ventana.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeUser ventana = new ChangeUser();
            ventana.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            User ventana = new User();
            ventana.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeMail ventana = new ChangeMail();
            ventana.Show();
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

        private void adminPanel_Click(object sender, EventArgs e)
        {
            AdminPanel panel = new AdminPanel();
            panel.Show();
            this.Hide();
        }
    }
}
