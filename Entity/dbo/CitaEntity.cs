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
        public DateTime Fecha { get; set; }
        public int IdHorario { get; set; }
        public int IdDoctor { get; set; }
        public int IdPaciente { get; set; }
        public int IdServicio { get; set; }
    }
}
