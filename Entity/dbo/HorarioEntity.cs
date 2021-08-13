using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class HorarioEntity : EN
    {
        public int? IdHorario { get; set; }
        public string Inicio { get; set; }
        public string Fin { get; set; }
        public string Horario { get; }
    }
}
