using Application.Commands.CreateOffice;
using AutoMapper;
using Domain.Entities;

namespace Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<CreateOfficeCommand, Office>();
        }
    }
}
