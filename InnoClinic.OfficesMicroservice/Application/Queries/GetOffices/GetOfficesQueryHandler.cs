using Application.Abstractions.Messaging;
using Application.Queries.Responses;
using AutoMapper;
using Domain.Abstractions.QueryRepositories;

namespace Application.Queries.GetOffices
{
    public class GetOfficesQueryHandler : IQueryHandler<GetOfficesQuery, OfficesResponse>
    {
        private readonly IReadOnlyOfficesRepository _officesRepository;
        private readonly IMapper _mapper;

        public GetOfficesQueryHandler(IReadOnlyOfficesRepository officesRepository, IMapper mapper) 
        {
            _officesRepository = officesRepository;
            _mapper = mapper;
        }

        public async Task<OfficesResponse> Handle(GetOfficesQuery request, CancellationToken cancellationToken)
        {
            var offices = await _officesRepository.GetAllAsync();
            var mappedOffices = _mapper.Map<IEnumerable<OfficeResponse>>(offices);
            var officesResponse = new OfficesResponse() 
            { 
                Offices = mappedOffices
            };
            return officesResponse;
        }
    }
}
