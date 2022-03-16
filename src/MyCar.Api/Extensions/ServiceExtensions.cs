
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using MyCar.Service.Service.Define;
using MyCar.Data;
using MyCar.Data.Repository;
using MyCar.Service.Service;
using MyCar.Data.Migrations;
using FluentMigrator.Runner;

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
            configSection.Bind(settings); ;

            services.AddSingleton<Database>();
            services.AddLogging(c => c.AddFluentMigratorConsole())
            .AddFluentMigratorCore()
            .ConfigureRunner(c => c.AddSqlServer2012()
            //TODO: We can use DBSettings!
           .WithGlobalConnectionString("Server=localhost,1435;database=MyCar;uid=sa;pwd=Mycar123@;Connection Timeout=15;")
           .ScanIn(typeof(InitialTables_202203160001).Assembly).For.Migrations());

            services.Configure<DBSettings>(configuration.GetSection("DBSettings"));
        }
    }
}
