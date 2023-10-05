using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;

namespace SOLID.SRP.EmployeeArchitecure
{
    internal class DatabaseConnectionManager : DbContext
    {
        private static DatabaseConnectionManager? _instance;  // Change to nullable


        private DatabaseConnectionManager(DbContextOptions<DatabaseConnectionManager> options) : base(options) { }

        public static DatabaseConnectionManager GetInstance()
        {
            if (_instance == null)
            {
                var builder = new SqlConnectionStringBuilder
                {
                    DataSource = ".",
                    InitialCatalog = "Employee",
                    IntegratedSecurity = true,
                    TrustServerCertificate = true,
                };

                var optionsBuilder = new DbContextOptionsBuilder<DatabaseConnectionManager>()
                    .UseSqlServer(builder.ConnectionString);

                _instance = new DatabaseConnectionManager(optionsBuilder.Options);
            }

            return _instance;
        }

        public static void Disconnect()
        {
            if (_instance != null)
            {
                _instance.Dispose();
                _instance = null;
            }
        }
    }
}
