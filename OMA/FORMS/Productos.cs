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
using System.Threading;

namespace OMA.FORMS
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        public class Producto
        {
            public int id;
            public string nombre;
            public decimal precio;
            public string link;
            public string image;
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            // Items Admin
            if (Program.admin == "yes")
            {
                btnControl.Show();
                adminLbl.Show();
            }
            else
            {
                btnControl.Hide();
                adminLbl.Hide();
            }

            // Carga de Productos
            
            // Extraccion de Productos
            Conexion c = new Conexion();

            List<Producto> productos = new List<Producto>();

            c.getConexion();

            MySqlCommand comandoProductos = new MySqlCommand("SELECT * FROM productos", c.getConexion());

            MySqlDataReader resultados = comandoProductos.ExecuteReader();

            while (resultados.Read())
            {
                Producto producto = new Producto();
                producto.id = resultados.GetInt32(0);
                producto.nombre = resultados.GetString(1);
                producto.precio = resultados.GetDecimal(2);
                producto.image = resultados.GetString(3);
                producto.link = resultados.GetString(4);
                productos.Add(producto);
            }

            c.closeConexion();

            // Productos Puestos en la App
            foreach(Producto producto in productos)
            {
                string precioConvertido = Convert.ToString(producto.precio);
                ProductControl pc = new ProductControl();

                pc.Nombre = producto.nombre;
                pc.Precio = precioConvertido;
                pc.Foto = producto.image;


                flowLayoutPanel1.Controls.Add(pc);

                Thread.Sleep(10);
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Index ventana = new Index();
            ventana.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Productos ventana = new Productos();
            ventana.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Regulacion ventana = new Regulacion();
            ventana.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void OMA_Click(object sender, EventArgs e)
        {
            Index ventana = new Index();
            ventana.Show();
            this.Hide();
        }

        private void regulation_Click(object sender, EventArgs e)
        {
            Regulacion ventana = new Regulacion();
            ventana.Show();
            this.Hide();
        }

        private void shop_Click(object sender, EventArgs e)
        {
            Productos ventana = new Productos();
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

        private void account_Click(object sender, EventArgs e)
        {
            User ventana = new User();
            ventana.Show();
            this.Hide();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            Welcome ventana = new Welcome();
            ventana.Show();
            this.Hide();
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            AdminPanel panel = new AdminPanel();
            panel.Show();
            this.Hide();
        }
    }
}
