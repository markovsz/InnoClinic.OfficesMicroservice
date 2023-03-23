using Application.Behaviors;
using Infrastructure.Validators;
using MediatR;
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
                config.AddBehavior(typeof(IPipelineBehavior<,>), typeof(CommandValidationBehavior<,>), ServiceLifetime.Scoped);
                config.AddBehavior(typeof(IPipelineBehavior<,>), typeof(QueryValidationBehavior<,>), ServiceLifetime.Scoped);
                config.Lifetime = ServiceLifetime.Scoped;
            });
        }
    }

}
