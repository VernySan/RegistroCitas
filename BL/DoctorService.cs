using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IDoctorService
    {
        DBEntity Create(DoctorEntity entity);
        DBEntity Delete(DoctorEntity entity);
        IEnumerable<DoctorEntity> Get();
        DoctorEntity GetById(DoctorEntity entity);
        DBEntity Update(DoctorEntity entity);
    }

    public class DoctorService : IDoctorService
    {
        public IDataAccess sql { get; set; }
        public DoctorService()
        {
            sql = new DataAccess();
        }

        //Metódo para obtener el detalle de un registro
        public DoctorEntity GetById(DoctorEntity entity)
        {
            try
            {
                var result = sql.QueryFirst<DoctorEntity>("DoctorObtener", new
                {
                    entity.Cedula

                });

                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metódo para crear
        public DBEntity Create(DoctorEntity entity)
        {
            try
            {
                var result = sql.Execute("DoctorInsertar", new
                {
                    entity.Cedula,
                    entity.Nombre,
                    entity.PrimerApellido,
                    entity.SegundoApellido,
                    entity.IdEspecialidad,
                    entity.Telefono,
                    entity.Direccion,
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
        public DBEntity Update(DoctorEntity entity)
        {
            try
            {
                var result = sql.Execute("DoctorActualizar", new
                {
                    entity.Cedula,
                    entity.Nombre,
                    entity.PrimerApellido,
                    entity.SegundoApellido,
                    entity.IdEspecialidad,
                    entity.Telefono,
                    entity.Direccion,
                    entity.Estado

                });
                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public DBEntity Delete(DoctorEntity entity)
        {
            try
            {
                var result = sql.Execute("DoctorEliminar", new
                {
                    entity.Cedula
                });
                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public IEnumerable<DoctorEntity> Get()
        {
            throw new NotImplementedException();
        }
    }
}
