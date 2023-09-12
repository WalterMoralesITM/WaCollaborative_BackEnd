using AutoMapper;
using WaCollaborative.Common.DTO;
using WaCollaborative.Domain.Entities;

namespace WaCollaborative.Configuration.Mappers
{
    public class CityMapperProfile : Profile
    {
        public CityMapperProfile()
        {
            CreateMap<CityDTO, City>().ReverseMap();
        }
    }
}