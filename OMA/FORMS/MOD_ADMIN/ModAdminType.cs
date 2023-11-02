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
    public partial class ModAdminType : Form
    {
        public ModAdminType()
        {
            InitializeComponent();
        }

        private void ModAdminType_LocationChanged(object sender, EventArgs e)
        {

        }

        private void ModAdminType_Load(object sender, EventArgs e)
        {
        }

        int opcionSeleccionada;

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            if (!adm.Checked && !usr.Checked)
            {
                MessageBox.Show("Debes elegir una opcion");
            }
            else if (adm.Checked)
            {
                opcionSeleccionada = 1;
            }
            else if (usr.Checked)
            {
                opcionSeleccionada = 0;
            }
            else
            {
                MessageBox.Show("Hola" + opcionSeleccionada);
                MySqlCommand changeAdmin = new MySqlCommand("UPDATE users SET admin = @admin WHERE mail = @mail", c.getConexion());

                changeAdmin.Parameters.AddWithValue("@admin", opcionSeleccionada);
                changeAdmin.Parameters.AddWithValue("@mail", Program.mailMod);

                int rowsAffected = changeAdmin.ExecuteNonQuery();

                MessageBox.Show("Modificacion completada");

                AdminUserControl ventana = new AdminUserControl();
                ventana.Show();
            }
        }
    }
}
