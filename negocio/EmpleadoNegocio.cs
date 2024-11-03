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

        public List<Empleado> Listar()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Empleado> listEmpleado = new List<Empleado>();

            try
            {
                datos.setearConsulta("select IdEmpleado, Nombre, Apellido, FechaNacimiento, DNI, IdUsuario, Activo from Empleados");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Empleado empleado = new Empleado();

                    empleado.Id = (int)datos.Lector["IdEmpleado"];
                    empleado.Nombre = (string)datos.Lector["Nombre"];
                    empleado.Apellido = (string)datos.Lector["Apellido"];
                    empleado.DNI = (string)datos.Lector["DNI"];
                    empleado.IdUsuario = (int)datos.Lector["IdUsuario"];
                    empleado.Activo = (int)datos.Lector["Activo"];

                    if (!Convert.IsDBNull(datos.Lector["FechaNacimiento"]))
                    {
                        empleado.FechaNacimiento = (DateTime)datos.Lector["FechaNacimiento"];
                    }

                    listEmpleado.Add(empleado);

                }

                return listEmpleado;

            }
            catch (Exception ex)
            {

                throw ex ;
            }
            finally
            {
                datos.cerrarConexion();
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
                datos.setearProcedimiento("SP_ALTA_EMPLEADO");
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

        public void Modificar(Empleado emple, Usuario usu)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("sp_Modificar_Empleado_Usuario");
                datos.setearParametro("@Nombre", emple.Nombre);
                datos.setearParametro("@Apellido", emple.Apellido);
                datos.setearParametro("@Idalumno", emple.Id);
                datos.setearParametro("@Fecha", emple.FechaNacimiento);
                datos.setearParametro("@DNI", emple.DNI);
                datos.setearParametro("@idUsuario", emple.IdUsuario);
                datos.setearParametro("@Usuario", usu.User);
                datos.setearParametro("@Contraseña", usu.Pass);

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

        public void eliminarEmpleado(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("update Empleados set Activo = 0 Where IdEmpleado = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Empleado> Filtrar(string campo, string criterio, string filtro)
        {
            AccesoDatos datos =new AccesoDatos();   
            List<Empleado> lista = new List<Empleado>();

            try
            {
                string consulta = "select IdEmpleado, Nombre, Apellido, FechaNacimiento, DNI, IdUsuario, Activo from Empleados Where  ";

                switch (campo)
                {
                    case "Profesor":

                        switch (criterio)
                        {
                            case "Nombre":
                                consulta += "Nombre Like '" + filtro + "' ";
                            break;

                            case "Apellido":
                                consulta += "Apellido Like '"+ filtro +"'";
                                break;

                            case "DNI":
                                consulta += "DNI Like '"+ filtro+ "' ";
                                break;

                            default:
                                break;
                        }
                        break;
                    case "Recepcionista":
                        switch (criterio)
                        {
                            case "Nombre":
                                consulta += "Nombre Like '" + filtro + "' ";
                                break;

                            case "Apellido":
                                consulta += "Apellido Like '" + filtro + "'";
                                break;

                            case "DNI":
                                consulta += "DNI Like '" + filtro + "' ";
                                break;

                            default:
                                break;
                        }
                        break;

                    case "Admin":
                        switch (criterio)
                        {
                            case "Nombre":
                                consulta += "Nombre Like '" + filtro + "' ";
                                break;

                            case "Apellido":
                                consulta += "Apellido Like '" + filtro + "'";
                                break;

                            case "DNI":
                                consulta += "DNI Like '" + filtro + "' ";
                                break;

                            default:
                                break;
                        }
                        break;

                    default:
                        break;
                }

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Empleado empleado = new Empleado();

                    empleado.Id = (int)datos.Lector["IdEmpleado"];
                    empleado.Nombre = (string)datos.Lector["Nombre"];
                    empleado.Apellido = (string)datos.Lector["Apellido"];
                    empleado.DNI = (string)datos.Lector["DNI"];
                    empleado.IdUsuario = (int)datos.Lector["IdUsuario"];
                    empleado.Activo = (int)datos.Lector["Activo"];

                    if (!Convert.IsDBNull(datos.Lector["FechaNacimiento"]))
                    {
                        empleado.FechaNacimiento = (DateTime)datos.Lector["FechaNacimiento"];
                    }

                    lista.Add(empleado);
                }

                    return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
    }
}
