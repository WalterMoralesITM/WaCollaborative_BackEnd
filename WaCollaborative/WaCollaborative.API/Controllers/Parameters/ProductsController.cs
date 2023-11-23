using Microsoft.AspNetCore.Mvc;
using WaCollaborative.Application.Services;
using WaCollaborative.Common.DTO;

namespace WaCollaborative.API.Controllers.Parameters
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : BaseController<ProductDTO>
    {
        private IProductsService _ProductsService;

        public ProductsController(IProductsService ProductsService) : base(ProductsService)
        {
            _ProductsService = ProductsService;
        }
    }
}