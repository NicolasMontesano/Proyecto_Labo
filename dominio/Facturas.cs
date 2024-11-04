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
        public float Monto { get; set; }
        public DateTime FechaDeEmisiom {get; set; }
        public DateTime FechaDePAgo { get; set; }   
        public DateTime FechaDeVencimiento {  get; set; }   


    }
}
