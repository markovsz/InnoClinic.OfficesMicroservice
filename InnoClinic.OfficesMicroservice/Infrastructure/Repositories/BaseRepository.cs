using Domain.Abstractions.CommandRepositories;
using Domain.Abstractions.QueryRepositories;
using Domain.Entities;
using Infrastructure.Settings;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Linq.Expressions;

namespace Infrastructure.Repositories
{
    public class BaseRepository<TEntity> : IReadOnlyBaseRepository<TEntity>, IReadWriteBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly IMongoCollection<TEntity> _collection;

        public BaseRepository(IOfficesDbSettings settings, string collectionName)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _collection = database.GetCollection<TEntity>(collectionName);
        }

        public async Task CreateAsync(TEntity office) => await _collection.InsertOneAsync(office);

        public async Task DeleteAsync(TEntity office)
        {
            var result = await _collection.DeleteOneAsync(e => e.Id.Equals(office.Id));
            if (!result.IsAcknowledged)
                throw new InvalidOperationException(result.ToJson());
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            var result = await _collection.FindAsync(e => true);
            return result.ToList();
        }

        public async Task<IEnumerable<TEntity>> GetByConditionAsync(Expression<Func<TEntity, bool>> predicate)
        {
            var result = await _collection.FindAsync(predicate);
            return result.ToList();
        }

        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            var result = await _collection.FindAsync(e => e.Id.Equals(id));
            return await result.FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            var result = await _collection.ReplaceOneAsync(e => e.Id.Equals(entity.Id), entity);
            if (!result.IsAcknowledged)
                throw new InvalidOperationException(result.ToJson());
        }
    }
}
