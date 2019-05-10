using School_Manager.Modelos;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Manager.Data
{
    public class VentasDb
    {
        OleDbConnection cnn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();

        public VentasDb()
        {
            cnn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:Basededatos.accdb;
                Persist Security Info = False;";
        }
        public List<Venta> GetVentasByName(string name)
        {
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandText = "Select * from Ventas WHERE Nombre = @Nombre";
            cmd.Parameters.AddWithValue("@Nombre", name);
            bool read;
            OleDbDataReader reader = cmd.ExecuteReader();
            List<Venta> ventas = new List<Venta>();
            if (reader.Read() == true)
            {
                do
                {
                    Venta venta = new Venta();
                    venta.id = reader.GetInt32(0);
                    venta.Articulo = reader.GetString(1);
                    venta.Cantidad = Convert.ToInt16(reader.GetString(2));
                    venta.Pago = Convert.ToInt16(reader.GetString(3));
                    venta.Usuario = reader.GetString(4);
                    venta.Fecha = reader.GetString(5);
                    ventas.Add(venta);
                    read = reader.Read();
                } while (read == true);
            }
            reader.Close();
            cnn.Close();
            return ventas;
        }
        public List<Venta> GetVentasByDate(string date)
        {
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandText = "Select * from Ventas WHERE Fecha = @Fecha";
            cmd.Parameters.AddWithValue("@Fecha", date);
            bool read;
            OleDbDataReader reader = cmd.ExecuteReader();
            List<Venta> ventas = new List<Venta>();
            if (reader.Read() == true)
            {
                do
                {
                    Venta venta = new Venta();
                    venta.id = reader.GetInt32(0);
                    venta.Articulo = reader.GetString(1);
                    venta.Cantidad = Convert.ToInt16(reader.GetString(2));
                    venta.Pago = Convert.ToInt16(reader.GetString(3));
                    venta.Usuario = reader.GetString(4);
                    venta.Fecha = reader.GetString(5);
                    ventas.Add(venta);
                    read = reader.Read();
                } while (read == true);
            }
            reader.Close();
            cnn.Close();
            return ventas;
        }
        public List<Venta> GetVentasByNameAndDate(string name,string date)
        {
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandText = "Select * from Ventas WHERE Nombre = @Nombre AND Fecha = @Fecha";
            cmd.Parameters.AddWithValue("@Nombre", name);
            cmd.Parameters.AddWithValue("@Fecha", date);
            bool read;
            OleDbDataReader reader = cmd.ExecuteReader();
            List<Venta> ventas = new List<Venta>();
            if (reader.Read() == true)
            {
                do
                {
                    Venta venta = new Venta();
                    venta.id = reader.GetInt32(0);
                    venta.Articulo = reader.GetString(1);
                    venta.Cantidad = Convert.ToInt16(reader.GetString(2));
                    venta.Pago = Convert.ToInt16(reader.GetString(3));
                    venta.Usuario = reader.GetString(4);
                    venta.Fecha = reader.GetString(5);
                    ventas.Add(venta);
                    read = reader.Read();
                } while (read == true);
            }
            reader.Close();
            cnn.Close();
            return ventas;
        }
        public List<Venta> GetVentas()
        {
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandText = "Select * from Ventas";
            bool read;
            OleDbDataReader reader = cmd.ExecuteReader();
            List<Venta> ventas = new List<Venta>();
            if (reader.Read() == true)
            {
                do
                {
                    Venta venta = new Venta();
                    venta.id = reader.GetInt32(0);
                    venta.Articulo = reader.GetString(1);
                    venta.Cantidad = Convert.ToInt16(reader.GetString(2));
                    venta.Pago = Convert.ToInt16(reader.GetString(3));
                    venta.Usuario = reader.GetString(4);
                    venta.Fecha = reader.GetString(5);
                    ventas.Add(venta);
                    read = reader.Read();
                } while (read == true);
            }
            reader.Close();
            cnn.Close();
            return ventas;
        }
        public void CrearVentas(List<Venta> ventas)
        {
            foreach (var venta in ventas) {
                cnn.Open();
                string Jquery = "Insert into Ventas(Articulo,Cantidad,Pago,Usuario,Fecha) values (?,?,?,?,?)";
                OleDbCommand cmd = new OleDbCommand(Jquery, cnn);
                cmd.Parameters.AddWithValue("@Articulo", venta.Articulo);
                cmd.Parameters.AddWithValue("@Cantidad", venta.Cantidad);
                cmd.Parameters.AddWithValue("@Pago", venta.Pago);
                cmd.Parameters.AddWithValue("@Usuario", venta.Usuario);
                cmd.Parameters.AddWithValue("@Fecha", venta.Fecha);
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
    }
}
