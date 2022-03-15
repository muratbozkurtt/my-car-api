using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using System.Linq;
using MyCar.Infrastructure.Entity;
using MyCar.Infrastructure.Request;
using MyCar.Infrastructure.Response;

namespace MyCar.Data.Repository
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
        public async Task<PaginatedList<Advert>> GetAdverts(PaginationRequest paginationRequest)
        {
            string query = @"Select COUNT(*) From Advert (nolock)
                           Select * From Advert (nolock) ORDER BY ID OFFSET @PageSize * (@PageNumber-1) ROWS FETCH NEXT @PageSize ROWS ONLY";

            using var multipleQuery = await _db.QueryMultipleAsync(query, new { paginationRequest.PageSize, paginationRequest.PageNumber });
            var count = multipleQuery.Read<int>().FirstOrDefault();
            List<Advert> adverts = multipleQuery.Read<Advert>().ToList();
            var result = new PaginatedList<Advert>(adverts, count, paginationRequest.PageSize, paginationRequest.PageNumber);
            return result;
        }

        public async Task<Advert> GetAdvertById(int id)
        {
            string query = @"Select * From Advert (nolock) Where Id=@Id";
            var result = await _db.QueryAsync<Advert>(query, new { id });
            return result.FirstOrDefault();
        }
    }
}
