using Microsoft.AspNetCore.Builder;
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

            services.AddTransient<SeedDb>();

            services.AddScoped(typeof(IGenericUnitOfWork<>), typeof(GenericUnitOfWork<>));
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddTransient(typeof(IBaseService<,>), typeof(BaseService<,>));

            services.AddTransient(typeof(ICountriesRepository), typeof(CountriesRepository));
            services.AddTransient(typeof(ICountriesService), typeof(CountriesService));

            services.AddTransient(typeof(IStatesRepository), typeof(StatesRepository));
            services.AddTransient(typeof(IStatesService), typeof(StatesService));

            services.AddTransient(typeof(ICitiesRepository), typeof(CitiesRepository));
            services.AddTransient(typeof(ICitiesService), typeof(CitiesService));

            services.AddTransient(typeof(IStatusRepository), typeof(StatusRepository));
            services.AddTransient(typeof(IStatusService), typeof(StatusService));

            services.AddTransient(typeof(IMeasurementUnitsRepository), typeof(MeasurementUnitsRepository));
            services.AddTransient(typeof(IMeasurementUnitsService), typeof(MeasurementUnitsService));

            services.AddTransient(typeof(ICategoriesRepository), typeof(CategoriesRepository));
            services.AddTransient(typeof(ICategoriesService), typeof(CategoriesService));

            services.AddTransient(typeof(ISegmentsRepository), typeof(SegmentsRepository));
            services.AddTransient(typeof(ISegmentsService), typeof(SegmentsService));

            services.AddTransient(typeof(IProductsRepository), typeof(ProductsRepository));
            services.AddTransient(typeof(IProductsService), typeof(ProductsService));
        }

        public static void SeedData(WebApplication app)
        {
            var scopedFactory = app.Services.GetService<IServiceScopeFactory>();
            using (var scope = scopedFactory!.CreateScope())
            {
                var service = scope.ServiceProvider.GetService<SeedDb>();
                service!.SeedAsync().Wait();
            }
        }
    }
}