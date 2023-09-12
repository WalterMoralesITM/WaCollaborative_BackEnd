using WaCollaborative.Domain.Entities;
using WaCollaborative.Infrastructure.Data;

namespace WaCollaborative.Infrastructure.Repositories
{
    public class CitiesRepository : BaseRepository<City>, ICitiesRepository
    {
        public DataContext Context
        {
            get
            {
                return (DataContext)_context;
            }
        }

        public CitiesRepository(DataContext Context) : base(Context)
        {
        }
    }
}