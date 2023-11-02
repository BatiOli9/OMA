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
using MySql.Data.MySqlClient;

namespace OMA.FORMS.MOD_ADMIN
{
    public partial class ModAdminMail : Form
    {
        public ModAdminMail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            if (mail.Text == "")
            {
                MessageBox.Show("Debes completar el puerto de mail");
            }
            else if (mail.Text == Program.mailMod)
            {
                MessageBox.Show("El nuevo mail es igual al anterior, por favor ingrese uno nuevo o cierre la ventana");
            }
            else if (!Regex.IsMatch(mail.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                MessageBox.Show("El correo electrónico ingresado no tiene la estructura correcta.");
            }
            else
            {
                MySqlCommand changeMail = new MySqlCommand("UPDATE users SET mail = @mail WHERE mail = @oldMail", c.getConexion());

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
