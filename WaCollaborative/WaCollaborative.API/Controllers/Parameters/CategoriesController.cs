using Microsoft.AspNetCore.Mvc;
using WaCollaborative.Application.Services;
using WaCollaborative.Common.DTO;

namespace WaCollaborative.API.Controllers.Parameters
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : BaseController<CategoryDTO>
    {
        private ICategoriesService _CategoriesService;

        public CategoriesController(ICategoriesService CategoriesService) : base(CategoriesService)
        {
            _CategoriesService = CategoriesService;
        }
    }
}
