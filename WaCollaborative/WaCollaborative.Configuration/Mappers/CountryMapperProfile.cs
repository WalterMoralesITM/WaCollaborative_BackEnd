using AutoMapper;
using WaCollaborative.Common.DTO;
using WaCollaborative.Domain.Entities;

namespace WaCollaborative.Configuration.Mappers
{
    public class CountryMapperProfile : Profile
    {
        public CountryMapperProfile()
        {
            CreateMap<CountryDTO, Country>().ReverseMap();
        }
    }
}