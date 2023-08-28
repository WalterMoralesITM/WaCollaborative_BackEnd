namespace WaCollaborative.Application
{

    #region Import

    using FluentValidation.AspNetCore;
    using Microsoft.Extensions.DependencyInjection;
    using WaCollaborative.Application.Common.Interfaces.Services;
    using WaCollaborative.Application.Services;

    #endregion Import

    /// <summary>
    /// The class DependecyInjection
    /// </summary>

    public static class DependecyInjection
    {

        #region Methods

        /// <summary>
        /// Injection Configuration and Services
        /// </summary>
        /// <param name="services"></param>
        /// <returns>IServiceCollection</returns>
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            _ = services.AddFluentValidationAutoValidation().AddFluentValidationClientsideAdapters();

            services.AddTransient<IStatusServices, StatusServices>();

            return services;
        }

        #endregion Methods

    }
}