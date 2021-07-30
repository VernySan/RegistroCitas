using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IPacienteService
    {
        DBEntity Create(PacienteEntity entity);
        DBEntity Delete(PacienteEntity entity);
        IEnumerable<PacienteEntity> Get();
        PacienteEntity GetById(PacienteEntity entity);
        DBEntity Update(PacienteEntity entity);
    }

    public class PacienteService : IPacienteService
    {
        public IDataAccess sql { get; set; }
        public PacienteService()
        {
            sql = new DataAccess();
        }

        //Metódo para obtener el detalle de un registro
        public PacienteEntity GetById(PacienteEntity entity)
        {
            try
            {
                var result = sql.QueryFirst<PacienteEntity>("PacienteObtener", new
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
        public DBEntity Create(PacienteEntity entity)
        {
            try
            {
                var result = sql.Execute("PacienteInsertar", new
                {
                    entity.Cedula,
                    entity.Nombre,
                    entity.PrimerApellido,
                    entity.SegundoApellido,
                    entity.IdNacionalidad,
                    entity.FechaNacimiento,
                    entity.Telefono,
                    entity.Enfermedades,
                    entity.Alergias,
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
        public DBEntity Update(PacienteEntity entity)
        {
            try
            {
                var result = sql.Execute("PacienteActualizar", new
                {
                    entity.Cedula,
                    entity.Nombre,
                    entity.PrimerApellido,
                    entity.SegundoApellido,
                    entity.IdNacionalidad,
                    entity.FechaNacimiento,
                    entity.Telefono,
                    entity.Enfermedades,
                    entity.Alergias,
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

        public DBEntity Delete(PacienteEntity entity)
        {
            try
            {
                var result = sql.Execute("PacienteEliminar", new
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

        public IEnumerable<PacienteEntity> Get()
        {
            throw new NotImplementedException();
        }
    }
}
