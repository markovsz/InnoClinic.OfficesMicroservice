using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application
{
    public static class Configure
    {
        public static void ConfigureMediatR(this IServiceCollection services)
        {
            services.AddMediatR(config =>
            {
                config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
                config.Lifetime = ServiceLifetime.Scoped;
            });
        }
    }

}
