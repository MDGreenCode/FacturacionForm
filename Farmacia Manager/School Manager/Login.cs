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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        UsuarioDb UsuarioDb = new UsuarioDb();
        public void button1_Click(object sender, EventArgs e)
        {
            if(todoLleno(UserNametext.Text,PasswordText.Text))
            usuario = UsuarioDb.Accseso(UserNametext.Text,PasswordText.Text);
            if (usuario.tipo != string.Empty) {
                Home home = new Home();
                home.usuario = usuario;
                home.login = this;
                home.Show();
                this.Hide();
            }
        }

        
        Usuario usuario = new Usuario();
        

        public static bool todoLleno(string n,string p)
        {
            if(n != string.Empty && p != string.Empty)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Llena todo los campos");
                return false;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserNametext.Text = "Usuario";
            PasswordText.Text = "5678";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UserNametext.Text = "Admin";
            PasswordText.Text = "1234";
        }
    }
}
