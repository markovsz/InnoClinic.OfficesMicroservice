namespace Application.Queries.GetOfficeById;

public class GetOfficeByIdModel
{
    public Guid Id { get; set; }
    public GetOfficeByIdModel(Guid id)
    {
        Id = id;
    }
}
