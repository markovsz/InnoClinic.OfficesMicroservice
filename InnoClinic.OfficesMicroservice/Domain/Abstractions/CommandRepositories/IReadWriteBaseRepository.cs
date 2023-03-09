using System.Linq.Expressions;

namespace Domain.Abstractions.CommandRepositories
{
    public interface IReadWriteBaseRepository<TEntity>
    {
        Task<TEntity> GetByIdAsync(Guid id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task CreateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
    }
}
