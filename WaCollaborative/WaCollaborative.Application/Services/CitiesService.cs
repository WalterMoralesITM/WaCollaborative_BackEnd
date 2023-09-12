using AutoMapper;
using WaCollaborative.Common.DTO;
using WaCollaborative.Domain.Entities;
using WaCollaborative.Infrastructure.Repositories;

namespace WaCollaborative.Application.Services
{
    public class CitiesService : BaseService<CityDTO, City>, ICitiesService
    {
        private ICitiesRepository _citiesRepository;
        private IMapper _mapper;

        public CitiesService(
            IBaseRepository<City> repository,
            IMapper mapper,
            ICitiesRepository citiesRepository)
            : base(repository, mapper)
        {
            _citiesRepository = citiesRepository;
            _mapper = mapper;
        }
    }
}