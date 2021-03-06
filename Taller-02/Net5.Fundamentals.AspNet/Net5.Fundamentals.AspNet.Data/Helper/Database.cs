using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.Fundamentals.AspNet.Data.Helper
{
    public class Database : IDapper
    {
        private readonly IConfiguration _config;
        private string Connectionstring = "BikeStoresConnection";

        public Database(IConfiguration config)
        {
            _config = config;
        }

        public int Execute(string sql, DynamicParameters param, CommandType commandType = CommandType.StoredProcedure)
        {
            int result;
            using (IDbConnection db = new SqlConnection(_config.GetConnectionString(Connectionstring)))
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                    }

                    using (IDbTransaction tran = db.BeginTransaction())
                    {
                        try
                        {
                            result = db.Execute(sql, commandType: commandType, transaction: tran);
                            tran.Commit();
                        }
                        catch (Exception ex)
                        {
                            tran.Rollback();
                            throw ex;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (db.State == ConnectionState.Open)
                    {
                        db.Close();
                    }
                }
            }

            return result;
        }

        public T Get<T>(string sql, DynamicParameters param, CommandType commandType = CommandType.StoredProcedure)
        {
            using (IDbConnection db = new SqlConnection(_config.GetConnectionString(Connectionstring)))
            {
                return db.Query<T>(sql, commandType: commandType).FirstOrDefault();
            }
        }

        public List<T> GetAll<T>(string sql, DynamicParameters param, CommandType commandType = CommandType.StoredProcedure)
        {
            using (IDbConnection db = new SqlConnection(_config.GetConnectionString(Connectionstring)))
            {
                return db.Query<T>(sql, commandType: commandType).ToList();
            }
        }

        public DbConnection GetDbConnection()
        {
            return new SqlConnection(_config.GetConnectionString(Connectionstring));
        }

        public T Insert<T>(string sql, DynamicParameters param, CommandType commandType = CommandType.StoredProcedure)
        {
            T result;
            using (IDbConnection db = new SqlConnection(_config.GetConnectionString(Connectionstring)))
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                    }

                    using (IDbTransaction tran = db.BeginTransaction())
                    {
                        try
                        {
                            result = db.Query<T>(sql, commandType: commandType, transaction: tran).FirstOrDefault();
                            tran.Commit();
                        }
                        catch (Exception ex)
                        {
                            tran.Rollback();
                            throw ex;
                        }
                    }
                }catch(Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if(db.State == ConnectionState.Open)
                    {
                        db.Close();
                    }
                }
            }

            return result;
        }

        public T Update<T>(string sql, DynamicParameters param, CommandType commandType = CommandType.StoredProcedure)
        {
            T result;
            using (IDbConnection db = new SqlConnection(_config.GetConnectionString(Connectionstring)))
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                    }

                    using (IDbTransaction tran = db.BeginTransaction())
                    {
                        try
                        {
                            result = db.Query<T>(sql, commandType: commandType, transaction: tran).FirstOrDefault();
                            tran.Commit();
                        }
                        catch (Exception ex)
                        {
                            tran.Rollback();
                            throw ex;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (db.State == ConnectionState.Open)
                    {
                        db.Close();
                    }
                }
            }

            return result;
        }
    }
}
