using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Ingreso
    {
        public int IdAsistencia { get; set; }
        public int idAlumno { get; set; }
        public string NombreAlumno { get; set; }
        public string ApellidoAlumno { get; set; }
        public string DNIAlumno { get; set; }
        public int IdRecepcionista { get; set; }//el que hace el ingreso
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
    }
}
