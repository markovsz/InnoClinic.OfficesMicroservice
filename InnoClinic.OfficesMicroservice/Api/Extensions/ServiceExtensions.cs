using Domain.Abstractions.CommandRepositories;
using Domain.Abstractions.QueryRepositories;
using Infrastructure.Repositories;
using Infrastructure.Settings;
using Microsoft.Extensions.Options;

namespace Api.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureDb(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<OfficesDbSettings>(
                configuration.GetSection(nameof(OfficesDbSettings)));
            services.AddSingleton<IOfficesDbSettings>(provider =>
                provider.GetRequiredService<IOptions<OfficesDbSettings>>().Value);
        }

        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddScoped<IReadOnlyOfficesRepository, OfficesRepository>();
            services.AddScoped<IReadWriteOfficesRepository, OfficesRepository>();
        }
    }
}
