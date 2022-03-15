using AutoMapper;
using MyCar.Infrastructure.Dto;
using MyCar.Infrastructure.Entity;

namespace MyCar.Infrastructure.AutoMapperMappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AdvertDto, AdvertDto>().ReverseMap();
            CreateMap<Advert, AdvertDto>().ReverseMap();
        }
    }
}
