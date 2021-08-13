using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DoctorEntity : EN
    {
        public int? Cedula { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public int IdEspecialidad { get; set; }
        public string Especialidad { get;  }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        public string Doctor { get; }
    }
}
