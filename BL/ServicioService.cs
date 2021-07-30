﻿using BD;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IServicioService
    {
        DBEntity Create(ServicioEntity entity);
        DBEntity Delete(ServicioEntity entity);
        IEnumerable<ServicioEntity> Get();
        ServicioEntity GetById(ServicioEntity entity);
        DBEntity Update(ServicioEntity entity);
    }

    public class ServicioService : IServicioService
    {
        public IDataAccess sql { get; set; }
        public ServicioService()
        {
            sql = new DataAccess();
        }

        //Metódo para obtener el detalle de un registro
        public ServicioEntity GetById(ServicioEntity entity)
        {
            try
            {
                var result = sql.QueryFirst<ServicioEntity>("ServicioObtener", new
                {
                    entity.IdServicio

                });

                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Metódo para crear
        public DBEntity Create(ServicioEntity entity)
        {
            try
            {
                var result = sql.Execute("ServicioInsertar", new
                {
                    entity.Servicio,
                    entity.Procedimiento,
                    entity.Caracteristicas,
                    entity.Precio,
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
        public DBEntity Update(ServicioEntity entity)
        {
            try
            {
                var result = sql.Execute("ServicioActualizar", new
                {
                    entity.Servicio,
                    entity.Procedimiento,
                    entity.Caracteristicas,
                    entity.Precio,
                    entity.Estado
                });
                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public DBEntity Delete(ServicioEntity entity)
        {
            try
            {
                var result = sql.Execute("ServicioEliminar", new
                {
                    entity.IdServicio
                });
                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public IEnumerable<ServicioEntity> Get()
        {
            throw new NotImplementedException();
        }
    }
}
