using CoinMarker.Infrastructure.Dto;
using CoinMarker.Infrastructure.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoinMarket.Service.Service.Define
{
    public interface IAdvertService
    {
        Task<IDataResult<List<AdvertDto>>> GetAdverts();
    }
}
