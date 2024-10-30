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
        public Ingreso ListarIngreso(string filtro = "", DateTime fecha , int horaDesde = 0, int horaHasta = 0, int minutoDesde = 0, int minutoHasta = 0)
        {
			AccesoDatos datos = new AccesoDatos();
			Ingreso ing = new Ingreso();
			try
			{



				return ing;
			}
			catch (Exception ex)
			{

				throw ex;
			}
        }
    }
}
