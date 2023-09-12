using AutoMapper;
using WaCollaborative.Common.DTO;
using WaCollaborative.Domain.Entities;

namespace WaCollaborative.Configuration.Mappers
{
    public class StateMapperProfile : Profile
    {
        public StateMapperProfile()
        {
            CreateMap<StateDTO, State>().ReverseMap();
        }
    }
}