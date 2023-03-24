using Domain.Abstractions.CommandRepositories;
using Domain.Abstractions.QueryRepositories;
using FluentValidation;
using Infrastructure.Repositories;
using Infrastructure.Settings;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;

namespace Api.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureDb(this IServiceCollection services, IConfiguration configuration)
        {
            BsonSerializer.RegisterSerializer(new GuidSerializer(BsonType.String));

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
        
        public static void ConfigureValidators(this IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(Application.AssemblyReference.Assembly);
        }
    }
}
