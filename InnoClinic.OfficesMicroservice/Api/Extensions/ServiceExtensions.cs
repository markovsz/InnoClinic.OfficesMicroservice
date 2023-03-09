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
    }
}
