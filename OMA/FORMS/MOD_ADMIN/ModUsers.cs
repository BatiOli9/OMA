using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMA.FORMS.MOD_ADMIN
{
    public partial class ModUsers : Form
    {
        public ModUsers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MOD_ADMIN.ModAdminUser ventana = new MOD_ADMIN.ModAdminUser();
            ventana.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MOD_ADMIN.ModAdminMail ventana = new MOD_ADMIN.ModAdminMail();
            ventana.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MOD_ADMIN.ModAdminPassword ventana = new MOD_ADMIN.ModAdminPassword();
            ventana.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MOD_ADMIN.ModAdminType ventana = new MOD_ADMIN.ModAdminType();
            ventana.Show();
            this.Hide();
        }
    }
}
