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
    public partial class Nuevo_Usuario : Form
    {
        public Nuevo_Usuario()
        {
            InitializeComponent();
            
        }
        UsuarioDb usuarioDb = new UsuarioDb();
        public Admin_Usuario Admin_Usuario = new Admin_Usuario();
        Usuario usuario = new Usuario();
        private void button2_Click(object sender, EventArgs e)
        {
            Admin_Usuario admin_Usuario = new Admin_Usuario();
            admin_Usuario.MdiParent = this.ParentForm;
            admin_Usuario.Dock = DockStyle.Fill;
            admin_Usuario.admin.MdiParent = this.ParentForm;
            admin_Usuario.admin.Dock = DockStyle.Fill;
            admin_Usuario.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuario.Nombre = textBox1.Text;
            usuario.Apellido = textBox2.Text;
            usuario.Contraseña = textBox3.Text;
            usuario.tipo = comboBox1.SelectedItem.ToString();
            usuarioDb.NuevoUsuario(usuario);
            Admin_Usuario.Show();
            this.Close();
        }

        
    }
}
