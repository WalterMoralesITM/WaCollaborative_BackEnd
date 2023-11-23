using AutoMapper;
using WaCollaborative.Common.DTO;
using WaCollaborative.Domain.Entities;
using WaCollaborative.Infrastructure.Repositories;

namespace WaCollaborative.Application.Services
{
    public class SegmentsService : BaseService<SegmentDTO, Segment>, ISegmentsService
    {
        private ISegmentsRepository _SegmentsRepository;
        private IMapper _mapper;

        public SegmentsService(
            IBaseRepository<Segment> repository,
            IMapper mapper,
            ISegmentsRepository SegmentsRepository)
            : base(repository, mapper)
        {
            _SegmentsRepository = SegmentsRepository;
            _mapper = mapper;
        }
    }
}