using CoinMarker.Infrastructure.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoinMarket.Data.Repository
{
    public interface IAdvertRepository
    {
        Task<List<Advert>> GetAdverts();
    }
}
