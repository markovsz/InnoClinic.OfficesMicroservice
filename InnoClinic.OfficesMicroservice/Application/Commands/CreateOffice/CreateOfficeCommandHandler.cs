using Application.Abstractions.Messaging;
using AutoMapper;
using Domain.Abstractions.CommandRepositories;
using Domain.Entities;
using MediatR;

namespace Application.Commands.CreateOffice
{
    public class CreateOfficeCommandHandler : ICommandHandler<CreateOfficeCommand, Guid>
    {
        private IReadWriteOfficesRepository _officesRepository;
        private IMapper _mapper;

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
