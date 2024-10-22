using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class ProfesorNegocio
    {
        public int ObtenerProfexIdUsuario(int idUsuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select IdEmpleado, Nombre, Apellido, FechaNacimiento, DNI, IdUsuario from Empleados where idUsuario = @usu");
                datos.setearParametro("@usu", idUsuario);
                datos.ejecutarLectura();

                Profesor profe = new Profesor();

                while (datos.Lector.Read())
                {
                    profe.Id= (int)datos.Lector["IdProfesor"];
                    profe.Nombre = (string)datos.Lector["Nombew"];
                    profe.Apellido = (string)datos.Lector["Apellido"];
                    profe.FechaNacimiento = (DateTime)datos.Lector["FechaNacimiento"];
                    profe.DNI = (string)datos.Lector["DNI"];
                    profe.IdUsuario = (int)datos.Lector["IdUsuario"];
                   

                }

                return idUsuario;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        







    }
}
