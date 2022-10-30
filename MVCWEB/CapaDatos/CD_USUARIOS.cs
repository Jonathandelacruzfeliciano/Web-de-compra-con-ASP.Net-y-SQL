using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad; /*cuando  no me reconoce la endidad debo escribir using y la entidad a relacionar*/
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos  
{
     public class CD_USUARIOS
    {
        public List<usuario> listar()
        {
            List<usuario> lista = new List<usuario>();

            try
            {
                using (SqlConnection oconnection = new SqlConnection(Conexion.cn))
                {
                    string query = " select IdUsuario, Nombre,Apellido,Correo,Clave,Restablecer,Activo from usuario";
                    SqlCommand cmd = new SqlCommand(query, oconnection);
                    cmd.CommandType = CommandType.Text;

                    oconnection.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())

                        {
                            lista.Add(

                                new usuario()
                                {
                                    IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                    Nombre = dr["Nombre"].ToString(),
                                    Apellido = dr["Apellido"].ToString(),
                                    Correo = dr["Correo"].ToString(),
                                    Clave = dr["Clave"].ToString(),
                                    Reestablecer = Convert.ToBoolean(dr["Reestablecer"]),
                                    Activo = Convert.ToBoolean(dr["Reestablecer"])
                                }



                                );
                        }

                    }
                    {

                    }
                
                
                }



            }
            catch
            {
                lista = new List<usuario>();

            }

            return lista;
        }
    }
}
