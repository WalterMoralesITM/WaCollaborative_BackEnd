using AutoMapper;
using WaCollaborative.Common.DTO;
using WaCollaborative.Domain.Entities;
using WaCollaborative.Infrastructure.Repositories;

namespace WaCollaborative.Application.Services
{
    public class StatesService : BaseService<StateDTO, State>, IStatesService
    {
        private IStatesRepository _statesRepository;
        private IMapper _mapper;

        public StatesService(
            IBaseRepository<State> repository,
            IMapper mapper,
            IStatesRepository statesRepository)
            : base(repository, mapper)
        {
            _statesRepository = statesRepository;
            _mapper = mapper;
        }

        public override async Task<IEnumerable<StateDTO>> GetAsync()
        {
            IEnumerable<State> states = await _statesRepository.GetAsync();
            return _mapper.Map<IEnumerable<StateDTO>>(states);
        }

        public override async Task<StateDTO> GetAsync(int id)
        {
            State state = await _statesRepository.GetAsync(id);
            return _mapper.Map<StateDTO>(state);
        }
    }
}