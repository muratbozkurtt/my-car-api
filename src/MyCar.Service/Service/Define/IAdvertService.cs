using MyCar.Infrastructure.Entity;
using MyCar.Infrastructure.Request;
using MyCar.Infrastructure.Response;
using System.Threading.Tasks;

namespace MyCar.Service.Service.Define
{
    public interface IAdvertService
    {
        Task<IDataResult<PaginatedList<Advert>>> GetAdverts(GetAllAdvertsRequest request);
        Task<IDataResult<Advert>> GetAdvertById(int id);
    }
}
