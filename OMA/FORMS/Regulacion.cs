using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace OMA.FORMS
{
    public partial class Regulacion : Form
    {
        public Regulacion()
        {
            InitializeComponent();
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

        private void rpmBar_Scroll(object sender, EventArgs e)
        {
            
        }

        private void prender_Click_1(object sender, EventArgs e)
        {
            if (prender.BackColor == Color.Lime)
            {
                prender.BackColor = Color.Red;
                prender.Text = "Apagar";
                arduino.PortName = "COM3";
                arduino.BaudRate = 9600;
                arduino.Open();
            }
            else if (prender.BackColor == Color.Red)
            {
                prender.BackColor = Color.Lime;
                prender.Text = "Encender";
                arduino.Close();
            }
        }

        private void rpmBar_ValueChanged(object sender, EventArgs e)
        {
            int velocidadErronea = rpmBar.Value;
            int velocidadSeleccionada = 255 - velocidadErronea;
            if (velocidadSeleccionada == 0)
            {
                velocidad.Text = "Velocidad Miníma";
            }
            else if  (velocidadSeleccionada == 255)
            {
                velocidad.Text = "Velocidad Máxima";
            }
            else if (velocidadSeleccionada > 1 && velocidadSeleccionada < 85)
            {
                velocidad.Text = "Velocidad Baja";
            }
            else if (velocidadSeleccionada > 86 && velocidadSeleccionada < 170)
            {
                velocidad.Text = "Velocidad Media";
            }
            else if (velocidadSeleccionada > 171 && velocidadSeleccionada < 254)
            {
                velocidad.Text = "Velocidad Alta";
            }

            string velocidadSelected = velocidadErronea.ToString();
            arduino.WriteLine(velocidadSelected);
        }
    }
}
