using Application.Abstractions.Messaging;
using System.Runtime.Serialization;

namespace Application.Commands.UpdateOffice
{
    public class UpdateOfficeCommand : ICommand
    {
        [IgnoreDataMember]
        public Guid Id { get; set; }
        public Guid PhotoId { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string OfficeNumber { get; set; }
        public string RegistryPhoneNumber { get; set; }
        public string Status { get; set; }

        public UpdateOfficeCommand(Guid id, Guid photoId, string city, string street, string houseNumber, string officeNumber, string registryPhoneNumber, string status)
        {
            Id = id;
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
