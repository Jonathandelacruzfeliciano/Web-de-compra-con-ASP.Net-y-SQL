﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
//    create table marca(
//IdMarca int primary key identity,
//Descripcion varchar (100),
//Activo bit default 1,
//FechaRegistro datetime default getdate()
//)
   public class marca
    {
        public int IdMaca { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
    }
}