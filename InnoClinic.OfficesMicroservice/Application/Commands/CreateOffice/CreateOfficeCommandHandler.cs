using Application.Abstractions.Messaging;
using AutoMapper;
using Domain.Abstractions.CommandRepositories;
using Domain.Entities;

namespace Application.Commands.CreateOffice
{
    public class CreateOfficeCommandHandler : ICommandHandler<CreateOfficeCommand, Guid>
    {
        private readonly IReadWriteOfficesRepository _officesRepository;
        private readonly IMapper _mapper;

        public CreateOfficeCommandHandler(IReadWriteOfficesRepository officesRepository, IMapper mapper)
        {
            _officesRepository = officesRepository;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateOfficeCommand request, CancellationToken cancellationToken)
        {
            var office = _mapper.Map<Office>(request);
            await _officesRepository.CreateAsync(office);
            return office.Id;
        }
    }
}
