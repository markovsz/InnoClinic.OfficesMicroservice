using Application.Abstractions.Messaging;
using AutoMapper;
using Domain.Abstractions.QueryRepositories;
using InnoClinic.SharedModels.DTOs.Offices.Outgoing;

namespace Application.Queries.GetOfficeById
{
    public class GetOfficeByIdQueryHandler : IQueryHandler<GetOfficeByIdQuery, OfficeResponse>
    {
        private readonly IReadOnlyOfficesRepository _officesRepository;
        private readonly IMapper _mapper;

        public GetOfficeByIdQueryHandler(IReadOnlyOfficesRepository officesRepository, IMapper mapper)
        { 
            _officesRepository = officesRepository;
            _mapper = mapper;
        }

        public async Task<OfficeResponse> Handle(GetOfficeByIdQuery request, CancellationToken cancellationToken)
        {
            var office = await _officesRepository.GetByIdAsync(request.Id);
            var officeResponse = _mapper.Map<OfficeResponse>(office);
            return officeResponse;
        }
    }
}
