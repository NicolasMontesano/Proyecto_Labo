using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Alumno
    {
        public int idAlumno { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string DNI { get; set; }
        public int IdUsuario { get; set; }
        public decimal Creditos { get; set; }
        public int Estado { get; set; }
    }
}
