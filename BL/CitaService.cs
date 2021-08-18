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
        IEnumerable<CitaEntity> GetByDate(CitaEntity entity);
        IEnumerable<CitaEntity> Listar();
        IEnumerable<CitaEntity> ListarByDate(CitaEntity entity);
        CitaEntity GetById(CitaEntity entity);
        CitaEntity ListarById(CitaEntity entity);
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

        public IEnumerable<CitaEntity> GetByDate(CitaEntity entity)
        {
            try
            {
                var result = sql.Query<CitaEntity>("CitaObtener", new
                {
                    entity.IdCita,
                    entity.Fecha

                });


                return result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        //Metódo para listar de Citas
        public IEnumerable<CitaEntity> Listar()
        {
            try
            {
                var result = sql.Query<CitaEntity>("CitaListar");

                return result;
            }
            catch (Exception)
            {
                throw;
            }


        }

        public IEnumerable<CitaEntity> ListarByDate(CitaEntity entity)
        {
            try
            {
                var result = sql.Query<CitaEntity>("CitaListar", new
                {
                    entity.Fecha
                });


                return result;
            }
            catch (Exception)
            {
                throw;
            }


        }

        //Metódo para obtener el detalle de un registro por Id
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

        //Metódo para listar el detalle de un registro por Id
        public CitaEntity ListarById(CitaEntity entity)
        {
            try
            {
                var result = sql.QueryFirst<CitaEntity>("CitaListar", new
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
