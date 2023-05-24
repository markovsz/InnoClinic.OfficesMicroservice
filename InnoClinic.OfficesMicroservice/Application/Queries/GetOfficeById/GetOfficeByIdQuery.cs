using Application.Abstractions.Messaging;
using InnoClinic.SharedModels.DTOs.Offices.Incoming.Queries;
using InnoClinic.SharedModels.DTOs.Offices.Outgoing;

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
