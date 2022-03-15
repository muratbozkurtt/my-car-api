using MyCar.Data.Repository;
using MyCar.Infrastructure.Context;
using MyCar.Infrastructure.Entity;
using MyCar.Infrastructure.Helper;
using MyCar.Infrastructure.Request;
using MyCar.Infrastructure.Response;
using MyCar.Service.Service.Define;
using System.Threading.Tasks;

namespace MyCar.Service.Service
{
    public class AdvertService : IAdvertService
    {
        private readonly IAdvertRepository _advertRepository;
        private readonly IApplicationContext _applicationContext;

        public AdvertService(IAdvertRepository advertRepository, IApplicationContext applicationContext)
        {
            _advertRepository = advertRepository;
            _applicationContext = applicationContext;
        }

        //TODO: we can use auto mapper or converter for dtos
        public async Task<IDataResult<PaginatedList<Advert>>> GetAdverts(GetAllAdvertsRequest request)
        {
            var adverts = await _advertRepository.GetAdverts(request);
            return new SuccessDataResult<PaginatedList<Advert>>(adverts);
        }

        public async Task<IDataResult<Advert>> GetAdvertById(int id)
        {
            var advert = await _advertRepository.GetAdvertById(id);
            return new SuccessDataResult<Advert>(advert);
        }

        public async Task<IDataResult<bool>> AddAdvertVisit(int advertId)
        {
            var advert = await _advertRepository.GetAdvertById(advertId);
            if (advert == null)
            {
                return new ErrorDataResult<bool>(MessageWrite.Write("No advert found."));
            }
            var addAdvertVisit = new AddAdvertVisitRequest()
            {
                AdvertId = advertId,
                IpAdress = _applicationContext.IpAddress,
                VisitDate = System.DateTime.Now
            };
            var result = await _advertRepository.AddAdvertVisit(addAdvertVisit);
            return new SuccessDataResult<bool>(result);
        }
    }
}
