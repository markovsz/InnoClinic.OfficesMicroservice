﻿using Application.Abstractions.Messaging;
using Application.Queries.Responses;

namespace Application.Queries.GetOfficesByIds;

public class GetOfficesByIdsQuery : GetOfficesByIdsModel, IQuery<OfficesResponse>
{
    public GetOfficesByIdsQuery(IEnumerable<Guid> ids)
        : base(ids)
    {
    }
}
