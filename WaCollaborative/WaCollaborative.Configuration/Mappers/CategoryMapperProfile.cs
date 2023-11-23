using AutoMapper;
using WaCollaborative.Common.DTO;
using WaCollaborative.Domain.Entities;

namespace WaCollaborative.Configuration.Mappers
{
    public class CategoryMapperProfile : Profile
    {
        public CategoryMapperProfile()
        {
            CreateMap<CategoryDTO, Category>().ReverseMap();
        }
    }
}