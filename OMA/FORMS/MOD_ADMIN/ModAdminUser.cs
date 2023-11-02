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

namespace OMA.FORMS.MOD_ADMIN
{
    public partial class ModAdminUser : Form
    {
        public ModAdminUser()
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
            else if (mail.Text == Program.usernameMod)
            {
                MessageBox.Show("El nuevo usuario es igual al anterior, por favor ingrese uno nuevo o cierre la ventana");
            }
            else
            {
                MySqlCommand changeMail = new MySqlCommand("UPDATE users SET username = @mail WHERE mail = @oldMail", c.getConexion());

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
