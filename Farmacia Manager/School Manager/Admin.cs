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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            
        }
        public Usuario usuario { get; set; }
        UsuarioDb usuarioDb = new UsuarioDb();
        ArticuloDb articuloDb = new ArticuloDb();
        public Login login = new Login();
        private void Admin_Load(object sender, EventArgs e)
        {
            ArtCant.Text = Convert.ToString(articuloDb.Cantidad);
            EmpCant.Text = Convert.ToString(usuarioDb.Cantidad);
        }

        private void Usuariobtn_Click(object sender, EventArgs e)
        {
            Admin_Usuario admin_Usuario = new Admin_Usuario();
            admin_Usuario.MdiParent = this.ParentForm;
            admin_Usuario.Dock = DockStyle.Fill;
            admin_Usuario.admin.MdiParent = this.ParentForm;
            admin_Usuario.admin.Dock = DockStyle.Fill;
            admin_Usuario.Show();
            this.Close();
        }

        private void ArtAdminbtn_Click(object sender, EventArgs e)
        {
            Admin_Articulos admin_Articulos = new Admin_Articulos();
            admin_Articulos.MdiParent = this.ParentForm;
            admin_Articulos.Dock = DockStyle.Fill;
            admin_Articulos.admin.MdiParent = this.ParentForm;
            admin_Articulos.admin.Dock = DockStyle.Fill;
            admin_Articulos.Show();
            this.Close();
        }

        private void Guardarbtn_Click(object sender, EventArgs e)
        {
            login.Show();
            this.MdiParent.Hide();
            this.Close();
        }
    }
}
