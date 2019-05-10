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
using School_Manager.Data;
using School_Manager.Modelos;

namespace School_Manager
{
    public partial class Articulos : Form
    {
        public Articulos()
        {
            InitializeComponent();
            
        }
        ArticuloDb articuloDb = new ArticuloDb();
        List<Articulo> articulos = new List<Articulo>();
        public Admin_Articulos admin_Articulos = new Admin_Articulos();
        void mostrar()
        {
            dataGridView1.Rows.Clear();
            articulos = articuloDb.GetArticulo();
            foreach (var art in articulos)
            {
                dataGridView1.Rows.Add(art.Id, art.Nombre, art.Precio, art.Cantidad, "Editar", "Borrar");
            }
        }
        private void Admin_Estudiantes_Load(object sender, EventArgs e)
        {
            datagrid();
            mostrar();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Borrarbtn"].Index)
            {
                DialogResult result = MessageBox.Show("Estar seguro de querer borrarlo", "Confirmacion", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    articuloDb.Delete(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    mostrar();
                }
            }
            if (e.ColumnIndex == dataGridView1.Columns["editarbtn"].Index)
            {
                Articulo_editor articulo_editor = new Articulo_editor();
                articulo_editor.articulo.Nombre = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                articulo_editor.articulo.Precio = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
                articulo_editor.articulo.Id = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                articulo_editor.articulo.Cantidad = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                articulo_editor.Articulos.MdiParent = this.ParentForm;
                articulo_editor.Articulos.Dock = DockStyle.Fill;
                articulo_editor.MdiParent = this.ParentForm;
                articulo_editor.Dock = DockStyle.Fill;
                articulo_editor.Show();
                this.Close();
            }
        }

        private void NewProfebtn_Click(object sender, EventArgs e)
        {
            Nuevo_Articulos nuevo_Articulos = new Nuevo_Articulos();
            nuevo_Articulos.Articulos.MdiParent = this.ParentForm;
            nuevo_Articulos.Articulos.Dock = DockStyle.Fill;
            nuevo_Articulos.MdiParent = this.ParentForm;
            nuevo_Articulos.Dock = DockStyle.Fill;
            nuevo_Articulos.Show();
            this.Close();
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != "")
            {
                dataGridView1.Rows.Clear();
                articulos = articuloDb.GetArticulosByName(textBox1.Text);
                foreach (var art in articulos)
                {
                    dataGridView1.Rows.Add(art.Id, art.Nombre, art.Precio, art.Cantidad, "Editar", "Borrar");
                }
            }
            else
                mostrar();
        }
    }
}
