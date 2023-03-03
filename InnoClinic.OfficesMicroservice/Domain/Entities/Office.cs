namespace Domain.Entities
{
    public class Office : BaseEntity
    {
        public string Address { get; set; }
        public Guid PhotoId { get; set; }
        public string RegistryPhoneNumber { get; set; }
        public bool IsActive { get; set; }
    }
}
