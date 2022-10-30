using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
//    create table cliente(
//IdCliente int primary key identity,
//Nombre varchar(100),
//Apellido varchar(100),
//Correo varchar(100),
//Clave varchar(100),
//Reestablecer bit default 0,
//FechaRegistro datetime default getdate()
//)
   public class cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public bool Reestablecer { get; set; }
        
    }
}
