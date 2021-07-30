using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface ICitaService
    {
        DBEntity Create(CitaEntity entity);
        DBEntity Delete(CitaEntity entity);
        IEnumerable<CitaEntity> Get();
        CitaEntity GetById(CitaEntity entity);
        DBEntity Update(CitaEntity entity);
    }

    public class CitaService : ICitaService
    {
        public IDataAccess sql { get; set; }
        public CitaService()
        {
            sql = new DataAccess();
        }

        //Metódo para obtener los datos en general de Citas
        public IEnumerable<CitaEntity> Get()
        {
            try
            {
                var result = sql.Query<CitaEntity>("CitaObtener");

                return result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        //Metódo para obtener el detalle de un registro
        public CitaEntity GetById(CitaEntity entity)
        {
            try
            {
                var result = sql.QueryFirst<CitaEntity>("CitaObtener", new
                {
                    entity.IdCita

                });

                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metódo para crear
        public DBEntity Create(CitaEntity entity)
        {
            try
            {
                var result = sql.Execute("CitaInsertar", new
                {
                    entity.IdCita,
                    entity.Fecha,
                    entity.IdHorario,
                    entity.IdDoctor,
                    entity.IdPaciente,
                    entity.IdServicio
                });
                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metódo para actualizar
        public DBEntity Update(CitaEntity entity)
        {
            try
            {
                var result = sql.Execute("CitaActualizar", new
                {
                    entity.IdCita,
                    entity.Fecha,
                    entity.IdHorario,
                    entity.IdDoctor,
                    entity.IdPaciente,
                    entity.IdServicio
                });
                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public DBEntity Delete(CitaEntity entity)
        {
            try
            {
                var result = sql.Execute("CitaEliminar", new
                {
                    entity.IdCita
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
