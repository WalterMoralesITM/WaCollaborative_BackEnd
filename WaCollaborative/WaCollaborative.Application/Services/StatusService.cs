namespace WaCollaborative.Application.Services
{
    using AutoMapper;
    using WaCollaborative.Application.Common.Interfaces.Services;
    using WaCollaborative.Common.DTO;
    using WaCollaborative.Domain.Entities;
    using WaCollaborative.Infrastructure.Repositories;

    public class StatusService : BaseService<StatusDTO, Status>, IStatusService
    {
        private IStatusRepository _statusRepository;
        private IMapper _mapper;

        public StatusService(
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