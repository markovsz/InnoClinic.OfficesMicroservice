using System.Linq.Expressions;

namespace Domain.Abstractions.QueryRepositories
{
    public interface IReadOnlyBaseRepository<TEntity>
    {
        Task<TEntity> GetByIdAsync(Guid id);
        Task<IEnumerable<TEntity>> GetAllAsync();
    }
}
