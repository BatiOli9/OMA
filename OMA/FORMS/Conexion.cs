using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMA.FORMS
{
     class Conexion
    {
        private MySqlConnection conexion;
        private string server = "oliverdatabase.c3n2knxyysc4.sa-east-1.rds.amazonaws.com";
        private string database = "OMA";
        private string user = "oliver";
        private string password = "oliver123";
        private string cadenaConexion;

        public Conexion()
        {
            cadenaConexion = "Database=" + database + "; DataSource=" + server + "; User Id=" + user + "; Password=" + password;
        }

        public MySqlConnection getConexion()
        {
            conexion = new MySqlConnection();

            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                // MessageBox.Show("La conexion se establecio correctamente");
            }
            catch (MySqlException e)
            {
                // MessageBox.Show("La conexion no pudo establecerse");
            }

            return conexion;
        }
        public void closeConexion()
        {
            conexion.Close();
        }
    }
}
