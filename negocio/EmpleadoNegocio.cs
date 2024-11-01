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

        public void agregar(Empleado emple)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO Empleados(Nombre, Apellido, FechaNacimiento, DNI, IdUsuario) VALUES  ('" + emple.Nombre + "', '" + emple.Apellido + "', '" + emple.FechaNacimiento + "', '" + emple.DNI + "')");
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void agregar_Sp(Empleado emple, Usuario usu)
        {

            AccesoDatos datos = new AccesoDatos();

            try
            {
               // datos.setearProcedimiento("SP_ALTA_ALUMNO");
                datos.setearParametro("@Usuario", usu.User);
                datos.setearParametro("@Contraseña", usu.Pass);
                datos.setearParametro("@Nombre", emple.Nombre);
                datos.setearParametro("@Apellido", emple.Apellido);
                datos.setearParametro("@DNI", emple.DNI);
                datos.setearParametro("@FechaNacimiento", emple.FechaNacimiento);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
