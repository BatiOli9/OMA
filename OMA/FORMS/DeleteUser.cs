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
    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User ventana = new User();
            ventana.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexion c = new Conexion();

            MySqlCommand deleteCMD = new MySqlCommand("DELETE FROM users WHERE mail = @mail", c.getConexion());

            deleteCMD.Parameters.AddWithValue("@mail", Program.mail);


            try
            {
                c.getConexion();
                deleteCMD.ExecuteNonQuery();
                MessageBox.Show("Cuenta eliminada correctamente", "Cuenta eliminada");
                Welcome ventana = new Welcome();
                ventana.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el usuario", "Error");
                User ventana = new User();
                ventana.Show();
                this.Hide();
            }
        }
    }
}
