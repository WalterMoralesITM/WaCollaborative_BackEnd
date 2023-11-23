using AutoMapper;
using WaCollaborative.Common.DTO;
using WaCollaborative.Domain.Entities;
using WaCollaborative.Infrastructure.Repositories;

namespace WaCollaborative.Application.Services
{
    public class CategoriesService : BaseService<CategoryDTO, Category>, ICategoriesService
    {
        private ICategoriesRepository _CategoriesRepository;
        private IMapper _mapper;

        public CategoriesService(
            IBaseRepository<Category> repository,
            IMapper mapper,
            ICategoriesRepository CategoriesRepository)
            : base(repository, mapper)
        {
            _CategoriesRepository = CategoriesRepository;
            _mapper = mapper;
        }
    }
}