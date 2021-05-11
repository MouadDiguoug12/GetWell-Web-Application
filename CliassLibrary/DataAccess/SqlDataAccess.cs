using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CliassLibrary.DataAccess
{
    public class SqlDataAccess
    {
        public static string GetConnectionString(string connectionName = "db_a7366b_getwellEntities3")
        {
            return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }

        public static List<T> LoadData<T>(string sql)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Query<T>(sql).ToList();
            }
        }

        public static void SaveDataWithoutTransiction<T>(string sql, T data)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                cnn.Open();

                cnn.Execute(sql: sql,param: data, commandType: CommandType.StoredProcedure, commandTimeout: 100);
            }
        }

        public static int SaveData<T>(string sql, T data)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                cnn.Open();

                var trc = cnn.BeginTransaction();

                int result = cnn.Execute(sql, data, trc, 10, CommandType.StoredProcedure);

                if (result == 1)
                {
                    trc.Commit();
                }
                else
                {
                    trc.Rollback();
                }
                
                return result;
            }
        }

        public static int ReturnsSingleValue(string sql,DynamicParameters cin)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.ExecuteScalar<int>(sql: sql, param: cin, commandTimeout: 50,commandType: CommandType.Text);
            }
        }
    }
}
