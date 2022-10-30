using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
//    create table Producto(
//IdProducto int primary key identity,
//Nombre varchar(500),
//Descripcion varchar(500),
//IdMarca int references marca(IdMarca),
//IdCategoria int references categoria(IdCategoria),
//precio decimal (10,0) default 0,
//stock int,
//RutaImagen varchar(100),
//NombreImagen varchar(100),
//Activo bit default 1,
//FechaRegistro datetime default getdate()
//)
   public class producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public marca omarca { get; set; }
        public categoria ocategoria { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string RutaImagen { get; set; }
        public string NombreImagen { get; set; }
        public bool Activo { get; set; }
    }
}
