using WaCollaborative.Domain.Entities;
using WaCollaborative.Infrastructure.Data;

namespace WaCollaborative.Infrastructure.Repositories
{
    public class MeasurementUnitsRepository : BaseRepository<MeasurementUnit>, IMeasurementUnitsRepository
    {
        public DataContext Context
        {
            get
            {
                return (DataContext)_context;
            }
        }

        public MeasurementUnitsRepository(DataContext Context) : base(Context)
        {
        }
    }
}