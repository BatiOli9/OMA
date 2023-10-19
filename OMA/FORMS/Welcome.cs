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
using MySql.Data.MySqlClient;

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

            passTb.PasswordChar = '*';
        }
        public string usernameResult { get; set; }
        public string mailResult { get; set; }
        public string adminCompartir { get; set; }

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

                if (table.Rows.Count > 0)
                {
                    MySqlCommand adminCommand = new MySqlCommand("SELECT `admin` FROM `users` WHERE `mail` = @mail;", objetoconexion.getConexion());
                    MySqlCommand mailCommand = new MySqlCommand("SELECT `mail` FROM `users` WHERE `mail` = @mail;", objetoconexion.getConexion());
                    MySqlCommand usernameCommand = new MySqlCommand("SELECT `username` FROM `users` WHERE `mail` = @mail;", objetoconexion.getConexion());
                    MySqlCommand passwordCommand = new MySqlCommand("SELECT `password` FROM `users` WHERE `mail` = @mail;", objetoconexion.getConexion());

                    adminCommand.Parameters.AddWithValue("@mail", mailTb.Text);
                    mailCommand.Parameters.AddWithValue("@mail", mailTb.Text);
                    usernameCommand.Parameters.AddWithValue("@mail", mailTb.Text);
                    passwordCommand.Parameters.AddWithValue("@mail", mailTb.Text);

                    objetoconexion.getConexion();
                    MySqlDataReader mailReader = mailCommand.ExecuteReader();
                    if (mailReader.Read())
                    {
                        Program.mail = mailReader["mail"].ToString();
                    }
                    mailReader.Close();

                    MySqlDataReader passReader = passwordCommand.ExecuteReader();
                    if (passReader.Read())
                    {
                        Program.password = passReader["password"].ToString();
                    }
                    passReader.Close();

                    MySqlDataReader userReader = usernameCommand.ExecuteReader();
                    if (userReader.Read())
                    {
                        Program.username = userReader["username"].ToString();
                    }
                    userReader.Close();

                    objetoconexion.closeConexion();

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        bool isAdminn = Convert.ToInt32(result) == 1;
                        if (isAdminn == true)
                        {
                            Program.admin = "yes";
                        }
                        else if (isAdminn == false)
                        {
                            Program.admin = "no";
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron datos de el admin");
                    }
                    //User userForm = new User();
                    //User.username = usernameResult;

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

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (passTb.PasswordChar == '*')
            {
                passTb.PasswordChar = '\0'; // Mostrar texto de la contraseña
            }
            else
            {
                passTb.PasswordChar = '*'; // Ocultar la contraseña nuevamente
            }
        }
    }
}
