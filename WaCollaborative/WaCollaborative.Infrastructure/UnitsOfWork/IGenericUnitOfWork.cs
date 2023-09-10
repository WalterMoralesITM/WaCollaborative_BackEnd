namespace WaCollaborative.Infrastructure.UnitsOfWork
{
    public interface IGenericUnitOfWork<T> where T : class
    {
        Task<IEnumerable<T>> GetAsync();

        Task<T> AddAsync(T model);

        Task<T> UpdateAsync(T model);

        Task DeleteAsync(int id);

        Task<T> GetAsync(int id);
    }
}