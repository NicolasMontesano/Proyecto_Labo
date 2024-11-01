using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using dominio;


namespace negocio
{
    public class UsuarioNegocio
    {
        public List<TipoUsuario> listar()
        {
            List<TipoUsuario> lista = new List<TipoUsuario>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT Id, Descripcion FROM TipoUsuarios");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    TipoUsuario cate = new TipoUsuario
                    {
                        Id = (int)datos.Lector["Id"],
                        Descripcion = (string)datos.Lector["Descripcion"]
                    };

                    lista.Add(cate);
                }

                return lista;
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
        public Usuario Login(string User, string Pass)
        {
			AccesoDatos datos = new AccesoDatos();
			try
			{
				datos.setearConsulta("select Id,Usuario,Contraseña,Tipo from Usuarios where Usuario = @usu and Contraseña = @pass");
				datos.setearParametro("@usu", User);
				datos.setearParametro("@pass", Pass);
				datos.ejecutarLectura();

				Usuario usu = new Usuario();

				while (datos.Lector.Read())
				{
					usu.Id = (int)datos.Lector["Id"];
					usu.User = (string)datos.Lector["Usuario"];
					usu.Pass= (string)datos.Lector["Contraseña"];
					usu.TipoUsuario = (int)datos.Lector["Tipo"];
				}

				return usu;
			}
			catch (Exception ex)
			{

				throw ex;
			}
        }

		public void agregar(Usuario usu)
		{
			AccesoDatos datos = new AccesoDatos();


			try
			{
				datos.setearConsulta("INSERT INTO Usuarios (Usuario, Contraseña, Tipo) VALUES ('" + usu.User + "', '" + usu.Pass + "', 4);");
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

        public Usuario ObtenerUsuario(int idUsuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select Id,Usuario,Contraseña,Tipo from Usuarios where Id = @id ");
                datos.setearParametro("@id", idUsuario);
                datos.ejecutarLectura();

                Usuario usu = new Usuario();

                while (datos.Lector.Read())
                {
                    usu.Id = (int)datos.Lector["Id"];
                    usu.User = (string)datos.Lector["Usuario"];
                    usu.Pass = (string)datos.Lector["Contraseña"];
                    usu.TipoUsuario = (int)datos.Lector["Tipo"];
                }

                return usu;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
