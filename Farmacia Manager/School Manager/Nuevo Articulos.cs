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
using School_Manager.Modelos;
using School_Manager.Data;

namespace School_Manager
{
    public partial class Nuevo_Articulos : Form
    {
        public Nuevo_Articulos()
        {
            InitializeComponent();
        }
        public Articulos Articulos = new Articulos();
        Articulo articulo = new Articulo();
        ArticuloDb ArticuloDb = new ArticuloDb();
        private void button2_Click(object sender, EventArgs e)
        {
            Articulos articulos = new Articulos();
            articulos.MdiParent = this.ParentForm;
            articulos.Dock = DockStyle.Fill;
            articulos.admin_Articulos.MdiParent = this.ParentForm;
            articulos.admin_Articulos.Dock = DockStyle.Fill;
            articulos.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            articulo.Nombre = textBox1.Text;
            articulo.Precio = Convert.ToInt16(textBox2.Text);
            articulo.Cantidad = Convert.ToInt16(textBox3.Text);
            ArticuloDb.CrearArticulo(articulo);
            Articulos.Show();
            this.Close();
        }
    }
}
