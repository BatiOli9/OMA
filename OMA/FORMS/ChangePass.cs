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

namespace OMA.FORMS
{
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();

            newPass.PasswordChar = '*';
            oldPass.PasswordChar = '*';
            confPass.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            if (oldPass.Text == "" || newPass.Text == "" || confPass.Text == "" || oldPass.Text != Program.password || newPass.Text != confPass.Text)
            {
                MessageBox.Show("Debes completar el formulario correctamente");
            }
            else
            {
                Program.password = newPass.Text;
                MySqlCommand changePass = new MySqlCommand("UPDATE `users` SET `password` = @newPassword WHERE mail = @mail", c.getConexion());

                changePass.Parameters.AddWithValue("@newPassword", newPass.Text);
                changePass.Parameters.AddWithValue("@mail", Program.mail);

                int rowsAffected = changePass.ExecuteNonQuery();

                MessageBox.Show("Contraseña cambiada exitosamente");

                this.Hide();
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (oldPass.PasswordChar == '*')
            {
                oldPass.PasswordChar = '\0'; // Mostrar texto de la contraseña
            }
            else
            {
                oldPass.PasswordChar = '*'; // Ocultar la contraseña nuevamente
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (newPass.PasswordChar == '*')
            {
                newPass.PasswordChar = '\0'; // Mostrar texto de la contraseña
            }
            else
            {
                newPass.PasswordChar = '*'; // Ocultar la contraseña nuevamente
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (confPass.PasswordChar == '*')
            {
                confPass.PasswordChar = '\0'; // Mostrar texto de la contraseña
            }
            else
            {
                confPass.PasswordChar = '*'; // Ocultar la contraseña nuevamente
            }
        }
    }
}
