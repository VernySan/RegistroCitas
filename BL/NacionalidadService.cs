using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface INacionalidadService
    {
        DBEntity Create(NacionalidadEntity entity);
        DBEntity Delete(NacionalidadEntity entity);
        IEnumerable<NacionalidadEntity> Get();
        NacionalidadEntity GetById(NacionalidadEntity entity);
        DBEntity Update(NacionalidadEntity entity);
    }

    public class NacionalidadService : INacionalidadService
    {
        public IDataAccess sql { get; set; }
        public NacionalidadService()
        {
            sql = new DataAccess();
        }

        //Metódo para obtener los datos en general de Nacionalidad
        public IEnumerable<NacionalidadEntity> Get()
        {
            try
            {
                var result = sql.Query<NacionalidadEntity>("NacionalidadObtener");

                return result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        //Metódo para obtener el detalle de un registro
        public NacionalidadEntity GetById(NacionalidadEntity entity)
        {
            try
            {
                var result = sql.QueryFirst<NacionalidadEntity>("NacionalidadObtener", new
                {
                    entity.IdNacionalidad

                });

                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metódo para crear
        public DBEntity Create(NacionalidadEntity entity)
        {
            try
            {
                var result = sql.Execute("NacionalidadInsertar", new
                {
                    entity.Nacionalidad
                });
                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metódo para actualizar
        public DBEntity Update(NacionalidadEntity entity)
        {
            try
            {
                var result = sql.Execute("NacionalidadActualizar", new
                {
                    entity.IdNacionalidad,
                    entity.Nacionalidad
                });
                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public DBEntity Delete(NacionalidadEntity entity)
        {
            try
            {
                var result = sql.Execute("NacionalidadEliminar", new
                {
                    entity.IdNacionalidad


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
