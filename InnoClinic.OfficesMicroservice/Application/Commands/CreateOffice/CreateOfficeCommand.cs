using Application.Abstractions.Messaging;
using Domain.Enums;

namespace Application.Commands.CreateOffice
{
    public class CreateOfficeCommand : ICommand<Guid>
    {
        public Guid PhotoId { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string OfficeNumber { get; set; }
        public string RegistryPhoneNumber { get; set; }
        public string Status { get; set; }

        public CreateOfficeCommand(Guid photoId, string city, string street, string houseNumber, string officeNumber, string registryPhoneNumber, string status)
        {
            PhotoId = photoId;
            City = city;
            Street = street;
            HouseNumber = houseNumber;
            OfficeNumber = officeNumber;
            RegistryPhoneNumber = registryPhoneNumber;
            Status = status;
        }
    }
}
