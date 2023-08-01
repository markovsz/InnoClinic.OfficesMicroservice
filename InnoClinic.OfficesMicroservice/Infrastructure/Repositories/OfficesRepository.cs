using Domain.Abstractions;
using Domain.Abstractions.CommandRepositories;
using Domain.Abstractions.QueryRepositories;
using Domain.Entities;
using Domain.RequestParameters;
using Infrastructure.Settings;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Linq.Expressions;

namespace Infrastructure.Repositories
{
    public class OfficesRepository : BaseRepository<Office>, IReadOnlyOfficesRepository, IReadWriteOfficesRepository
    {

        public OfficesRepository(IOfficesDbSettings settings)
            : base(settings, settings.OfficesCollectionName)
        {
        }

        public async Task<int> GetPagesCount(OfficeParameters parameters)
        {
            var entities = await GetByConditionAsync(e => true);
            var filteredEntities = entities
                .Skip((parameters.Page - 1) * parameters.PageSize)
                .Take(parameters.PageSize);
            var entitiesCount = filteredEntities.Count();
            return (entitiesCount + parameters.PageSize - 1) / parameters.PageSize;
        }
    }
}
