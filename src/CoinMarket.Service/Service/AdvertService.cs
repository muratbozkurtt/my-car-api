using AutoMapper;
using CoinMarker.Infrastructure.Dto;
using CoinMarker.Infrastructure.Entity;
using CoinMarker.Infrastructure.Response;
using CoinMarket.Data.Repository;
using CoinMarket.Service.Service.Define;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoinMarket.Service.Service
{
    public class AdvertService : IAdvertService
    {
        private readonly IAdvertRepository _advertRepository;
        private readonly IMapper _mapper;

        public AdvertService(IAdvertRepository advertRepository, IMapper mapper)
        {
            _advertRepository = advertRepository;
            _mapper = mapper;
        }

        public async Task<IDataResult<List<AdvertDto>>> GetAdverts()
        {
            var adverts = await _advertRepository.GetAdverts();
            return new SuccessDataResult<List<AdvertDto>>(_mapper.Map<List<Advert>, List<AdvertDto>>(adverts));
        }
    }
}
