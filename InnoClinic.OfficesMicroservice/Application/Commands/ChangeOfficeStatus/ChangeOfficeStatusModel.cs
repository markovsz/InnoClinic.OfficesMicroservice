using System.Runtime.Serialization;

namespace Application.Commands.ChangeOfficeStatus;

public class ChangeOfficeStatusModel
{
    [IgnoreDataMember]
    public Guid Id { get; set; }
    public string Status { get; set; }
    public ChangeOfficeStatusModel(Guid id, string status)
    {
        Id = id;
        Status = status;
    }
}
