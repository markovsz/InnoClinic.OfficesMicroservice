using Application.Abstractions.Messaging;
using MediatR;

namespace Application.Commands.CreateOffice
{
    public class CreateOfficeCommand : ICommand<Guid>
    {
        public string Address { get; set; }
        public Guid PhotoId { get; set; }
        public string RegistryPhoneNumber { get; set; }
        public bool IsActive { get; set; }

        public CreateOfficeCommand(string Address, Guid PhotoId, string RegistryPhoneNumber, bool IsActive)
        {
            this.Address = Address;
            this.PhotoId = PhotoId;
            this.RegistryPhoneNumber = RegistryPhoneNumber;
            this.IsActive = IsActive;
        }
    }
}
