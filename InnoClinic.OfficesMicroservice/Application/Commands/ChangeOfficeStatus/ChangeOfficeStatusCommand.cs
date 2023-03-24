using Application.Abstractions.Messaging;
using Application.Shared;
using Domain.Enums;
using System.Runtime.Serialization;

namespace Application.Commands.ChangeOfficeStatus
{
    public class ChangeOfficeStatusCommand : ICommand<Result>
    {
        [IgnoreDataMember]
        public Guid Id { get; set; }
        public string Status { get; set; }
        public ChangeOfficeStatusCommand(Guid id, string status) 
        {
            Id = id;
            Status = status;
        }
    }
}
