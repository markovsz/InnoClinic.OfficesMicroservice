using System.Runtime.Serialization;

namespace Application.Commands.UpdateOffice;

public class UpdateOfficeModel
{
    [IgnoreDataMember]
    public Guid Id { get; set; }
    public string PhotoUrl { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string HouseNumber { get; set; }
    public string OfficeNumber { get; set; }
    public string RegistryPhoneNumber { get; set; }
    public string Status { get; set; }

    public UpdateOfficeModel(Guid id, string photoUrl, string city, string street, string houseNumber, string officeNumber, string registryPhoneNumber, string status)
    {
        Id = id;
        PhotoUrl = photoUrl;
        City = city;
        Street = street;
        HouseNumber = houseNumber;
        OfficeNumber = officeNumber;
        RegistryPhoneNumber = registryPhoneNumber;
        Status = status;
    }
}
