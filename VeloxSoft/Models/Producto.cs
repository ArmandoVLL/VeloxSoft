using System;
using System.Collections.Generic;
using System.Text;

namespace VeloxSoft.Models
{
    public class Producto
    {
        public string IdProducto { get; set; }
        public string Nombre { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public bool Estado { get; set; }
        public string IdCategoria { get; set; }
    }
}
