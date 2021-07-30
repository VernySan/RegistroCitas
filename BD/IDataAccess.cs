using Entity;
using System.Collections.Generic;

namespace BD
{
    public interface IDataAccess
    {
        DBEntity Execute(string sp, object Param = null, int? Timeout = null);
        IEnumerable<dynamic> Query(string sp, object Param = null, int? Timeout = null);
        IEnumerable<T> Query<T, A, B, C, D, E, F>(string sp, string split, object Param = null, int? Timeout = null);
        IEnumerable<T> Query<T, A, B, C, D, E>(string sp, string split, object Param = null, int? Timeout = null);
        IEnumerable<T> Query<T, A, B, C, D>(string sp, string split, object Param = null, int? Timeout = null);
        IEnumerable<T> Query<T, A, B, C>(string sp, string split, object Param = null, int? Timeout = null);
        IEnumerable<T> Query<T, A, B>(string sp, string split, object Param = null, int? Timeout = null);
        IEnumerable<T> Query<T, A>(string sp, string split, object Param = null, int? Timeout = null);
        IEnumerable<T> Query<T>(string sp, object Param = null, int? Timeout = null);
        T QueryFirst<T>(string sp, object Param = null, int? Timeout = null);
    }
}