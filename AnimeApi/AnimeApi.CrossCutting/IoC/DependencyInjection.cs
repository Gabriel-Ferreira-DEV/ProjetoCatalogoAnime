using AnimeApi.Application.Interfaces;
using AnimeApi.Infrastructure.Context;
using AnimeApi.Infrastructure.Repositories;
using AnimesApi.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AnimeApi.Application.Services;

namespace AnimeApi.CrossCutting.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AdicionarServicos(
            this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));


            services.AddScoped<IAnimesRepository, AnimesRepository>();

            services.AddScoped<IAnimesService, AnimeService>();

            // AutoMapper
            services.AddAutoMapper(typeof(DependencyInjection));

            return services;
        }
    }
}
