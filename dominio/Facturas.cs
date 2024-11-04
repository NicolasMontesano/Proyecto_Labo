using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Facturas
    {

        public int IdFactura { get; set; }
        public int IdAlumno { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaDeEmision {get; set; }
        public DateTime FechaDePago { get; set; }   
        public DateTime FechaDeVencimiento {  get; set; }
        public float MontoTotal { get; set; }

    }
}
