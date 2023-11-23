using AutoMapper;
using WaCollaborative.Common.DTO;
using WaCollaborative.Domain.Entities;
using WaCollaborative.Infrastructure.Repositories;

namespace WaCollaborative.Application.Services
{
    public class ProductsService : BaseService<ProductDTO, Product>, IProductsService
    {
        private IProductsRepository _ProductsRepository;
        private IMapper _mapper;

        public ProductsService(
            IBaseRepository<Product> repository,
            IMapper mapper,
            IProductsRepository ProductsRepository)
            : base(repository, mapper)
        {
            _ProductsRepository = ProductsRepository;
            _mapper = mapper;
        }
    }
}