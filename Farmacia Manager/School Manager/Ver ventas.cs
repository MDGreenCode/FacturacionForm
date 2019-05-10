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
    public partial class Ver_ventas : Form
    {
        public Ver_ventas()
        {
            InitializeComponent();
            
        }
        Venta venta = new Venta();
        List<Venta> ventas = new List<Venta>();
        VentasDb ventasDb = new VentasDb();
        private void Atrasbtn_Click(object sender, EventArgs e)
        {
            Admin_Articulos admin_Articulos = new Admin_Articulos();
            admin_Articulos.MdiParent = this.ParentForm;
            admin_Articulos.Dock = DockStyle.Fill;
            admin_Articulos.admin.MdiParent = this.ParentForm;
            admin_Articulos.admin.Dock = DockStyle.Fill;
            admin_Articulos.Show();
            this.Close();
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

        private void Ver_ventas_Load(object sender, EventArgs e)
        {
            datagrid();
            mostrar();
        }
        void mostrar()
        {
            dataGridView1.Rows.Clear();
            ventas = ventasDb.GetVentas();
            foreach (var vent in ventas)
            {
                dataGridView1.Rows.Add(vent.id, vent.Articulo, vent.Cantidad,vent.Pago, vent.Usuario,vent.Fecha);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.textBox1.Text != ""&& textBox2.Text != "")
            {
                dataGridView1.Rows.Clear();
                ventas = ventasDb.GetVentasByNameAndDate(textBox1.Text,textBox2.Text);
                foreach (var vent in ventas)
                {
                    dataGridView1.Rows.Add(vent.id, vent.Articulo, vent.Cantidad, vent.Pago, vent.Usuario, vent.Fecha);
                }
            }
            else if (this.textBox1.Text != "")
            {
                dataGridView1.Rows.Clear();
                ventas = ventasDb.GetVentasByName(textBox1.Text);
                foreach (var vent in ventas)
                {
                    dataGridView1.Rows.Add(vent.id, vent.Articulo, vent.Cantidad, vent.Pago, vent.Usuario, vent.Fecha);
                }
            }
            else if (this.textBox2.Text != "")
            {
                dataGridView1.Rows.Clear();
                ventas = ventasDb.GetVentasByDate(textBox2.Text);
                foreach (var vent in ventas)
                {
                    dataGridView1.Rows.Add(vent.id, vent.Articulo, vent.Cantidad, vent.Pago, vent.Usuario, vent.Fecha);
                }
            }
            else
                mostrar();
        }
    }
}
