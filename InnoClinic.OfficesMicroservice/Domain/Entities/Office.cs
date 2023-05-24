﻿namespace Domain.Entities
{
    public class Office : BaseEntity
    {
        public string PhotoUrl { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string OfficeNumber { get; set; }
        public string RegistryPhoneNumber { get; set; }
        public string Status { get; set; }
    }
}
