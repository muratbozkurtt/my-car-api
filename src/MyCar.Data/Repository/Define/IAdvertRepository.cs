using MyCar.Infrastructure.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCar.Data.Repository
{
    public interface IAdvertRepository
    {
        Task<List<Advert>> GetAdverts();
    }
}
