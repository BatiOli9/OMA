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
using MySql.Data.MySqlClient;

namespace OMA.FORMS
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Welcome ventana = new Welcome();
            ventana.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Conexion c = new Conexion(); ;

            if (tbUser.Text == "" || tbPass.Text == "" || tbMail.Text == "" || tbPassConf.Text == "")
            {
                MessageBox.Show("Tenes que completar todos los campos para poder registrarte", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbUser.Clear();
                tbPass.Clear();
                tbMail.Clear();
            }
            else
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO `users`(`mail`, `password`, `username`) VALUES (@mail, @pass, @user)", c.getConexion());

                command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = tbMail.Text;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = tbPass.Text;
                command.Parameters.Add("@user", MySqlDbType.VarChar).Value = tbUser.Text;

                c.getConexion();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Cuenta creada correctamente. Iniciar Sesion.");
                }
                else
                {
                    MessageBox.Show("No se pudo crear la cuenta correctamente");
                }

                c.closeConexion();
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

        private void button2_Click(object sender, EventArgs e)
        {
            Welcome ventana = new Welcome();
            ventana.Show();
            this.Hide();
        }
    }
}