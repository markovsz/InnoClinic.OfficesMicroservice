using Domain.Entities;

namespace Application.Queries.Responses
{
    public class OfficesResponse
    {
        public IEnumerable<OfficeResponse> Offices { get; set; }
    }
}
