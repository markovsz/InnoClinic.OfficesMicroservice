using Application.Abstractions.Messaging;
using Application.Shared;
using AutoMapper;
using Domain.Abstractions.CommandRepositories;
using Domain.Entities;
using Domain.Exceptions;

namespace Application.Commands.UpdateOffice
{
    public class UpdateOfficeCommandHandler : ICommandHandler<UpdateOfficeCommand, Result>
    {
        private readonly IReadWriteOfficesRepository _officesRepository;
        private readonly IMapper _mapper;
        public UpdateOfficeCommandHandler(IReadWriteOfficesRepository officesRepository, IMapper mapper)
        {
            _officesRepository = officesRepository;
            _mapper = mapper;
        }

        public async Task<Result> Handle(UpdateOfficeCommand request, CancellationToken cancellationToken)
        {
            var office = await _officesRepository.GetByIdAsync(request.Id);
            if (office is null)
                throw new EntityNotFoundException();
            var officeForUpdate = _mapper.Map<Office>(request);
            await _officesRepository.UpdateAsync(officeForUpdate);
            return new Result();
        }
    }
}
