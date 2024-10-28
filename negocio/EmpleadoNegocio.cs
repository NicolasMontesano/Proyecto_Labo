using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class EmpleadoNegocio
    {
        public Empleado ObtenerEmpleadoxIdUsuario(int idUsuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select IdEmpleado, Nombre, Apellido, FechaNacimiento, DNI, IdUsuario,Activo from Empleados where idUsuario = @usu");
                datos.setearParametro("@usu", idUsuario);
                datos.ejecutarLectura();

                Empleado emp = new Empleado();

                while (datos.Lector.Read())
                {
                    emp.Id = (int)datos.Lector["IdEmpleado"];
                    emp.Nombre = (string)datos.Lector["Nombre"];
                    emp.Apellido = (string)datos.Lector["Apellido"];
                    if (datos.Lector["FechaNacimiento"] != DBNull.Value) emp.FechaNacimiento = (DateTime)datos.Lector["FechaNacimiento"];

                    emp.DNI = (string)datos.Lector["DNI"];
                    emp.Activo = (int)datos.Lector["Activo"];

                    //emp.IdUsuario = (int)datos.Lector["IdUsuario"];


                }

                return emp;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
