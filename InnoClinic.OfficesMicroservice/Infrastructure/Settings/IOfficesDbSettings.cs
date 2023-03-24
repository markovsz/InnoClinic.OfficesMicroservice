namespace Infrastructure.Settings
{
    public interface IOfficesDbSettings
    {
        public string OfficesCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
