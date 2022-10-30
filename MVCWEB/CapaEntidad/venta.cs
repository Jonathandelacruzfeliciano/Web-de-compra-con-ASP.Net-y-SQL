using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
//    create table venta(
//IdVenta int primary key identity,
//IdCliente int references cliente(IdCliente),
//TotalProducto int,
//MontoTotal decimal(10,2),
//Contacto varchar(50),
//IdDistrito varchar(10),
//Telefono varchar(50),
//Direccion varchar(500),
//IdTransacion varchar(50),
//FechaVenta datetime default getdate()
//)
   public class venta
    { public int IdVenta { get; set; }
        public int IdCliente { get; set; }
        public int TotalProducto { get; set; }
        public decimal MontoTotal { get; set; }
        public string Contacto { get; set; }
        public string IdDistrito { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string IdTransacion { get; set; }
        public string FechaTexto { get; set; }

        public List<detalle_venta> odetalle_Venta { get; set; }


    }
}
