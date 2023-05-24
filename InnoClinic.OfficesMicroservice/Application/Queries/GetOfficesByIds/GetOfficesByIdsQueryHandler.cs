using Application.Abstractions.Messaging;
using AutoMapper;
using Domain.Abstractions.QueryRepositories;
using InnoClinic.SharedModels.DTOs.Offices.Outgoing;

namespace Application.Queries.GetOfficesByIds;

public class GetOfficesByIdsQueryHandler : IQueryHandler<GetOfficesByIdsQuery, OfficesResponse>
{
    private readonly IReadOnlyOfficesRepository _officesRepository;
    private readonly IMapper _mapper;

    public GetOfficesByIdsQueryHandler(IReadOnlyOfficesRepository officesRepository, IMapper mapper)
    {
        _officesRepository = officesRepository;
        _mapper = mapper;
    }

    public async Task<OfficesResponse> Handle(GetOfficesByIdsQuery request, CancellationToken cancellationToken)
    {
        var offices = new OfficesResponse();
        var officesList = new List<OfficeAddressResponse>();
        foreach (var id in request.Ids)
        {
            var office = await _officesRepository.GetByIdAsync(id);
            var mappedOffice = _mapper.Map<OfficeAddressResponse>(office);
            officesList.Add(mappedOffice);
        }
        offices.Offices = officesList;
        return offices;
    }
}
