using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
namespace OMA.FORMS
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            tbPass.PasswordChar = '*';
            tbPassConf.PasswordChar = '*';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Welcome ventana = new Welcome();
            ventana.Show();
            this.Hide();
        }

        int ultimoNumeroId;
        int ultimaFila;

        private void button1_Click(object sender, EventArgs e)
        {

            Conexion c = new Conexion();

            if (tbUser.Text == "" || tbPass.Text == "" || tbMail.Text == "" || tbPassConf.Text == "")
            {
                MessageBox.Show("Tenes que completar todos los campos para poder registrarte", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbUser.Clear();
                tbPass.Clear();
                tbMail.Clear();
            }
            else if (tbPass.TextLength < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbPass.Text != tbPassConf.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(tbPass.Text, @"(?=.*[A-Z])(?=.*\d)") || !Regex.IsMatch(tbPassConf.Text, @"(?=.*[A-Z])(?=.*\d)"))
            {
                MessageBox.Show("La contraseña debe tener al menos un número y una letra mayúscula");
            }
            else
            {
                MySqlCommand idComand = new MySqlCommand("SELECT MAX(`id`) FROM `users`", c.getConexion());
                object lastId = idComand.ExecuteScalar();
                if (lastId != DBNull.Value)
                {
                    ultimoNumeroId = Convert.ToInt32(lastId);
                }

                MySqlCommand rowComand = new MySqlCommand("SELECT COUNT(*) FROM `users`", c.getConexion());
                object lastRow = rowComand.ExecuteScalar();
                if (lastRow != DBNull.Value)
                {
                    ultimaFila = Convert.ToInt32(lastRow);
                }

                int id = ultimoNumeroId + 1;

                int row = ultimaFila + 1;

                MySqlCommand command = new MySqlCommand("INSERT INTO `users`(`id`, `mail`, `password`, `username`, `admin`) VALUES (@id, @mail, @pass, @user, @admin)", c.getConexion());

                command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = tbMail.Text;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = tbPass.Text;
                command.Parameters.Add("@user", MySqlDbType.VarChar).Value = tbUser.Text;
                command.Parameters.Add("@admin", MySqlDbType.Int32).Value = 0;

                c.getConexion();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Cuenta creada correctamente. Iniciar Sesion.","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Welcome ventana = new Welcome();
                    ventana.Show();
                    this.Hide();
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

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (tbPass.PasswordChar == '*')
            {
                tbPass.PasswordChar = '\0'; // Mostrar texto de la contraseña
            }
            else
            {
                tbPass.PasswordChar = '*'; // Ocultar la contraseña nuevamente
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            if (tbPassConf.PasswordChar == '*')
            {
                tbPassConf.PasswordChar = '\0'; // Mostrar texto de la contraseña
            }
            else
            {
                tbPassConf.PasswordChar = '*'; // Ocultar la contraseña nuevamente
            }
        }
    }
}