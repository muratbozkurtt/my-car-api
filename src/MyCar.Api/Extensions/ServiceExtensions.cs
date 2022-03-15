
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using MyCar.Service.Service.Define;
using MyCar.Data;
using MyCar.Data.Repository;
using MyCar.Service.Service;

namespace MyCar.Api.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureRepositoryWrapper(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IAdvertService, AdvertService>();
            services.AddScoped<IAdvertRepository, AdvertRepository>();

            var configSection = configuration.GetSection("DBSettings");
            var settings = new DBSettings();
            configSection.Bind(settings);;

            services.Configure<DBSettings>(configuration.GetSection("DBSettings"));
        }
    }
}
