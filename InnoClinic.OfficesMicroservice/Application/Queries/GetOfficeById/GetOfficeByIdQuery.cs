using Application.Abstractions.Messaging;
using Application.Queries.Responses;

namespace Application.Queries.GetOfficeById
{
    public class GetOfficeByIdQuery : GetOfficeByIdModel, IQuery<OfficeResponse>
    {
        public Guid Id { get; set; }
        public GetOfficeByIdQuery(Guid id)
            : base(id)
        {
        }
    }
}
