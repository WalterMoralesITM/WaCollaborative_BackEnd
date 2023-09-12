using Microsoft.EntityFrameworkCore;
using WaCollaborative.Domain.Entities;
using WaCollaborative.Infrastructure.Data;

namespace WaCollaborative.Infrastructure.Repositories
{
    public class StatesRepository : BaseRepository<State>, IStatesRepository
    {
        public DataContext Context
        {
            get
            {
                return (DataContext)_context;
            }
        }

        public StatesRepository(DataContext Context) : base(Context)
        {
        }

        public override async Task<IEnumerable<State>> GetAsync()
        {
            return await _context.States.Include(e => e.Cities).ToListAsync();
        }

        public override async Task<State> GetAsync(int id)
        {
            return await _entity.Include(c => c.Cities).Where(c => c.Id == id).FirstAsync();
        }
    }
}