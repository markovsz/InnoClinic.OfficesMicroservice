using Domain.Entities;
using Domain.RequestParameters;

namespace Domain.Abstractions.QueryRepositories
{
    public interface IReadOnlyOfficesRepository : IReadOnlyBaseRepository<Office>
    {
        Task<int> GetPagesCount(OfficeParameters parameters);
    }
}
