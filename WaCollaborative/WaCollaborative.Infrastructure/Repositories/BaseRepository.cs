namespace WaCollaborative.Infrastructure.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using WaCollaborative.Infrastructure.Data;

    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected DataContext _context;
        protected DbSet<TEntity> _entity;

        public BaseRepository(DataContext context)
        {
            _context = context;
            _entity = context.Set<TEntity>();
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            _context.Add(entity);

            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            var row = await _entity.FindAsync(id);
            if (row != null)
            {
                _entity.Remove(row);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<TEntity> GetAsync(int id)
        {
            var row = await _entity.FindAsync(id);
            return row!;
        }

        public async Task<IEnumerable<TEntity>> GetAsync()
        {
            return await _entity.ToListAsync();
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}