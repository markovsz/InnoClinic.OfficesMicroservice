namespace Application.Commands.CreateOffice;

public class CreateOfficeModel
{
    public string PhotoUrl { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string HouseNumber { get; set; }
    public string OfficeNumber { get; set; }
    public string RegistryPhoneNumber { get; set; }
    public string Status { get; set; }

    public CreateOfficeModel(string photoUrl, string city, string street, string houseNumber, string officeNumber, string registryPhoneNumber, string status)
    {
        PhotoUrl = photoUrl;
        City = city;
        Street = street;
        HouseNumber = houseNumber;
        OfficeNumber = officeNumber;
        RegistryPhoneNumber = registryPhoneNumber;
        Status = status;
    }
}
