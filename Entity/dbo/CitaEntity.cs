using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CitaEntity 
    {
        public int? IdCita { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public int IdHorario { get; set; }
        public String Inicio { get; }
        public String Fin { get; }
        public int? IdDoctor { get; set; }
        public String Doctor { get; }
        public int IdPaciente { get; set; }
        public String Paciente { get; }
        public int IdServicio { get; set; }
        public String Servicio { get; }
        public String Especialidad { get; }
        public String Cedula { get; }
        public String Telefono { get; }
        public String Consulta { get; }
        public String Procedimiento { get; }
        public String Precio { get; }
    }
}
