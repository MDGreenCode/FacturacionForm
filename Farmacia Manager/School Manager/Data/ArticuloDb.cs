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
    public class ArticuloDb
    {
        OleDbConnection cnn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        public int Cantidad { get; private set; }
        public ArticuloDb()
        {
            cnn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:Basededatos.accdb;
                Persist Security Info = False;";
            cant();
        }
        public void Delete(string id)
        {
            cnn.Open();
            OleDbCommand cmd = new OleDbCommand(@"Delete * from Articulo where Id = @id", cnn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public List<Articulo> GetArticulosByName(string name)
        {
            cmd.Connection = cnn;
            cmd.CommandText = "Select * from Articulos WHERE Nombre = @Nombre";
            cmd.Parameters.AddWithValue("@Nombre", name);
            bool read;
            cnn.Open();
            OleDbDataReader reader = cmd.ExecuteReader();
            List<Articulo> articulos = new List<Articulo>();
            
            if (reader.Read() == true)
            {
                do
                {
                    Articulo articulo = new Articulo();
                    articulo.Id = reader.GetInt32(0);
                    articulo.Nombre = reader.GetString(1);
                    articulo.Precio = Convert.ToInt16(reader.GetString(2));
                    articulo.Cantidad = Convert.ToInt16(reader.GetString(3));
                    articulos.Add(articulo);
                    read = reader.Read();
                } while (read == true);
            }
            reader.Close();
            cnn.Close();
            return articulos;
        }

        public void Actualizar(Articulo articulo)
        {
            OleDbCommand command = new OleDbCommand(@"UPDATE Articulos SET Nombre = @nombre,Precio = @precio,Cantidad = @Cantidad WHERE Id = @ID", cnn);

            command.Parameters.AddWithValue("@nombre", articulo.Nombre);
            command.Parameters.AddWithValue("@Precio", articulo.Precio);
            command.Parameters.AddWithValue("@Cantidad", articulo.Cantidad);
            command.Parameters.AddWithValue("@ID", articulo.Id);
            cnn.Open();
            command.ExecuteNonQuery();
            {
                MessageBox.Show("Ha sido editado Exitosamente");

            };
            cnn.Close();
        }
        public void CrearArticulo(Articulo articulo)
        {
            cnn.Open();
            string Jquery = "Insert into Articulos(Nombre,Precio,Cantidad) values (?,?,?)";
            OleDbCommand cmd = new OleDbCommand(Jquery, cnn);
            cmd.Parameters.AddWithValue("@Nombre", articulo.Nombre);
            cmd.Parameters.AddWithValue("@Precio", articulo.Precio);
            cmd.Parameters.AddWithValue("@Cantidad", articulo.Cantidad);
            cmd.ExecuteNonQuery();
            {
                MessageBox.Show("Nuevo articulo ingresado");
            };
            cnn.Close();
        }
        public List<Articulo> GetArticulo()
        {
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandText = "Select * from Articulos";
            bool read;
            OleDbDataReader reader = cmd.ExecuteReader();
            List<Articulo> articulos = new List<Articulo>();
            if (reader.Read() == true)
            {
                do
                {
                    Articulo articulo = new Articulo();
                    articulo.Id = reader.GetInt32(0);
                    articulo.Nombre = reader.GetString(1);
                    articulo.Precio = Convert.ToInt16(reader.GetString(2));
                    articulo.Cantidad = Convert.ToInt16(reader.GetString(3));
                    articulos.Add(articulo);
                    read = reader.Read();
                } while (read == true);
            }
            reader.Close();
            cnn.Close();
            return articulos;
        }

        private void cant()
        {
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandText = "Select * from Articulos";
            OleDbDataReader reader = cmd.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count++;
            }
            cnn.Close();
            this.Cantidad = count;
        }
    }
}
