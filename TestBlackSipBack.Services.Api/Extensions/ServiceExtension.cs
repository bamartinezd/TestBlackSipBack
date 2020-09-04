using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBlackSip.Domain.Contracts;
using TestBlackSipBack.Data.DataAccess.Repositories;
using TestBlackSipBack.Domain.Entities;

namespace TestBlackSipBack.Services.Api.Extensions
{
    public static class ServiceExtension
    {
        #region Cors Implementation
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                    });
            });
        }
        #endregion

        #region Dependency Injection
        public static void ConfigureDependencies(this IServiceCollection services)
        {
            services.AddScoped<IGenericCUDRepository<Registro>, RegistroRepository>();
            services.AddScoped<IGenericGetRepository<MenuItem>, MenuItemRepository>();
        }
        #endregion
    }
}
