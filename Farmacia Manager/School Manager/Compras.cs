using School_Manager.Data;
using School_Manager.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Manager
{
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
        }
        public Login login = new Login();
        public Usuario usuario = new Usuario();
        List<Articulo> articulos = new List<Articulo>();
        ArticuloDb articuloDb = new ArticuloDb();
        List<Venta> ventas = new List<Venta>();
        Venta venta = new Venta();
        VentasDb VentasDb = new VentasDb();
        int P = 0;
        int tol = 0;
        private void Atrasbtn_Click(object sender, EventArgs e)
        {
            login.Show();
            this.MdiParent.Hide();
            this.Close();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["ElegirBtn"].Index)
            {
                Articulotxt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                numericCant.Maximum = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                P = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
            }
        }
        void mostrarArticulos()
        {
            dataGridView1.Rows.Clear();
            articulos = articuloDb.GetArticulo();
            foreach (var art in articulos)
            {
                dataGridView1.Rows.Add(art.Id, art.Nombre, art.Precio, art.Cantidad, "Elegir");
            }
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            Nombretxt.Text = usuario.Nombre;
            Apellidotxt.Text = usuario.Apellido;
            datagrid();
            mostrarArticulos();
        }
        void datagrid()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Cantidad = Convert.ToInt32(Math.Round(numericCant.Value, 0));
            int Cant = Convert.ToInt16(Canttxt.Text)+ Cantidad; 
            Canttxt.Text = Convert.ToString(Cant);
            tol = Cantidad * P;
            Montotxt.Text = Convert.ToString(Convert.ToInt16(Montotxt.Text) + tol);
            venta.Articulo = Articulotxt.Text;
            venta.Cantidad = Cantidad;
            venta.Pago = tol;
            venta.Usuario = usuario.Nombre +" "+ usuario.Apellido;
            string date = DateTime.Now.ToString("dd'/'MM'/'yyyy");
            venta.Fecha = date;
            ventas.Add(venta);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VentasDb.CrearVentas(ventas);
            ArticuloDb articuloDb = new ArticuloDb();
            foreach (var venta in ventas) {
                articulos = articuloDb.GetArticulosByName(venta.Articulo);
                articulos[0].Cantidad = articulos[0].Cantidad - venta.Cantidad;
                articuloDb.Actualizar(articulos[0]);
             }
            ventas.Clear();
            mostrarArticulos();
            Canttxt.Text = "0";
            Montotxt.Text = "0";
            Articulotxt.Text = "Articulo";

        }
    }
}
