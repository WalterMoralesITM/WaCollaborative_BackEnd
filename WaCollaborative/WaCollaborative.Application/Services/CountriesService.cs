using AutoMapper;
using WaCollaborative.Common.DTO;
using WaCollaborative.Domain.Entities;
using WaCollaborative.Infrastructure.Repositories;

namespace WaCollaborative.Application.Services
{
    public class CountriesService : BaseService<CountryDTO, Country>, ICountriesService
    {
        private ICountriesRepository _countriesRepository;
        private IMapper _mapper;

        public CountriesService(
            IBaseRepository<Country> repository,
            IMapper mapper,
            ICountriesRepository countriesRepository)
            : base(repository, mapper)
        {
            _countriesRepository = countriesRepository;
            _mapper = mapper;
        }
    }
}