using Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Service;

namespace $safeprojectname$
{
    public static class DependencyInjectionBootstrapper
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IDbContext, DbContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
