using WaCollaborative.Domain.Entities;
using WaCollaborative.Infrastructure.Data;

namespace WaCollaborative.Infrastructure.Repositories
{
    public class ProductsRepository : BaseRepository<Product>, IProductsRepository
    {
        public DataContext Context
        {
            get
            {
                return (DataContext)_context;
            }
        }

        public ProductsRepository(DataContext Context) : base(Context)
        {
        }
    }
}