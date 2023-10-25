using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;

namespace OMA.FORMS
{
    public partial class AdminUserControl : Form
    {
        public AdminUserControl()
        {
            InitializeComponent();
        }

        private void OMA_Click(object sender, EventArgs e)
        {
            Index ventana = new Index();
            ventana.Show();
            this.Hide();
        }

        private void account_Click(object sender, EventArgs e)
        {
            User ventana = new User();
            ventana.Show();
            this.Hide();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            Welcome ventana = new Welcome();
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

        private void btnControl_Click(object sender, EventArgs e)
        {
            AdminPanel ventana = new AdminPanel();
            ventana.Show();
            this.Hide();
        }

        public class Usuario
        {
            public int id;
            public string nombre;
            public decimal mail;
            public string username;
            public string password;
            public string admin;
        }

        private void AdminUserControl_Load(object sender, EventArgs e)
        {
            if (Program.admin != "yes")
            {
                MessageBox.Show("No tenes jerarquia para entrar aca", "Error");
                Index ventana = new Index();
                ventana.Show();
                this.Hide();
            }
            else
            {
                Conexion c = new Conexion();
                List<Usuario> usuarios = new List<Usuario>();

                c.getConexion();

                MySqlCommand usuariosCommand = new MySqlCommand("SELECT * FROM users", c.getConexion());

                MySqlDataReader resultados = usuariosCommand.ExecuteReader();

                while (resultados.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.id = resultados.GetInt32(0);
                    // usuario.mail = resultados.GetString(1);
                    usuario.password = resultados.GetString(2);
                    usuario.username = resultados.GetString(3);
                    usuario.admin = resultados.GetString(4);
                    usuarios.Add(usuario);
                }

                foreach (Usuario usuario in usuarios)
                {
                    string adminProp;
                    if (usuario.admin == "1")
                    {
                        adminProp = "Administrador";
                    }
                    else
                    {
                        adminProp = "Usuario";
                    }

                    UserAdminControl udc = new UserAdminControl();

                    udc.Nombre = usuario.username;
                    udc.Jerarquia = adminProp;
                    udc.Contraseña = usuario.password;

                    flowLayoutPanel1.Controls.Add(udc);

                    Thread.Sleep(10);

                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
