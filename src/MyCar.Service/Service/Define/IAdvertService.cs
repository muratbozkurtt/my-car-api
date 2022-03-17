using MyCar.Data.Entity;
using MyCar.Infrastructure.Request;
using MyCar.Infrastructure.Response;
using System.Threading.Tasks;

namespace MyCar.Service.Service.Define
{
    public interface IAdvertService
    {
        Task<IDataResult<PaginatedList<Advert>>> GetAdvertsAsync(GetAllAdvertsRequest request);
        Task<IDataResult<Advert>> GetAdvertByIdAsync(int id);
        Task<IDataResult<bool>> AddAdvertVisitAsync(int advertId);
    }
}
