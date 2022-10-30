using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
//    Create table carrito(
// IdCarrito int primary key identity,
//IdCliente int references cliente(IdCliente),
//IdProducto int references producto(IdProducto),
//cantidad int
//)
    public class carrito
    {
        public int IdCarrito { get; set;}
        public cliente IdCliente { get; set; }
        public producto IdProducto { get; set; }
        public int cantidad { get; set; }
        
    }
}
