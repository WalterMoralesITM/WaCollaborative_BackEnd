using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WaCollaborative.Application.Common.Interfaces.Services;
using WaCollaborative.Application.Services;
using WaCollaborative.Configuration.Mappers;
using WaCollaborative.Infrastructure.Data;
using WaCollaborative.Infrastructure.Repositories;
using WaCollaborative.Infrastructure.UnitsOfWork;

namespace WaCollaborative.Configuration.Dependencies
{
    public static class DependecyInjection
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(CountryMapperProfile));
            services.AddAutoMapper(typeof(StatusMapperProfile));
            services.AddDbContext<DataContext>(x => x.UseSqlServer("name=WaCollaborativeConnection"));
            services.AddScoped(typeof(IGenericUnitOfWork<>), typeof(GenericUnitOfWork<>));
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddTransient(typeof(ICountriesRepository), typeof(CountriesRepository));
            services.AddTransient(typeof(IBaseService<,>), typeof(BaseService<,>));
            services.AddTransient(typeof(ICountriesService), typeof(CountriesService));
            services.AddTransient(typeof(IStatusServices), typeof(StatusServices));
            services.AddTransient(typeof(IStatusRepository), typeof(StatusRepository));
        }
    }
}