using Application.Abstractions.Messaging;
using Domain.RequestParameters;
using InnoClinic.SharedModels.DTOs.Offices.Outgoing;

namespace Application.Queries.GetOffices
{
    public class GetOfficesQuery : OfficeParameters, IQuery<OfficesResponse>
    {
        public GetOfficesQuery(int page, int pageSize) 
        {
            Page = page;
            PageSize = pageSize;
        }
        
        public GetOfficesQuery(OfficeParameters parameters) 
        {
            Page = parameters.Page;
            PageSize = parameters.PageSize;
        }
    }
}
