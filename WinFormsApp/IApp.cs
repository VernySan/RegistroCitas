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
        public static IMarcaVehiculoService MarcaVehiculoService => new MarcaVehiculoService();
        public static IVehiculoService VehiculoService => new VehiculoService();
        public static IUsuariosService UsuariosServices => new UsuarioService();
    }
}
