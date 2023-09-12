using Microsoft.AspNetCore.Mvc;
using WaCollaborative.Application.Services;
using WaCollaborative.Common.DTO;

namespace WaCollaborative.API.Controllers.Parameters
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountriesController : BaseController<CountryDTO>
    {
        private ICountriesService _countriesService;

        public CountriesController(ICountriesService countriesService) : base(countriesService)
        {
            _countriesService = countriesService;
        }
    }
}