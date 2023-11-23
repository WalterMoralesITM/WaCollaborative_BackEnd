using WaCollaborative.Domain.Entities;
using WaCollaborative.Infrastructure.Data;

namespace WaCollaborative.Infrastructure.Repositories
{
    public class SegmentsRepository : BaseRepository<Segment>, ISegmentsRepository
    {
        public DataContext Context
        {
            get
            {
                return (DataContext)_context;
            }
        }

        public SegmentsRepository(DataContext Context) : base(Context)
        {
        }
    }
}