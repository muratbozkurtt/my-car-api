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
        public async Task<PaginatedList<Advert>> GetAdverts(GetAllAdvertsRequest request)
        {
            string searchQuery = "Select COUNT(Distinct(Id)) From Advert (nolock) Where 1=1";
            string filterQuery = "Select * From Advert (nolock) Where 1=1";
            var query = string.Concat(searchQuery, filterQuery);

            if (request.CategoryId != null)
            {
                string.Concat(query, "CategoryId=@CategoryId");
                string.Concat(searchQuery, "CategoryId=@CategoryId");
            }

            string.Concat(query, "ORDER BY ID OFFSET @PageSize * (@PageNumber-1) ROWS FETCH NEXT @PageSize ROWS ONLY");

            var multipleQuery = await _db.QueryMultipleAsync(query, new { request.PageSize, request.PageNumber });
            var searchQueryCount = multipleQuery.Read<int>().FirstOrDefault();
            List<Advert> adverts = multipleQuery.Read<Advert>().ToList();
            var result = new PaginatedList<Advert>(adverts, searchQueryCount, request.PageSize, request.PageNumber);
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
