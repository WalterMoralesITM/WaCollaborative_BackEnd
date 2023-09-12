using Microsoft.EntityFrameworkCore;
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

        public override async Task<IEnumerable<Country>> GetAsync()
        {
            return await _context.Countries.Include(c => c.States).ToListAsync();
        }

        public override async Task<Country> GetAsync(int id)
        {
            Country? country = await _entity.Include(c => c.States!)
                                            .ThenInclude(s=>s.Cities!)
                                            .FirstOrDefaultAsync(c => c.Id! == id);
            return country!;
            
        }
    }
}