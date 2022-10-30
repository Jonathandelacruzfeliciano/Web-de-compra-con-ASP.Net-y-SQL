using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{

    //    create table usuario(
    //IdUsuario int primary key identity,
    //Nombre varchar(100),
    //Apellido varchar(100),
    //Correo varchar(100),
    //Clave varchar(150),
    //Reestablecer bit default 1,
    //Activo bit default 1,
    //FechaRegistro datetime default getdate()
    //)
    public class usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public bool Reestablecer { get; set; }
        public bool Activo { get; set; }
        
    }
}
