using Application.Abstractions.Messaging;
using InnoClinic.SharedModels.DTOs.Offices.Incoming.Queries;
using InnoClinic.SharedModels.DTOs.Offices.Outgoing;

namespace Application.Queries.GetOfficesByIds;

public class GetOfficesByIdsQuery : GetOfficesByIdsModel, IQuery<OfficesResponse>
{
    public GetOfficesByIdsQuery(IEnumerable<Guid> ids)
        : base(ids)
    {
    }
}
