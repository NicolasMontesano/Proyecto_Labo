using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class IngresoNegocio
    {
        public List<Ingreso> ListarIngreso(DateTime fecha , string filtro = "",  int horaDesde = 0, int horaHasta = 23, int minutoDesde = 0, int minutoHasta = 59)
        {
			AccesoDatos datos = new AccesoDatos();
			List<Ingreso> listar = new List<Ingreso>();

			try
			{
				datos.setearProcedimiento("spListarIngreso");
				datos.setearParametro("@fecha", fecha);
				datos.setearParametro("@filtro", filtro);
				datos.setearParametro("@horaDesde", horaDesde);
				datos.setearParametro("@horaHasta", horaHasta);
				datos.setearParametro("@minutoDesde", minutoDesde);
				datos.setearParametro("@minutoHasta", minutoHasta);

				datos.ejecutarLectura();

				while (datos.Lector.Read())
				{
					Ingreso ing = new Ingreso();

					ing.IdAsistencia = (int)datos.Lector["IdAsistencia"];
					ing.idAlumno = (int)datos.Lector["IdAlumno"];
					ing.NombreAlumno = (string)datos.Lector["Nombre"];
					ing.ApellidoAlumno = (string)datos.Lector["Apellido"];
					ing.DNIAlumno = (string)datos.Lector["DNI"];
					ing.IdRecepcionista = (int)datos.Lector["IdEmpleado"];
					ing.FechaEntrada = Convert.ToDateTime(datos.Lector["FechaEntrada"]);
					if (datos.Lector["FechaSalida"] != DBNull.Value)
						ing.FechaSalida = Convert.ToDateTime(datos.Lector["FechaSalida"]);

					listar.Add(ing);
				}

				return listar;
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
