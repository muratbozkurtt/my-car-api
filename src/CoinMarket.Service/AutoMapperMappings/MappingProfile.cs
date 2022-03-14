using AutoMapper;
using CoinMarker.Infrastructure.Dto;
using CoinMarker.Infrastructure.Entity;
using System;
using System.Linq;

namespace CoinMarker.Infrastructure.AutoMapperMappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AdvertDto, AdvertDto>();
            CreateMap<Advert, AdvertDto>();
        }
    }
}
