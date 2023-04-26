using Application.Commands.CreateOffice;
using Application.Commands.UpdateOffice;
using Application.Queries.Responses;
using AutoMapper;
using Domain.Entities;
using Domain.Enums;

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
