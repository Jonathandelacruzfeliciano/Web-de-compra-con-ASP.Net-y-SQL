using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
//    create table detalle_venta(
//IdDetalleVenta int primary key identity,
//IdVenta int references venta(IdVenta),
//IdProducto int references producto(IdProducto),
//Cantidad int,
//Total decimal(10,2)
//)
   public class detalle_venta
    {
        public int IdDetalleVenta { get; set; }
        public int IdVenta { get; set; }
        public producto oProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Totla { get; set; }
        public string IdTransacion { get; set; }
    }
}
