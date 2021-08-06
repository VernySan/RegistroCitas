using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class PacienteEntity : EN
    {
        public int? Pasaporte { get; set; }
        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public int IdNacionalidad { get; set; }
        public string Nacionalidad { get; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; }
        public int Telefono { get; set; }
        public string Enfermedades { get; set; }
        public string Alergias { get; set; }
        public string Direccion { get; set; }
    }
}
