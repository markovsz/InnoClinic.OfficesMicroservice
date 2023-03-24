using Application.Abstractions.Messaging;
using Application.Queries.Responses;

namespace Application.Queries.GetOfficeById
{
    public class GetOfficeByIdQuery : IQuery<OfficeResponse>
    {
        public Guid Id { get; set; }
        public GetOfficeByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}
