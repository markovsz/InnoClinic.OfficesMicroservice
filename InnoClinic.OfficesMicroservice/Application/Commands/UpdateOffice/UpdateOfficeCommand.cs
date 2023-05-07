using Application.Abstractions.Messaging;
using Application.Shared;
using System.Runtime.Serialization;

namespace Application.Commands.UpdateOffice
{
    public class UpdateOfficeCommand : UpdateOfficeModel, ICommand<Result>
    {
        public UpdateOfficeCommand(Guid id, string photoUrl, string city, string street, string houseNumber, string officeNumber, string registryPhoneNumber, string status)
            : base(id, photoUrl, city, street, houseNumber, officeNumber, registryPhoneNumber, status)
        {
        }
    }
}
