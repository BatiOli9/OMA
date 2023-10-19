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

            MessageBox.Show(Program.mail);

            correoUser.Text = mail;
            nameUser.Text = username;
        }
        private void User_Load(object sender, EventArgs e)
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
    }
}
