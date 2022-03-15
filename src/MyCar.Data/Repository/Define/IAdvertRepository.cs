using MyCar.Infrastructure.Entity;
using MyCar.Infrastructure.Request;
using MyCar.Infrastructure.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCar.Data.Repository
{
    public interface IAdvertRepository
    {
        Task<PaginatedList<Advert>> GetAdverts(GetAllAdvertsRequest request);
        Task<Advert> GetAdvertById(int id);
        Task<bool> AddAdvertVisit(AddAdvertVisitRequest request);
    }
}
