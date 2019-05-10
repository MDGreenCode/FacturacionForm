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

namespace School_Manager
{
    public partial class Admin_Articulos : Form
    {
        public Admin_Articulos()
        {
            InitializeComponent();
        }
        public Admin admin = new Admin();

        private void Atrasbtn_Click(object sender, EventArgs e)
        {
            admin.MdiParent = this.ParentForm;
            admin.Dock = DockStyle.Fill;
            admin.Show();
            this.Close();
        }

        private void Ventasbtn_Click(object sender, EventArgs e)
        {
            Ver_ventas ver_Ventas = new Ver_ventas();
            ver_Ventas.MdiParent = this.ParentForm;
            ver_Ventas.Dock = DockStyle.Fill;
            ver_Ventas.Show();
            this.Close();
        }

        private void Artbtn_Click(object sender, EventArgs e)
        {
            Articulos articulos = new Articulos();
            articulos.MdiParent = this.ParentForm;
            articulos.Dock = DockStyle.Fill;
            articulos.admin_Articulos.MdiParent = this.ParentForm;
            articulos.admin_Articulos.Dock = DockStyle.Fill;
            articulos.Show();
            this.Close();
        }
    }
}
