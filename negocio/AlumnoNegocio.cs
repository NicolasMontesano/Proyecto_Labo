using dominio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace negocio
{
    public class AlumnoNegocio
    {
        public Alumno ObtenerAlumnoxIdUsuario(int idUsuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select IdAlumno,Nombre,Apellido,FechaNacimiento,DNI,IdUsuario,Creditos,Estado from alumnos where idUsuario = @usu");
                datos.setearParametro("@usu", idUsuario);
                datos.ejecutarLectura();

                Alumno alumno = new Alumno();

                while (datos.Lector.Read())
                {
                    alumno.idAlumno = (int)datos.Lector["IdAlumno"];
                    alumno.Nombre = (string)datos.Lector["Usuario"];
                    alumno.Apellido = (string)datos.Lector["Apellido"];
                    alumno.FechaNacimiento = (DateTime)datos.Lector["FechaNacimiento"];
                    alumno.DNI = (string)datos.Lector["DNI"];
                    alumno.IdUsuario = (int)datos.Lector["IdUsuario"];
                    //alumno.Creditos = (int)datos.Lector["Creditos"];
                    alumno.Estado = (int)datos.Lector["Estado"];

                }
                datos.cerrarConexion();

                return alumno;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Alumno> Listar()
        {
            List<Alumno> listaAl = new List<Alumno>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                //datos.setearConsulta("select AL.IdAlumno, AL.Nombre, AL.Apellido, AL.FechaNacimiento, AL.DNI, AL.IdUsuario,AL.Creditos, AL.Estado from Alumnos as AL inner Join Usuarios As U on U.Id = AL.IdUsuario inner join TipoUsuarios as TU On TU.Id = U.Tipo Where TU.Id=4");
                datos.setearConsulta("select AL.IdAlumno, AL.Nombre, AL.Apellido, AL.FechaNacimiento, AL.DNI, AL.IdUsuario, AL.Estado from Alumnos as AL ");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {

                    Alumno alumno = new Alumno();

                    alumno.idAlumno = (int)datos.Lector["IdAlumno"];
                    alumno.Nombre = (string)datos.Lector["Nombre"];
                    alumno.Apellido = (string)datos.Lector["Apellido"];
                    //alumno.FechaNacimiento = (DateTime)datos.Lector["FechaNacimiento"];

                    if (!Convert.IsDBNull(datos.Lector["FechaNacimiento"]))
                    {
                        alumno.FechaNacimiento = (DateTime)datos.Lector["FechaNacimiento"];
                    }


                    alumno.DNI = (string)datos.Lector["DNI"];
                    alumno.IdUsuario = (int)datos.Lector["IdUsuario"];

                    //alumno.Creditos = (int)datos.Lector["Creditos"];

                    //if (!Convert.IsDBNull(datos.Lector["Creditos"]))
                    //{
                    //    alumno.Creditos = (int)datos.Lector["Creditos"];
                    //}

                    alumno.Estado = (int)datos.Lector["Estado"];

                    listaAl.Add(alumno);
                }

                return listaAl;
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

        public void agregar(Alumno alu)
        {

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("INSERT INTO Alumnos (Nombre, Apellido, FechaNacimiento, DNI, IdUsuario, Creditos, Estado) VALUES ('" + alu.Nombre + "', '" + alu.Apellido + "', '" + alu.FechaNacimiento + "', '" + alu.DNI + "', 4, 1, 1)");
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
        public void agregar_Sp(Alumno alu, Usuario usu)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("SP_ALTA_ALUMNO");
                datos.setearParametro("@Usuario", usu.User);
                datos.setearParametro("@Contraseña", usu.Pass);
                datos.setearParametro("@Nombre", alu.Nombre);
                datos.setearParametro("@Apellido", alu.Apellido);
                datos.setearParametro("@DNI", alu.DNI);
                datos.setearParametro("@FechaNacimiento", alu.FechaNacimiento);

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
        public void eliminarAlumno(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("update Alumnos set Estado = 0 Where idAlumno = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modificar(Alumno al, Usuario usu)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                //datos.setearConsulta("update Alumnos set  Nombre = @Nombre, Apellido = @Apellido, DNI = @DNI where IdAlumno = @Idalumno");
                datos.setearProcedimiento("sp_Modificar_Alumno_Usuario");
                datos.setearParametro("@Nombre", al.Nombre);
                datos.setearParametro("@Apellido", al.Apellido);
                datos.setearParametro("@Idalumno", al.idAlumno);
                datos.setearParametro("@Fecha", al.FechaNacimiento);
                datos.setearParametro("@DNI", al.DNI);
                datos.setearParametro("@idUsuario", al.IdUsuario);
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

        public Alumno ObtenerAlumnoxDNI(string DNI)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select IdAlumno,Nombre,Apellido,FechaNacimiento,DNI,IdUsuario,Creditos,Estado from alumnos where DNI = @DNI");
                datos.setearParametro("@DNI", DNI);
                datos.ejecutarLectura();

                Alumno alumno = new Alumno();

                while (datos.Lector.Read())
                {
                    alumno.idAlumno = (int)datos.Lector["IdAlumno"];
                    alumno.Nombre = (string)datos.Lector["Usuario"];
                    alumno.Apellido = (string)datos.Lector["Apellido"];
                    alumno.FechaNacimiento = (DateTime)datos.Lector["FechaNacimiento"];
                    alumno.DNI = (string)datos.Lector["DNI"];
                    alumno.IdUsuario = (int)datos.Lector["IdUsuario"];
                    //alumno.Creditos = (int)datos.Lector["Creditos"];
                    alumno.Estado = (int)datos.Lector["Estado"];

                }
                datos.cerrarConexion();

                return alumno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<Alumno> ListarAlInactivos()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Alumno> listaInac = new List<Alumno>();

            try
            {
                datos.setearConsulta("select AL.IdAlumno, AL.Nombre, AL.Apellido, AL.FechaNacimiento, AL.DNI, AL.IdUsuario, AL.Estado from Alumnos as AL where Estado = 0");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {

                    Alumno alumno = new Alumno();

                    alumno.idAlumno = (int)datos.Lector["IdAlumno"];
                    alumno.Nombre = (string)datos.Lector["Nombre"];
                    alumno.Apellido = (string)datos.Lector["Apellido"];
                    //alumno.FechaNacimiento = (DateTime)datos.Lector["FechaNacimiento"];

                    if (!Convert.IsDBNull(datos.Lector["FechaNacimiento"]))
                    {
                        alumno.FechaNacimiento = (DateTime)datos.Lector["FechaNacimiento"];
                    }


                    alumno.DNI = (string)datos.Lector["DNI"];
                    alumno.IdUsuario = (int)datos.Lector["IdUsuario"];
                    alumno.Estado = (int)datos.Lector["Estado"];

                    listaInac.Add(alumno);
                }

                return listaInac;
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

        public List<Alumno> ListarAlActivos()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Alumno> listaInac = new List<Alumno>();

            try
            {
                datos.setearConsulta("select AL.IdAlumno, AL.Nombre, AL.Apellido, AL.FechaNacimiento, AL.DNI, AL.IdUsuario, AL.Estado from Alumnos as AL where Estado = 1");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {

                    Alumno alumno = new Alumno();

                    alumno.idAlumno = (int)datos.Lector["IdAlumno"];
                    alumno.Nombre = (string)datos.Lector["Nombre"];
                    alumno.Apellido = (string)datos.Lector["Apellido"];
                    //alumno.FechaNacimiento = (DateTime)datos.Lector["FechaNacimiento"];

                    if (!Convert.IsDBNull(datos.Lector["FechaNacimiento"]))
                    {
                        alumno.FechaNacimiento = (DateTime)datos.Lector["FechaNacimiento"];
                    }


                    alumno.DNI = (string)datos.Lector["DNI"];
                    alumno.IdUsuario = (int)datos.Lector["IdUsuario"];
                    alumno.Estado = (int)datos.Lector["Estado"];

                    listaInac.Add(alumno);
                }

                return listaInac;
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
