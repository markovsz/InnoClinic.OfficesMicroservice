using Application.Abstractions.Messaging;
using Application.Shared;
using InnoClinic.SharedModels.DTOs.Offices.Incoming.Commands;

namespace Application.Commands.ChangeOfficeStatus
{
    public class ChangeOfficeStatusCommand : ChangeOfficeStatusModel, ICommand<Result>
    {
        public ChangeOfficeStatusCommand(Guid id, string status)
            : base(id, status)
        {
        }
    }
}
