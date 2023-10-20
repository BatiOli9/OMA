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
    public partial class ChangeUser : Form
    {
        public ChangeUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            if (oldPass.Text == "" || newPass.Text == "" || confPass.Text == "" || oldPass.Text != Program.username || newPass.Text != confPass.Text)
            {
                MessageBox.Show("Debes completar el formulario correctamente");
            }
            else
            {
                Program.username = newPass.Text;
                MySqlCommand changePass = new MySqlCommand("UPDATE `users` SET `username` = @newUsername WHERE mail = @mail", c.getConexion());

                changePass.Parameters.AddWithValue("@newUsername", newPass.Text);
                changePass.Parameters.AddWithValue("@mail", Program.mail);

                int rowsAffected = changePass.ExecuteNonQuery();

                MessageBox.Show("Usuario cambiado exitosamente, no olvides refrescar");

                this.Hide();
            }
        }
    }
}
