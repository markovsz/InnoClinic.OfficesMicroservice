using Application.Abstractions.Messaging;
using Application.Queries.Responses;
using Domain.RequestParameters;

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
