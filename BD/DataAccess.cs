using Dapper;
using Dapper.Mapper;
using Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    public class DataAccess : IDataAccess
    {

        public SqlConnection DbConnection => new SqlConnection(

      new SqlConnectionStringBuilder(ConfigurationManager.AppSettings["Conn"]).ConnectionString);


        public IEnumerable<T> Query<T>(string sp, object Param = null, int? Timeout = null)//Lista de 1 relacio
        {
            try
            {
                using (var exec = DbConnection)
                {
                    exec.Open();

                    var result = exec.Query<T>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure,
                        commandTimeout: Timeout);

                    return result;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public IEnumerable<dynamic> Query(string sp, object Param = null, int? Timeout = null)//Lista Dinámica
        {
            try
            {
                using (var exec = DbConnection)
                {
                    exec.Open();

                    var result = exec.Query(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure,
                        commandTimeout: Timeout);

                    return result;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public IEnumerable<T> Query<T, A>(string sp, string split, object Param = null, int? Timeout = null)//Lista de 2 relaciones
        {
            try
            {
                using (var exec = DbConnection)
                {
                    exec.Open();

                    var result = exec.Query<T, A>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure,
                        commandTimeout: Timeout, splitOn: split);

                    return result;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public IEnumerable<T> Query<T, A, B>(string sp, string split, object Param = null, int? Timeout = null)//Lista de 3 relaciones
        {
            try
            {
                using (var exec = DbConnection)
                {
                    exec.Open();

                    var result = exec.Query<T, A, B>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure,
                        commandTimeout: Timeout, splitOn: split);

                    return result;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public IEnumerable<T> Query<T, A, B, C>(string sp, string split, object Param = null, int? Timeout = null)//Lista de 3 relaciones
        {
            try
            {
                using (var exec = DbConnection)
                {
                    exec.Open();

                    var result = exec.Query<T, A, B, C>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure,
                        commandTimeout: Timeout, splitOn: split);

                    return result;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public IEnumerable<T> Query<T, A, B, C, D>(string sp, string split, object Param = null, int? Timeout = null)//Lista de 3 relaciones
        {
            try
            {
                using (var exec = DbConnection)
                {
                    exec.Open();

                    var result = exec.Query<T, A, B, C, D>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure,
                        commandTimeout: Timeout, splitOn: split);

                    return result;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public IEnumerable<T> Query<T, A, B, C, D, E>(string sp, string split, object Param = null, int? Timeout = null)//Lista de 3 relaciones
        {
            try
            {
                using (var exec = DbConnection)
                {
                    exec.Open();

                    var result = exec.Query<T, A, B, C, D, E>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure,
                        commandTimeout: Timeout, splitOn: split);

                    return result;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public IEnumerable<T> Query<T, A, B, C, D, E, F>(string sp, string split, object Param = null, int? Timeout = null)//Lista de 3 relaciones
        {
            try
            {
                using (var exec = DbConnection)
                {
                    exec.Open();

                    var result = exec.Query<T, A, B, C, D, E, F>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure,
                        commandTimeout: Timeout, splitOn: split);

                    return result;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public T QueryFirst<T>(string sp, object Param = null, int? Timeout = null)//Trae el detalle de un objeto
        {
            try
            {
                using (var exec = DbConnection)
                {
                    exec.Open();

                    var result = exec.QueryFirstOrDefault<T>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure,
                        commandTimeout: Timeout);

                    return result;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public DBEntity Execute(string sp, object Param = null, int? Timeout = null)//Ejecutar acción de insertar 
        {
            try
            {
                using (var exec = DbConnection)
                {
                    exec.Open();

                    var result = exec.ExecuteReader(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure,
                        commandTimeout: Timeout);

                    result.Read();

                    return new DBEntity()
                    {
                        CodeError = result.GetInt32(0),
                        MsgError = result.GetString(1)

                    };
                }
            }
            catch (Exception)
            {

                throw;
            }

        }







    }
}
