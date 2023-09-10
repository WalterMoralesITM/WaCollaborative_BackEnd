namespace WaCollaborative.Infrastructure.Repositories
{
    using WaCollaborative.Domain.Entities;
    using WaCollaborative.Infrastructure.Data;

    public class StatusRepository : BaseRepository<Status>, IStatusRepository
    {
        public DataContext Context
        {
            get
            {
                return (DataContext)_context;
            }
        }

        public StatusRepository(DataContext Context) : base(Context)
        {
        }
    }
}