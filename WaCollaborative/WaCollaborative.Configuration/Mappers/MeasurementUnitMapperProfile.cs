using AutoMapper;
using WaCollaborative.Common.DTO;
using WaCollaborative.Domain.Entities;

namespace WaCollaborative.Configuration.Mappers
{
    public class MeasurementUnitMapperProfile : Profile
    {
        public MeasurementUnitMapperProfile()
        {
            CreateMap<MeasurementUnitDTO, MeasurementUnit>().ReverseMap();
        }
    }
}