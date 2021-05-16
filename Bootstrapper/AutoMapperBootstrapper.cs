using Microsoft.Extensions.DependencyInjection;
using System;

namespace Bootstrapper
{
    public static class AutoMapperBootstrapper
    {
        public static IServiceCollection AddMapper(this IServiceCollection services, Type type)
        {
            services.AddAutoMapper(type);
            return services;
        }
    }
}
