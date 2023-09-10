using Microsoft.AspNetCore.Mvc;
using WaCollaborative.Application.Services;
using WaCollaborative.Common.DTO;
using WaCollaborative.Domain.Entities;

namespace WaCollaborative.API.Controllers.Parameters
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountriesController : BaseController<CountryDTO, CountryDTO>
    {
        private ICountriesService _countriesService;

        public CountriesController(ICountriesService countriesService) : base(countriesService)
        {
            _countriesService = countriesService;
        }
    }
}