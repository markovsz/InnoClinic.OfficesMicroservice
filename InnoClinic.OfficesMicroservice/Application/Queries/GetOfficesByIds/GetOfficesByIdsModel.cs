namespace Application.Queries.GetOfficesByIds;

public class GetOfficesByIdsModel
{
    public IEnumerable<Guid> Ids { get; set; }
    public GetOfficesByIdsModel(IEnumerable<Guid> ids)
    {
        Ids = ids;
    }
}
