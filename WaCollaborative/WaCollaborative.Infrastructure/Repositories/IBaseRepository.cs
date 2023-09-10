namespace WaCollaborative.Infrastructure.Repositories
{
    public interface IBaseRepository<TEntity>
    {
        Task<TEntity> GetAsync(int id);

        Task<IEnumerable<TEntity>> GetAsync();

        Task<TEntity> AddAsync(TEntity entity);

        Task DeleteAsync(int id);

        Task<TEntity> UpdateAsync(TEntity entity);
    }
}