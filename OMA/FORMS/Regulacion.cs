﻿using System;
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

        System.Drawing.Image imageOn = Properties.Resources.Group_8;
        System.Drawing.Image imageOff = Properties.Resources.Group_8__1_;

        private void prender_Click_1(object sender, EventArgs e)
        {
            if (prender.BackgroundImage == imageOff)
            {
                prender.BackgroundImage = imageOn;
                prender.Text = "Apagar";
                arduino.PortName = "COM6";
                arduino.BaudRate = 9600; 
                arduino.Open();
            }
            else if (prender.BackgroundImage == imageOn)
            {
                prender.BackgroundImage = imageOff;
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

        private void Regulacion_Load(object sender, EventArgs e)
        {
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
        }

        private void settings_Click(object sender, EventArgs e)
        {

        }

        private void account_Click(object sender, EventArgs e)
        {

        }

        private void header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void shop_Click_1(object sender, EventArgs e)
        {
            Productos ventana = new Productos();
            ventana.Show();
            this.Hide();
        }

        private void regulation_Click_1(object sender, EventArgs e)
        {
            Regulacion ventana = new Regulacion();
            ventana.Show();
            this.Hide();
        }

        private void OMA_Click_1(object sender, EventArgs e)
        {
            Index ventana = new Index();
            ventana.Show();
            this.Hide();
        }

        private void settings_Click_1(object sender, EventArgs e)
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
