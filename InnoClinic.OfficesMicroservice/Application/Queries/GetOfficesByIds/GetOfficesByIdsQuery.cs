using Application.Abstractions.Messaging;
using Application.Queries.Responses;

namespace Application.Queries.GetOfficesByIds;

public class GetOfficesByIdsQuery : GetOfficesByIdsModel, IQuery<OfficesResponse>
{
    public IEnumerable<Guid> Ids { get; set; }
    public GetOfficesByIdsQuery(IEnumerable<Guid> ids)
        : base(ids)
    {
    }
}
