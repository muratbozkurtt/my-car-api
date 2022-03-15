using MyCar.Infrastructure.Entity;
using MyCar.Infrastructure.Request;
using MyCar.Infrastructure.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCar.Data.Repository
{
    public interface IAdvertRepository
    {
        Task<PaginatedList<Advert>> GetAdvertsAsync(GetAllAdvertsRequest request);
        Task<Advert> GetAdvertByIdAsync(int id);
        Task<bool> AddAdvertVisitAsync(AddAdvertVisitRequest request);
    }
}
