using CoinMarket.Data;
using CoinMarket.Data.Repository;
using CoinMarket.Service.Service;
using CoinMarket.Service.Service.Define;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using AutoMapper;
using CoinMarker.Infrastructure.AutoMapperMappings;

namespace CoinMarket.Api.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureRepositoryWrapper(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IAdvertService, AdvertService>();
            services.AddScoped<IAdvertRepository, AdvertRepository>();

            var configSection = configuration.GetSection("DBSettings");
            var settings = new DBSettings();
            configSection.Bind(settings);

            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.Configure<DBSettings>(configuration.GetSection("DBSettings"));

        }
    }
}
