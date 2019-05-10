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
    public partial class Admin_Usuario : Form
    {
        public Admin_Usuario()
        {
            InitializeComponent();
        }

        UsuarioDb usuarioDb = new UsuarioDb();
        List<Usuario> usuarios = new List<Usuario>();
        Usuario usuario = new Usuario();
        public Admin admin = new Admin();
        void mostrar()
        {
            dataGridView1.Rows.Clear();
            usuarios = usuarioDb.GetUsuarios();
            foreach (var user in usuarios)
            {
                dataGridView1.Rows.Add(user.Id,user.Nombre,user.Apellido,user.tipo,"Editar","Borrar");
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
                    usuarioDb.Delete(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    mostrar();
                }
            }
            if (e.ColumnIndex == dataGridView1.Columns["editarbtn"].Index)
            {
                Usuario_editor usuario_editor = new Usuario_editor();
                usuario.Nombre = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                usuario.Apellido = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                usuario.Id = Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                usuario.tipo = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                usuario_editor.usuario = usuario;
                usuario_editor.admin_Alumno.MdiParent = this.ParentForm;
                usuario_editor.admin_Alumno.Dock = DockStyle.Fill;
                usuario_editor.MdiParent = this.ParentForm;
                usuario_editor.Dock = DockStyle.Fill;
                usuario_editor.Show();
                this.Close();
            }
        }

        private void NewProfebtn_Click(object sender, EventArgs e)
        {
            Nuevo_Usuario nuevo_Usuario = new Nuevo_Usuario();
            nuevo_Usuario.Admin_Usuario.MdiParent = this.ParentForm;
            nuevo_Usuario.Admin_Usuario.Dock = DockStyle.Fill;
            nuevo_Usuario.MdiParent = this.ParentForm;
            nuevo_Usuario.Dock = DockStyle.Fill;
            nuevo_Usuario.Show();
            this.Close();
        }

        private void Atrasbtn_Click(object sender, EventArgs e)
        {
            admin.MdiParent = this.ParentForm;
            admin.Dock = DockStyle.Fill;
            admin.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                dataGridView1.Rows.Clear();
                usuarios = usuarioDb.GetUsuariosByName(textBox1.Text);
                foreach (var user in usuarios)
                {
                    dataGridView1.Rows.Add(user.Id, user.Nombre, user.Apellido, user.tipo, "Editar", "Borrar");
                }
            }
            else
                mostrar();

        }
    }

}

