using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appPinturasV1.Entidades
{
    class clProductoE
    {
        public int IdProducto { get; set; }
        public string Producto { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Referencia { get; set; }
        public string Color { get; set; }
        public int Cantidad { get; set; }
        public string Marca { get; set; }
        public double Precio { get; set; }
        public int IdTipoProducto { get; set; }
        public int IdPresentacion { get; set; }
    }
}
