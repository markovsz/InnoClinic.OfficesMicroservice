using Domain.Abstractions;
using Domain.Abstractions.CommandRepositories;
using Domain.Abstractions.QueryRepositories;
using Domain.Entities;
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
    }
}
