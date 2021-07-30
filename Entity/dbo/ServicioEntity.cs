using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ServicioEntity : EN
    {
        public int? IdServicio { get; set; }
        public string Servicio { get; set; }
        public string Procedimiento { get; set; }
        public string Caracteristicas { get; set; }
        public double Precio { get; set; }
    }
}
