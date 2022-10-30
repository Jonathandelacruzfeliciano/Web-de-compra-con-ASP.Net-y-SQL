using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace capaNegocio
{
     public class CN_Usuarios
    {
        private CD_USUARIOS objCapaDato = new CD_USUARIOS();

        public List<usuario> listar()
        
        {
            return objCapaDato.listar();

        }

      

    }
}
