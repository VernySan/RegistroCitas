using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IEspecialidadService
    {
        DBEntity Create(EspecialidadEntity entity);
        DBEntity Delete(EspecialidadEntity entity);
        IEnumerable<EspecialidadEntity> Get();
        EspecialidadEntity GetById(EspecialidadEntity entity);
        DBEntity Update(EspecialidadEntity entity);
    }

    public class EspecialidadService : IEspecialidadService
    {
        public IDataAccess sql { get; set; }
        public EspecialidadService()
        {
            sql = new DataAccess();
        }

        //Metódo para obtener los datos en general de Especialidad
        public IEnumerable<EspecialidadEntity> Get()
        {
            try
            {
                var result = sql.Query<EspecialidadEntity>("EspecialidadObtener");

                return result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        //Metódo para obtener el detalle de un registro
        public EspecialidadEntity GetById(EspecialidadEntity entity)
        {
            try
            {
                var result = sql.QueryFirst<EspecialidadEntity>("EspecialidadObtener", new
                {
                    entity.IdEspecialidad

                });

                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metódo para crear
        public DBEntity Create(EspecialidadEntity entity)
        {
            try
            {
                var result = sql.Execute("EspecialidadInsertar", new
                {
                    entity.Especialidad
                });
                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metódo para actualizar
        public DBEntity Update(EspecialidadEntity entity)
        {
            try
            {
                var result = sql.Execute("EspecialidadActualizar", new
                {
                    entity.IdEspecialidad,
                    entity.Especialidad
                });
                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public DBEntity Delete(EspecialidadEntity entity)
        {
            try
            {
                var result = sql.Execute("EspecialidadEliminar", new
                {
                    entity.IdEspecialidad


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
