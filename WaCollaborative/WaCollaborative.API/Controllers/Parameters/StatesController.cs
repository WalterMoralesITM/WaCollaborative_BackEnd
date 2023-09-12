using Microsoft.AspNetCore.Mvc;
using WaCollaborative.Application.Services;
using WaCollaborative.Common.DTO;

namespace WaCollaborative.API.Controllers.Parameters
{
    [ApiController]
    [Route("api/[controller]")]
    public class StatesController : BaseController<StateDTO>
    {
        private IStatesService _statesService;

        public StatesController(IStatesService statesService) : base(statesService)
        {
            _statesService = statesService;
        }
    }
}