using WaCollaborative.Infrastructure.Repositories;

namespace WaCollaborative.Infrastructure.UnitsOfWork
{
    public class GenericUnitOfWork<TEntity> : IGenericUnitOfWork<TEntity> where TEntity : class
    {
        #region Constructor

        private readonly IBaseRepository<TEntity> _repository;

        public GenericUnitOfWork(IBaseRepository<TEntity> repository)
        {
            _repository = repository;
        }

        #endregion Constructor

        #region Methods

        public async Task<TEntity> AddAsync(TEntity model) => await _repository.AddAsync(model);

        public async Task DeleteAsync(int id) => await _repository.DeleteAsync(id);

        public async Task<IEnumerable<TEntity>> GetAsync() => await _repository.GetAsync();

        public async Task<TEntity> GetAsync(int id) => await _repository.GetAsync(id);

        public async Task<TEntity> UpdateAsync(TEntity model) => await _repository.UpdateAsync(model);

        #endregion Methods
    }
}