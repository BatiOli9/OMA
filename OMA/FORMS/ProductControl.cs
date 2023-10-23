using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMA.FORMS
{
    public partial class ProductControl : UserControl
    {
        [Category ("Custom Props")]
        private string _nombre;
        private string _precio;
        private string _foto;
        private string _link;

        [Category("Custom Props")]
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; nombre.Text = value; }
        }
        [Category("Custom Props")]
        public string Precio
        {
            get { return _precio; }
            set { _precio = value; precio.Text = value; }
        }
        [Category("Custom Props")]
        public string Link
        {
            get { return _link; }
            set { _link = value; link.Text = value; }
        }
        [Category("Custom Props")]
        public string Foto
        {
            get { return _foto; }
            set { _link = value; foto.ImageLocation = _foto; }
        }

        public ProductControl()
        {
            InitializeComponent();
        }
    }
}
