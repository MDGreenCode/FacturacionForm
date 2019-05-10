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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        Admin admin = new Admin();
        Compras Compras = new Compras();
        public Usuario usuario = new Usuario();
        public Login login = new Login();
        private void Home_Load(object sender, EventArgs e)
        {
            if (usuario.tipo == "admin")
            {
                admin.MdiParent = this;
                admin.Dock = DockStyle.Fill;
                admin.login = login;
                admin.Show();
            }if (usuario.tipo == "cliente")
            {
                Compras.MdiParent = this;
                Compras.Dock = DockStyle.Fill;
                Compras.login = login;
                Compras.usuario = usuario;
                Compras.Show();
            }
        }

        

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
