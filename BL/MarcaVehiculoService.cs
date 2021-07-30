using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IMarcaVehiculoService
    {
    
        DBEntity Create(MarcaVehiculoEntity entity);
        DBEntity Delete(MarcaVehiculoEntity entity);
        IEnumerable<MarcaVehiculoEntity> Get();
        IEnumerable<MarcaVehiculoEntity> GetLista();
        MarcaVehiculoEntity GetById(MarcaVehiculoEntity entity);
        DBEntity Update(MarcaVehiculoEntity entity);
    }

    public class MarcaVehiculoService : IMarcaVehiculoService
    {
        public IDataAccess sql { get; set; }
        public MarcaVehiculoService()
        {
            sql = new DataAccess();
        }

        //Metódo para obtener los datos en general de Marca Vehiculo
        public IEnumerable<MarcaVehiculoEntity> Get()
        {
            try
            {
                var result = sql.Query<MarcaVehiculoEntity>("MarcaVehiculoObtener");

                return result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public IEnumerable<MarcaVehiculoEntity> GetLista()
        {
            try
            {
                var result = sql.Query<MarcaVehiculoEntity>("MarcaVehiculoLista");

                return result;
            }
            catch (Exception)
            {

                throw;
            }


        }

        //Metódo para obtener el detalle de un registro
        public MarcaVehiculoEntity GetById(MarcaVehiculoEntity entity)
        {
            try
            {
                var result = sql.QueryFirst<MarcaVehiculoEntity>("MarcaVehiculoObtener", new
                {
                    entity.MarcaVehiculoId

                });

                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metódo para crear
        public DBEntity Create(MarcaVehiculoEntity entity)
        {
            try
            {
                var result = sql.Execute("MarcaVehiculoInsertar", new
                {
                    entity.Descripcion,
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
        public DBEntity Update(MarcaVehiculoEntity entity)
        {
            try
            {
                var result = sql.Execute("MarcaVehiculoActualizar", new
                {
                    entity.MarcaVehiculoId,
                    entity.Descripcion,
                    entity.Estado

                });
                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public DBEntity Delete(MarcaVehiculoEntity entity)
        {
            try
            {
                var result = sql.Execute("MarcaVehiculoEliminar", new
                {
                    entity.MarcaVehiculoId


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
