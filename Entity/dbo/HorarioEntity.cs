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
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
    }
}
