using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMA.FORMS
{
    internal class Conexion
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
            if (conexion == null)
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
            }

            return conexion;
        }
    }
}
