using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System.Data;
using System.Linq;

namespace MyCar.Data.Migrations
{
    public class Database
    {
        private readonly IOptions<DBSettings> _dBSettings;
        private readonly IDbConnection _db;

        public Database(IOptions<DBSettings> dbSettings)
        {
            _dBSettings = dbSettings;
            _db = new SqlConnection(_dBSettings.Value.MasterConnection);
        }
        public void CreateDatabase(string dbName)
        {
            var query = "SELECT * FROM sys.databases WHERE name = @name";
            var parameters = new DynamicParameters();
            parameters.Add("name", dbName);

            var records = _db.Query(query, parameters);
            if (!records.Any())
                _db.Execute($"CREATE DATABASE {dbName}");

        }

    }
}
