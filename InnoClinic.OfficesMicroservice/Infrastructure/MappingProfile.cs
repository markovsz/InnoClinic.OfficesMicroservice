using Application.Commands.CreateOffice;
using Application.Commands.UpdateOffice;
using Application.Queries.GetOffices;
using AutoMapper;
using Domain.Entities;
using Domain.RequestParameters;
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
            CreateMap<GetOfficesQuery, OfficeParameters>();
            CreateMap<UpdateOfficeCommand, Office>();
        }
    }
}
