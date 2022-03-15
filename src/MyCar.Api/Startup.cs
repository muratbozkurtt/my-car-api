using MyCar.Api.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using MyCar.Api.Middleware;
using MyCar.Infrastructure.Context;
using MyCar.Api.Filter;

namespace MyCar.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration )
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo {Title = "MyCar.Api", Version = "v1"});
                c.OperationFilter<SwaggerHeaderParameterOperationFilter>();
            });

            //services.AddAutoMapper(Assembly.GetExecutingAssembly());   
            services.AddControllers().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.Converters.Add(new StringEnumConverter(new CamelCaseNamingStrategy()));
            });

            services.ConfigureRepositoryWrapper(Configuration);
            services.AddScoped<IApplicationContext, ApplicationContext>();

            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin());
            });
            services.AddControllers();
            services.AddMemoryCache();
            services.AddHttpContextAccessor();
            services.AddOptions();
            services.AddControllers().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MyCar.Api v1"));
            }
            // app.UseHttpsRedirection();
            app.UseRouting();
            
            app.UseCors(x => x
                .WithOrigins("http://localhost:5090", "https://localhost:5091", "http://localhost:8080")
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            app.UseMiddleware<ErrorHandlerMiddleware>();

            app.UseAuthorization();
            app.UseAuthentication();          
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}