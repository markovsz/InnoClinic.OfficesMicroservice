using Domain.RequestParameters;
using MongoDB.Driver.Linq;

namespace Infrastructure.Extensions
{
    public static class PaginationHandlerExtensions
    {
        public static IMongoQueryable<TEntity> ApplyPagination<TEntity>(this IMongoQueryable<TEntity> entities, PaginationParameters parameters)
        {
            entities = entities
                .Skip((parameters.PageSize - 1) * parameters.Page)
                .Take(parameters.PageSize);
            return entities;
        }
    }
}
