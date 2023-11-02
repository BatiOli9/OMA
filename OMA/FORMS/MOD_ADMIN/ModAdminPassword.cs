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
using System.Text.RegularExpressions;

namespace OMA.FORMS.MOD_ADMIN
{
    public partial class ModAdminPassword : Form
    {
        public ModAdminPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            if (mail.Text == "")
            {
                MessageBox.Show("Debes completar el puerto de usuario");
            }
            else if (mail.Text == Program.passwordMod)
            {
                MessageBox.Show("La nueva contrasñea es igual al anterior, por favor ingrese una nueva o cierre la ventana");
            }
            else if (mail.TextLength < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(mail.Text, @"(?=.*[A-Z])(?=.*\d)"))
            {
                MessageBox.Show("La contraseña debe tener al menos un número y una letra mayúscula");
            }
            else
            {
                MySqlCommand changeMail = new MySqlCommand("UPDATE users SET password = @mail WHERE mail = @oldMail", c.getConexion());

                changeMail.Parameters.AddWithValue("@mail", mail.Text);
                changeMail.Parameters.AddWithValue("@oldMail", Program.mailMod);

                int rowsAffected = changeMail.ExecuteNonQuery();

                Program.admin = "yes";

                MessageBox.Show("Modificacion completada");

                AdminUserControl ventana = new AdminUserControl();
                ventana.Hide();
                ventana.Show();
            }
        }
    }
}
