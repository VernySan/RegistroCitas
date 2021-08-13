using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IUsuariosService
    {
        UsuariosEntity Login(UsuariosEntity entity);
        DBEntity Registrar(UsuariosEntity entity);
    }

    public class UsuarioService : IUsuariosService
    {
        public IDataAccess sql { get; set; }

        public UsuarioService()
        {
            sql = new DataAccess();
        }



        public UsuariosEntity Login(UsuariosEntity entity)
        {
            try
            {
                var result = sql.QueryFirst<UsuariosEntity>("Login", new
                {
                    entity.Usuario,
                    entity.Contrasena
                });

                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }



        public DBEntity Registrar(UsuariosEntity entity)
        {

            try
            {
                var result = sql.Execute("UsuarioRegistrar", new
                {
                    entity.Usuario,
                    entity.Nombre,
                    entity.Contrasena
                });

                return result;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
