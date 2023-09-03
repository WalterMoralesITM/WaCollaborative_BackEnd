namespace WaCollaborative.Infrastructure
{

    #region Import

    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using WaCollaborative.Application.Common.Interfaces;
    using WaCollaborative.Infrastructure.Data;
    using WaCollaborative.Infrastructure.Repositories;

    #endregion Import

    /// <summary>
    /// The class DependecyInjection
    /// </summary>

    public static class DependecyInjection
    {

        /// <summary>
        /// Method add Unit Work
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <returns>IServiceCollection</returns>
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();            
            services.AddDbContext<DataContext>()
            .BuildServiceProvider();
            
            return services;
        }

    }
}