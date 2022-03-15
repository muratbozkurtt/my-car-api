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
using System.Text;
using MyCar.Infrastructure.Helper;
using MyCar.Infrastructure.Constans;

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
            StringBuilder searchQuery = new StringBuilder();
            StringBuilder filterQuery = new StringBuilder();
            StringBuilder query = new StringBuilder();

            searchQuery.Append("Select COUNT(Distinct(Id)) From Advert (nolock) Where 1=1 ");
            filterQuery.Append("Select * From Advert (nolock) Where 1=1 ");

            if (request.CategoryId != null)
            {
                searchQuery.Append(" AND CategoryId=@CategoryId ");
                filterQuery.Append(" AND CategoryId=@CategoryId ");
            }

            if (request.Price != null)
            {
                searchQuery.Append(" AND Price=@Price ");
                filterQuery.Append(" AND Price=@Price ");
            }

            if (request.Gear != null)
            {
                searchQuery.Append(" AND Gear=@Gear ");
                filterQuery.Append(" AND Gear=@Gear ");
            }

            if (request.Fuel != null)
            {
                searchQuery.Append(" AND Fuel=@Fuel ");
                filterQuery.Append(" AND Fuel=@Fuel ");
            }

            query.Append(searchQuery);
            query.Append(filterQuery);

            if (!(request.SortOrder == AdvertSorts.Price || request.SortOrder == AdvertSorts.Km || request.SortOrder == request.Fuel))
            {
                request.SortOrder = "Id";
            }

            query.Append($" ORDER BY {request.SortOrder} DESC OFFSET @PageSize * (@PageNumber-1) ROWS FETCH NEXT @PageSize ROWS ONLY");

            var multipleQuery = await _db.QueryMultipleAsync(query.ToString(),
                              new
                              {
                                  request.PageSize,
                                  request.PageNumber,
                                  request.CategoryId,
                                  request.Price,
                                  request.Gear,
                                  request.Fuel
                              });
            var searchQueryCount = multipleQuery.Read<int>().FirstOrDefault();
            List<Advert> adverts = multipleQuery.Read<Advert>().ToList();
            var result = new PaginatedList<Advert>(adverts, searchQueryCount, request.PageSize, request.PageNumber);
            return result;
        }
        public async Task<Advert> GetAdvertById(int id)
        {
            string query = @"Select * From Advert (nolock) Where Id=@id";
            var result = await _db.QueryAsync<Advert>(query, new { id });
            return result.FirstOrDefault();
        }

        public async Task<bool> AddAdvertVisit(AddAdvertVisitRequest request)
        {
            string query = @"INSERT INTO AdvertVisit(AdvertId,IpAddress,VisitDate) VALUES(@AdvertId,@IpAddress,@VisitDate);
                            SELECT LAST_INSERT_ID();";

            var result = await _db.ExecuteAsync(query, new
            {
                request.AdvertId,
                request.IpAdress,
                request.VisitDate
            });

            return result > 0;
        }
    }
}
