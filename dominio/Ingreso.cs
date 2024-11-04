using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Ingreso
    {
        public int IdAsistencia { get; set; }
        public int idAlumno { get; set; }
        [DisplayName("Nombre")]
        public string NombreAlumno { get; set; }
        [DisplayName("Apellido")]
        public string ApellidoAlumno { get; set; }
        [DisplayName("DNI")]
        public string DNIAlumno { get; set; }
        public int IdRecepcionista { get; set; }//el que hace el ingreso
        [DisplayName("Fecha y hora de Ingr.")] 
        public DateTime FechaEntrada { get; set; }
        [DisplayName("Fecha y hora de Egr.")]
        public DateTime FechaSalida { get; set; }
    }
}
