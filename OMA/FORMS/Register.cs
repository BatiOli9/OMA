﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OMA.FORMS
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_OMA.mdb");
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataAdapter da = new OleDbDataAdapter();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Welcome ventana = new Welcome();
            ventana.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbUser.Text == "" || textBox2.Text == "" || tbMail.Text == "")
            {
                MessageBox.Show("Tenes que completar todos los campos para poder registrarte", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbUser.Clear();
                textBox2.Clear();
                tbMail.Clear();
            }
            }
        }
    }
}
