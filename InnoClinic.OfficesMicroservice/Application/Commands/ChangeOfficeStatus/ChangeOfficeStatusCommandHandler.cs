using Application.Abstractions.Messaging;
using Domain.Abstractions.CommandRepositories;

namespace Application.Commands.ChangeOfficeStatus
{
    public class ChangeOfficeStatusCommandHandler : ICommandHandler<ChangeOfficeStatusCommand>
    {
        private IReadWriteOfficesRepository _officesRepository;
        public ChangeOfficeStatusCommandHandler(IReadWriteOfficesRepository officesRepository)
        {
            _officesRepository = officesRepository;
        }

        public async Task Handle(ChangeOfficeStatusCommand request, CancellationToken cancellationToken)
        {
            var office = await _officesRepository.GetByIdAsync(request.Id);
            office.Status = request.Status;
            await _officesRepository.UpdateAsync(office);
        }
    }
}
