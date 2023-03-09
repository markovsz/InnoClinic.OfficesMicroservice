namespace Infrastructure.Settings
{
    public class OfficesDbSettings : IOfficesDbSettings
    {
        public string OfficesCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
