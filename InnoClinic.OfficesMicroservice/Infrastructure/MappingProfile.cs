using Application.Commands.CreateOffice;
using Application.Commands.UpdateOffice;
using AutoMapper;
using Domain.Entities;
using InnoClinic.SharedModels.DTOs.Offices.Outgoing;

namespace Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<CreateOfficeCommand, Office>();
            CreateMap<Office, OfficeResponse>();
            CreateMap<Office, OfficeAddressResponse>();
            CreateMap<UpdateOfficeCommand, Office>();
        }
    }
}
