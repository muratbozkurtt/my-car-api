using MyCar.Data.Repository;
using MyCar.Infrastructure.Entity;
using MyCar.Infrastructure.Request;
using MyCar.Infrastructure.Response;
using MyCar.Service.Service.Define;
using System.Threading.Tasks;

namespace MyCar.Service.Service
{
    public class AdvertService : IAdvertService
    {
        private readonly IAdvertRepository _advertRepository;

        public AdvertService(IAdvertRepository advertRepository)
        {
            _advertRepository = advertRepository;
        }

        //TODO: we can use auto mapper or converter for dtos
        public async Task<IDataResult<PaginatedList<Advert>>> GetAdverts(PaginationRequest paginationRequest)
        {
            var adverts = await _advertRepository.GetAdverts(paginationRequest);
            return new SuccessDataResult<PaginatedList<Advert>>(adverts);
        }

        public async Task<IDataResult<Advert>> GetAdvertById(int id)
        {
            var advert = await _advertRepository.GetAdvertById(id);
            return new SuccessDataResult<Advert>(advert);
        }
    }
}
