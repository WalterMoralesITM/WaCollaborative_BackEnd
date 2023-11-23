namespace WaCollaborative.API.Controllers.Parameters
{
    using Microsoft.AspNetCore.Mvc;
    using WaCollaborative.Application.Common.Interfaces.Services;
    using WaCollaborative.Common.DTO;

    [ApiController]
    [Route("api/[controller]")]
    public class StatusController : BaseController<StatusDTO>
    {
        private readonly IStatusService _statusServices;

        public StatusController(IStatusService statusServices): base(statusServices)
        {
            _statusServices = statusServices;
        }
    }
}