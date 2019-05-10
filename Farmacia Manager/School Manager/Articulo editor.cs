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
    public partial class Articulo_editor : Form
    {
        public Articulo_editor()
        {
            InitializeComponent();
        }
        public Articulo articulo = new Articulo();
        ArticuloDb ArticuloDb = new ArticuloDb();
        public Articulos Articulos = new Articulos();

        private void Guardarbtn_Click(object sender, EventArgs e)
        {
            articulo.Nombre = textBox1.Text;
            articulo.Precio = Convert.ToInt16(textBox2.Text);
            articulo.Cantidad = Convert.ToInt16(textBox3.Text);
            ArticuloDb.Actualizar(articulo);
            Articulos.Show();
            this.Close();
        }

        private void Articulo_editor_Load(object sender, EventArgs e)
        {
            EstuNom.Text = articulo.Nombre;
            textBox1.Text = articulo.Nombre;
            textBox2.Text = Convert.ToString(articulo.Precio);
            textBox3.Text = Convert.ToString(articulo.Cantidad);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Articulos.Show();
            this.Close();
        }
    }
}
