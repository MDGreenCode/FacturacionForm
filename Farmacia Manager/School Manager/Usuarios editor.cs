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
    public partial class Usuario_editor : Form
    {
        public Usuario_editor()
        {
            InitializeComponent();
        }
        public Usuario usuario = new Usuario();

        UsuarioDb usuarioDb = new UsuarioDb();
        public Admin_Usuario admin_Alumno = new Admin_Usuario();
        private void Usuarios_Editor_Load(object sender, EventArgs e)
        {
            EstuNom.Text = usuario.Nombre + " " + usuario.Apellido;
            
        }
        
        private void Atrasbtn_Click(object sender, EventArgs e)
        {
            Admin_Usuario admin_Usuario = new Admin_Usuario();
            admin_Usuario.MdiParent = this.ParentForm;
            admin_Usuario.Dock = DockStyle.Fill;
            admin_Usuario.admin.MdiParent = this.ParentForm;
            admin_Usuario.admin.Dock = DockStyle.Fill;
            admin_Usuario.Show();
            this.Close();
        }

        private void Guardarbtn_Click(object sender, EventArgs e)
        {
            usuario.Nombre = textBox1.Text;
            usuario.Apellido = textBox2.Text;
            usuario.tipo = Asig3Box.SelectedItem.ToString();
            usuarioDb.Actualizar(usuario);
            admin_Alumno.Show();
            this.Close();
        }
    }
}
