using AutoMapper;
using WaCollaborative.Common.DTO;
using WaCollaborative.Domain.Entities;
using WaCollaborative.Infrastructure.Repositories;

namespace WaCollaborative.Application.Services
{
    public class MeasurementUnitsService : BaseService<MeasurementUnitDTO, MeasurementUnit>, IMeasurementUnitsService
    {
        private IMeasurementUnitsRepository _measurementUnitsRepository;
        private IMapper _mapper;

        public MeasurementUnitsService(
            IBaseRepository<MeasurementUnit> repository,
            IMapper mapper,
            IMeasurementUnitsRepository measurementUnitsRepository)
            : base(repository, mapper)
        {
            _measurementUnitsRepository = measurementUnitsRepository;
            _mapper = mapper;
        }
    }
}