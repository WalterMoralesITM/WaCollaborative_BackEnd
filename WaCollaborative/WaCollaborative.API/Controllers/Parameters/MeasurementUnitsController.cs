using Microsoft.AspNetCore.Mvc;
using WaCollaborative.Application.Services;
using WaCollaborative.Common.DTO;

namespace WaCollaborative.API.Controllers.Parameters
{
    [ApiController]
    [Route("api/[controller]")]
    public class MeasurementUnitsController : BaseController<MeasurementUnitDTO>
    {
        private IMeasurementUnitsService _MeasurementUnitsService;

        public MeasurementUnitsController(IMeasurementUnitsService MeasurementUnitsService) : base(MeasurementUnitsService)
        {
            _MeasurementUnitsService = MeasurementUnitsService;
        }
    }
}