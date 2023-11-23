using Microsoft.AspNetCore.Mvc;
using WaCollaborative.Application.Services;
using WaCollaborative.Common.DTO;

namespace WaCollaborative.API.Controllers.Parameters
{
    [ApiController]
    [Route("api/[controller]")]
    public class SegmentsController : BaseController<SegmentDTO>
    {
        private ISegmentsService _SegmentsService;

        public SegmentsController(ISegmentsService SegmentsService) : base(SegmentsService)
        {
            _SegmentsService = SegmentsService;
        }
    }
}