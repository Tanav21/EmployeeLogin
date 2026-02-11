using System.Configuration;
using Microsoft.Data.SqlClient;


namespace WinFormsApp1.Data
{
    public static class DbConnectionFactory
    {
        private static readonly string _connectionString =
            ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;

        public static SqlConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
