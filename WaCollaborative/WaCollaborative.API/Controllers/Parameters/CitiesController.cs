using Microsoft.AspNetCore.Mvc;
using WaCollaborative.Application.Services;
using WaCollaborative.Common.DTO;

namespace WaCollaborative.API.Controllers.Parameters
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitiesController : BaseController<CityDTO>
    {
        private ICitiesService _citiesService;

        public CitiesController(ICitiesService citiesService) : base(citiesService)
        {
            _citiesService = citiesService;
        }
    }
}