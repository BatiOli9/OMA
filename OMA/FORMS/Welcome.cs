using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using MySqlConnector;

namespace OMA.FORMS
{
    public partial class Welcome : Form
    {
        Conexion objetoconexion;

        public Welcome()
        {
            InitializeComponent();

            objetoconexion = new Conexion();
            objetoconexion.getConexion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mailTb.Text == "" || passTb.Text == "")
            {
                MessageBox.Show("Tenes que completar todos los campos para poder registrarte", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                mailTb.Clear();
                passTb.Clear();
            }
            else
            {

                String mail = mailTb.Text;
                String pass = passTb.Text;

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `mail` = @mail and `password` = @pass;", objetoconexion.getConexion());

                command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = mail;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass;

                adapter.SelectCommand = command;

                adapter.Fill(table);    

                // check if mail exists or not
                if (table.Rows.Count > 0)
                {
                    Index ventana = new Index();
                    ventana.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("NO");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Register ventana = new Register();
            ventana.Show();
            this.Hide();
        }
    }
}
