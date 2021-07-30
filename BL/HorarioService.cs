using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IHorarioService
    {
        DBEntity Create(HorarioEntity entity);
        DBEntity Delete(HorarioEntity entity);
        IEnumerable<HorarioEntity> Get();
        HorarioEntity GetById(HorarioEntity entity);
        DBEntity Update(HorarioEntity entity);
    }

    public class HorarioService : IHorarioService
    {
        public IDataAccess sql { get; set; }
        public HorarioService()
        {
            sql = new DataAccess();
        }

        //Metódo para obtener el detalle de un registro
        public HorarioEntity GetById(HorarioEntity entity)
        {
            try
            {
                var result = sql.QueryFirst<HorarioEntity>("HorarioObtener", new
                {
                    entity.IdHorario

                });

                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metódo para crear
        public DBEntity Create(HorarioEntity entity)
        {
            try
            {
                var result = sql.Execute("HorarioInsertar", new
                {
                    entity.Inicio,
                    entity.Fin,
                    entity.Estado

                });
                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metódo para actualizar
        public DBEntity Update(HorarioEntity entity)
        {
            try
            {
                var result = sql.Execute("HorarioActualizar", new
                {
                    entity.Inicio,
                    entity.Fin,
                    entity.Estado

                });
                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public DBEntity Delete(HorarioEntity entity)
        {
            try
            {
                var result = sql.Execute("HorarioEliminar", new
                {
                    entity.IdHorario
                });
                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public IEnumerable<HorarioEntity> Get()
        {
            throw new NotImplementedException();
        }
    }
}
