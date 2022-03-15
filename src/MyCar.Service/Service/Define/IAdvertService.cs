using MyCar.Infrastructure.Dto;
using MyCar.Infrastructure.Entity;
using MyCar.Infrastructure.Request;
using MyCar.Infrastructure.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCar.Service.Service.Define
{
    public interface IAdvertService
    {
        Task<IDataResult<PaginatedList<Advert>>> GetAdverts(PaginationRequest paginationRequest);
        Task<IDataResult<Advert>> GetAdvertById(int id);
    }
}
