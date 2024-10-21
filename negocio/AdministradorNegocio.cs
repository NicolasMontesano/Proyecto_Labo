using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using negocio;

namespace negocio
{
    public class AdministradorNegocio
    {
        public Recepcionista ObtenerRecepcionistaxIdUsuario(int idUsuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select IdRecepcionista,Nombre,Apellido,FechaNacimiento,DNI,IdUsuario from Recepcionistas where idUsuario = @usu");
                datos.setearParametro("@usu", idUsuario);
                datos.ejecutarLectura();

                Recepcionista recepcionista = new Recepcionista();

                while (datos.Lector.Read())
                {
                    recepcionista.Id = (int)datos.Lector["IdRecepcionista"];
                    recepcionista.Nombre = (string)datos.Lector["Usuario"];
                    recepcionista.Apellido = (string)datos.Lector["Apellido"];
                    recepcionista.FechaNacimiento = (DateTime)datos.Lector["FechaNacimiento"];
                    recepcionista.DNI = (string)datos.Lector["DNI"];
                    recepcionista.IdUsuario = (int)datos.Lector["IdUsuario"];
                }

                return recepcionista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public Profesor ObtenerProfesorxIdUsuario(int idUsuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select IdProfesor,Nombre,Apellido,FechaNacimiento,DNI,IdUsuario from Profesores where idUsuario = @usu");
                datos.setearParametro("@usu", idUsuario);
                datos.ejecutarLectura();

                Profesor profesor = new Profesor();

                while (datos.Lector.Read())
                {
                    profesor.Id = (int)datos.Lector["IdRecepcionista"];
                    profesor.Nombre = (string)datos.Lector["Usuario"];
                    profesor.Apellido = (string)datos.Lector["Apellido"];
                    profesor.FechaNacimiento = (DateTime)datos.Lector["FechaNacimiento"];
                    profesor.DNI = (string)datos.Lector["DNI"];
                    profesor.IdUsuario = (int)datos.Lector["IdUsuario"];
                }

                return profesor;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Profesor> ObtenerListaProfesores()
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select IdProfesor,Nombre,Apellido,FechaNacimiento,DNI,IdUsuario from Profesores where activo = 1");
                datos.ejecutarLectura();

                Profesor profesor = new Profesor();
                List<Profesor> listaProfesor = new List<Profesor>();
                while (datos.Lector.Read())
                {
                    profesor.Id = (int)datos.Lector["IdRecepcionista"];
                    profesor.Nombre = (string)datos.Lector["Usuario"];
                    profesor.Apellido = (string)datos.Lector["Apellido"];
                    profesor.FechaNacimiento = (DateTime)datos.Lector["FechaNacimiento"];
                    profesor.DNI = (string)datos.Lector["DNI"];
                    profesor.IdUsuario = (int)datos.Lector["IdUsuario"];
                    
                    listaProfesor.Add(profesor);
                }

                return listaProfesor;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Recepcionista> ObtenerListaRecepcionistas()
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select IdRecepcionista,Nombre,Apellido,FechaNacimiento,DNI,IdUsuario from Recepcionistas where activo = 1");
                datos.ejecutarLectura();

                Recepcionista recepcionista = new Recepcionista();
                List<Recepcionista> listaRecepcionista = new List<Recepcionista>();
                while (datos.Lector.Read())
                {
                    recepcionista.Id = (int)datos.Lector["IdRecepcionista"];
                    recepcionista.Nombre = (string)datos.Lector["Usuario"];
                    recepcionista.Apellido = (string)datos.Lector["Apellido"];
                    recepcionista.FechaNacimiento = (DateTime)datos.Lector["FechaNacimiento"];
                    recepcionista.DNI = (string)datos.Lector["DNI"];
                    recepcionista.IdUsuario = (int)datos.Lector["IdUsuario"];

                    listaRecepcionista.Add(recepcionista);
                }

                return listaRecepcionista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
