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
    public partial class UserAdminControl : UserControl
    {
        [Category("Custom Props")]
        private string _nombre;
        private string _mail;
        private string _contraseña;
        private string _jerarquia;

        [Category("Custom Props")]
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; nombre.Text = value; }
        }
        [Category("Custom Props")]
        public string Mail
        {
            get { return _mail; }
            set { _mail = value; mail.Text = value; }
        }
        [Category("Custom Props")]
        public string Contraseña
        {
            get { return _contraseña; }
            set { _contraseña = value; contraseña.Text = value; }
        }
        [Category("Custom Props")]
        public string Jerarquia
        {
            get { return _jerarquia; }
            set { _jerarquia = value; jerarquia.Text = value; }
        }
        public UserAdminControl()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           if (jerarquia.Text == "Administrador")
            {
                Program.admin = "1";
            }
           else
            {
                Program.admin = "0";
            }

            Program.passwordMod = contraseña.Text;
            Program.usernameMod = nombre.Text;
            Program.mailMod = mail.Text;

            MOD_ADMIN.ModUsers ventana = new MOD_ADMIN.ModUsers();
            ventana.Show();
        }
    }
}
