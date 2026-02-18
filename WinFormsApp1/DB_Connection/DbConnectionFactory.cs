using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WinFormsApp1.Data
{
    public class DbConnectionFactory : IDbConnectionFactory
    {
        private readonly string _connectionString;

        public DbConnectionFactory()
        {
            _connectionString =
                ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
        }

        public IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
