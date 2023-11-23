using AutoMapper;
using WaCollaborative.Common.DTO;
using WaCollaborative.Domain.Entities;

namespace WaCollaborative.Configuration.Mappers
{
    public class SegmentMapperProfile : Profile
    {
        public SegmentMapperProfile()
        {
            CreateMap<SegmentDTO, Segment>().ReverseMap();
        }
    }
}