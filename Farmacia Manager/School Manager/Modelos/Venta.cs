using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Manager.Modelos
{
    public class Venta
    {
        public int id { get; set; }
        public string Articulo { get; set; }
        public int Cantidad { get; set; }
        public int Pago { get; set; }
        public string Usuario { get; set; }
        public string Fecha { get; set; }
    }
}
