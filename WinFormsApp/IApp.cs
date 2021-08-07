using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;

namespace WinFormsApp
{
    public struct IApp
    {
        public static IUsuariosService UsuariosServices => new UsuarioService();
        public static IEspecialidadService EspecialidadService => new EspecialidadService();
        public static IServicioService ServicioService => new ServicioService();
        public static INacionalidadService NacionalidadService => new NacionalidadService();
        public static IHorarioService HorarioService => new HorarioService();
        public static IDoctorService DoctorService => new DoctorService();
        public static IPacienteService PacienteService => new PacienteService();
        public static ICitaService CitaService => new CitaService();
    }
}
