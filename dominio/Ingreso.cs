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
        public int IdAlumno { get; set; }
        public int IdRecepcionista { get; set; }//el que hace el ingreso
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
        public int idDisciplina { get; set; } //la disciplina a la que asistió
        public int idProfesor { get; set; } //el profe de la clase o gym 
    }
}
