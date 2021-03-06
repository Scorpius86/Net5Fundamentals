using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.Fundamentals.AspNet.Data.Helper
{
    public interface IDapper
    {
        DbConnection GetDbConnection();

        List<T> GetAll<T>(string sql, DynamicParameters param, CommandType commandType = CommandType.StoredProcedure);
        T Get<T>(string sql, DynamicParameters param, CommandType commandType = CommandType.StoredProcedure);
        T Insert<T>(string sql, DynamicParameters param, CommandType commandType = CommandType.StoredProcedure);
        T Update<T>(string sql, DynamicParameters param, CommandType commandType = CommandType.StoredProcedure);
        int Execute(string sql, DynamicParameters param, CommandType commandType = CommandType.StoredProcedure); //Delete or others
    }
}
