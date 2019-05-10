using School_Manager.Modelos;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Manager.Data
{
    public class UsuarioDb
    {
        OleDbConnection cnn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        Usuario usuario = new Usuario();
        public int Cantidad { get; private set; }
        public UsuarioDb()
        {
            cnn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:Basededatos.accdb;
                Persist Security Info = False;";
            cant();
        }
        public Usuario Accseso(string name, string password)
        {
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandText = "Select * from Usuarios";
                bool read;
                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    do
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            if (reader.GetString(1) == name &&
                                reader.GetString(2) == password)
                            {
                                usuario.tipo = reader.GetString(3);
                                usuario.Nombre = reader.GetString(1);
                                usuario.Apellido = reader.GetString(4);
                                usuario.Contraseña = reader.GetString(2);
                                break;
                            }
                        }

                        read = reader.Read();
                    } while (read == true);
                }
            reader.Close();
            cnn.Close();
            return usuario;
        }
        public void Delete(string id)
        {
            cnn.Open();
            OleDbCommand cmd = new OleDbCommand(@"Delete * from Usuarios where Id = @id", cnn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public void Actualizar(Usuario usuario)
        {
            OleDbCommand command = new OleDbCommand(@"UPDATE Usuarios SET Nombre = @nombre,Apellido = @apellido WHERE Id = @ID", cnn);

            command.Parameters.AddWithValue("@nombre", usuario.Nombre);
            command.Parameters.AddWithValue("@apellido", usuario.Apellido);
            command.Parameters.AddWithValue("@ID", usuario.Id);
            cnn.Open();
            command.ExecuteNonQuery();
            {
                MessageBox.Show("Ha sido editado Exitosamente");
                
            };
            cnn.Close();
        }
        public List<Usuario> GetUsuarios()
        {
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandText = "Select * from Usuarios";
            bool read;
            OleDbDataReader reader = cmd.ExecuteReader();
            
            List<Usuario> usuarios = new List<Usuario>();
            if (reader.Read() == true)
            {
                do
                {
                    Usuario usuario = new Usuario();
                    usuario.Id = reader.GetInt32(0);
                    usuario.Nombre = reader.GetString(1);
                    usuario.Apellido = reader.GetString(4);
                    usuario.tipo = reader.GetString(3);
                    usuarios.Add(usuario);
                    read = reader.Read();
                } while (read == true);
            }
            reader.Close();
            cnn.Close();
            return usuarios;
        }
        public void NuevoUsuario(Usuario usuario)
        {
            cnn.Open();
            string Jquery = "Insert into Usuarios(Nombre,Contraseña,Tipo,Apellido) values (?,?,?,?)";
            OleDbCommand cmd = new OleDbCommand(Jquery, cnn);
            cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
            cmd.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
            cmd.Parameters.AddWithValue("@Tipo", usuario.tipo);
            cmd.Parameters.AddWithValue("@Apellido", usuario.Apellido);
            cmd.ExecuteNonQuery();
            {
                MessageBox.Show("Nuevo usuario ingresado");
            };
            cnn.Close();
        }
        public List<Usuario> GetUsuariosByName(string name)
        {
            
            cmd.Connection = cnn;
            cmd.CommandText = "Select * from Usuarios WHERE Nombre = @Nombre";
            cmd.Parameters.AddWithValue("@Nombre", name);
            bool read;
            List<Usuario> usuarios = new List<Usuario>();
            cnn.Open();
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
                do
                {
                    Usuario usuario = new Usuario();
                    usuario.Id = reader.GetInt32(0);
                    usuario.Nombre = reader.GetString(1);
                    usuario.Apellido = reader.GetString(4);
                    usuario.tipo = reader.GetString(3);
                    usuarios.Add(usuario);
                    read = reader.Read();
                } while (read == true);
            }
            reader.Close();
            cnn.Close();
            return usuarios;
        }
        private void cant()
        {
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandText = "Select * from Usuarios";
            OleDbDataReader reader = cmd.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count++;
            }
            reader.Close();
            cnn.Close();
            this.Cantidad = count;
        }

    }
}
