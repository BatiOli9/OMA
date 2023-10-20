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
    public partial class ChangeMail : Form
    {
        public ChangeMail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            if (oldPass.Text == "" || newPass.Text == "" || confPass.Text == "" || oldPass.Text != Program.mail || newPass.Text != confPass.Text)
            {
                MessageBox.Show("Debes completar el formulario correctamente");
            }
            else
            {
                Program.mail = newPass.Text;
                MySqlCommand changePass = new MySqlCommand("UPDATE `users` SET `username` = @newMail WHERE mail = @username", c.getConexion());

                changePass.Parameters.AddWithValue("@newMail", newPass.Text);
                changePass.Parameters.AddWithValue("@username", Program.username);

                int rowsAffected = changePass.ExecuteNonQuery();

                MessageBox.Show("Mail cambiado exitosamente, no olvides refrescar");

                this.Hide();
            }
        }
    }
}
