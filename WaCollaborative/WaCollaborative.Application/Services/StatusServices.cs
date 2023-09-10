namespace WaCollaborative.Application.Services
{
    using AutoMapper;
    using WaCollaborative.Application.Common.Interfaces.Services;
    using WaCollaborative.Common.DTO;
    using WaCollaborative.Domain.Entities;
    using WaCollaborative.Infrastructure.Repositories;

    public class StatusServices : BaseService<StatusDTO, Status>, IStatusServices
    {
        private IStatusRepository _statusRepository;
        private IMapper _mapper;

        public StatusServices(
            IBaseRepository<Status> repository,
            IMapper mapper,
            IStatusRepository statusRepository)
            : base(repository, mapper)
        {
            _statusRepository = statusRepository;
            _mapper = mapper;
        }
    }
}