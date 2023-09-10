using AutoMapper;
using WaCollaborative.Common.DTO;
using WaCollaborative.Domain.Entities;

namespace WaCollaborative.Configuration.Mappers
{
    public class StatusMapperProfile : Profile
    {
        public StatusMapperProfile()
        {
            CreateMap<StatusDTO, Status>().ReverseMap();
        }
    }
}