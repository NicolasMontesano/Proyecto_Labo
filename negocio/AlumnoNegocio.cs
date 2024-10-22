using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    alumno.Creditos = (int)datos.Lector["Creditos"];
                    alumno.Estado = (int)datos.Lector["Estado"];

                }

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
                datos.setearConsulta("select IdAlumno,Nombre,Apellido,FechaNacimiento,DNI,IdUsuario,Creditos,Estado from alumnos where IdUsuario = 4");
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
                    alumno.Creditos = (int)datos.Lector["Creditos"];
                    alumno.Estado = (int)datos.Lector["Estado"];
                }


                    return listaAl;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }





    }
}
