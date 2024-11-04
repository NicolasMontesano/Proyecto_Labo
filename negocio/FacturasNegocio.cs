using dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class FacturasNegocio
    {
        public List<Facturas> Listar()
        {
         List<Facturas> listaFacturas = new List<Facturas>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select IdFactura, IdAlumno, Monto, FechaDeEmision, FechaDePago, FechaDeVencimiento from Facturas");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Facturas factura = new Facturas();

                    factura.IdFactura = (int)datos.Lector["IdFactura"];
                    factura.IdAlumno = (int)datos.Lector["IdALumno"];
                    factura.Monto = (decimal)datos.Lector["Monto"];
                    //factura.MontoTotal = (float)datos.Lector["MontoTotal"];
                    factura.FechaDeEmision = (DateTime)datos.Lector["FechaDeEmision"];
                    factura.FechaDePago = (DateTime)datos.Lector["FechaDePago"];
                    factura.FechaDeVencimiento = (DateTime)datos.Lector["FechaDeVencimiento"];

                    listaFacturas.Add(factura);


                }
                return listaFacturas;

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


        public decimal MontoTotal(int mes) 
        { 
            AccesoDatos datos = new AccesoDatos();
            decimal Monto = 0;
            
            try
            {
                datos.setearProcedimiento("SP_TOTAL_FACTURADO");
                datos.setearParametro("@Fecha", mes);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    if(datos.Lector["TotalFacturado"] != DBNull.Value)
                        Monto = (decimal)datos.Lector["TotalFacturado"];

                }
                return Monto;

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
