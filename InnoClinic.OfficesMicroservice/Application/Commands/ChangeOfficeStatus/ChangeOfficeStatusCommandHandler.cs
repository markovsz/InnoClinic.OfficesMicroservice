using Application.Abstractions.Messaging;
using Application.Shared;
using Domain.Abstractions.CommandRepositories;
using Domain.Exceptions;

namespace Application.Commands.ChangeOfficeStatus
{
    public class ChangeOfficeStatusCommandHandler : ICommandHandler<ChangeOfficeStatusCommand, Result>
    {
        private IReadWriteOfficesRepository _officesRepository;
        public ChangeOfficeStatusCommandHandler(IReadWriteOfficesRepository officesRepository)
        {
            _officesRepository = officesRepository;
        }

        public async Task<Result> Handle(ChangeOfficeStatusCommand request, CancellationToken cancellationToken)
        {
            var office = await _officesRepository.GetByIdAsync(request.Id);
            if (office is null)
                throw new EntityNotFoundException();
            office.Status = request.Status;
            await _officesRepository.UpdateAsync(office);
            return new Result();
        }
    }
}
