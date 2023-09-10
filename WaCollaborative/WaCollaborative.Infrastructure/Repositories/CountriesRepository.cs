using WaCollaborative.Domain.Entities;
using WaCollaborative.Infrastructure.Data;

namespace WaCollaborative.Infrastructure.Repositories
{
    public class CountriesRepository : BaseRepository<Country>, ICountriesRepository
    {
        public DataContext Context
        {
            get
            {
                return (DataContext)_context;
            }
        }

        public CountriesRepository(DataContext Context) : base(Context)
        {
        }
    }
}