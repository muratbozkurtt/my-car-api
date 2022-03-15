using MyCar.Infrastructure.Dto;
using MyCar.Infrastructure.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCar.Service.Service.Define
{
    public interface IAdvertService
    {
        Task<IDataResult<List<AdvertDto>>> GetAdverts();
        Task<IDataResult<AdvertDto>> GetAdvertById(int id);
    }
}
