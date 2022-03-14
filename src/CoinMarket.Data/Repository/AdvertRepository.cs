using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using CoinMarker.Infrastructure.Entity;
using System.Linq;

namespace CoinMarket.Data.Repository
{
    public class AdvertRepository : IAdvertRepository
    {
        private readonly IOptions<DBSettings> _dBSettings;
        private readonly IDbConnection _db;

        public AdvertRepository(IOptions<DBSettings> dbSettings)
        {
            _dBSettings = dbSettings;
            _db = new SqlConnection(_dBSettings.Value.DatabaseConnection);
        }
        public async Task<List<Advert>> GetAdverts()
        {
            string query = @"Select * From Advert (nolock)";
            var result = await _db.QueryAsync<Advert>(query);
            return result.ToList();
        }
    }
}
