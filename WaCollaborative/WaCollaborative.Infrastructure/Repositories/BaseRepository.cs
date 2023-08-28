namespace WaCollaborative.Infrastructure.Repositories
{

    #region Import

    using Microsoft.EntityFrameworkCore;
    using System.Linq.Expressions;
    using WaCollaborative.Application.Common.Interfaces.Repository;

    #endregion Import

    /// <summary>
    /// The class BaseRepository
    /// </summary>

    public class BaseRepository<T> : IRepository<T> where T : class
    {

        #region Attributes

        protected DbSet<T> entities;

        #endregion Attributes

        #region Constructor

        /// <summary>
        /// Constructor Default
        /// </summary>
        /// <param name="dbContext"></param>
        public BaseRepository(DbContext dbContext)
        {
            entities = dbContext.Set<T>();
        }

        #endregion Constructor

        #region Methods

        /// <summary>
        /// Method List
        /// </summary>
        /// <returns>List<T></returns>
        public async Task<List<T>> GetAll()
        {
            return await entities.ToListAsync();
        }

        /// <summary>
        /// Method List T By Expression
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns>List<T></returns>
        public async Task<List<T>> GetAll(Expression<Func<T, bool>> predicate)
        {
            return await entities.Where(predicate).ToListAsync();
        }

        /// <summary>
        /// Method T By ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>T</returns>
        public async Task<T> GetById(int id) => await entities.FindAsync(id);

        /// <summary>
        ///Method T By Expression
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns>T</returns>
        public async Task<T> Get(Expression<Func<T, bool>> predicate)
        {
            return await entities.Where(predicate).FirstOrDefaultAsync();
        }

        /// <summary>
        /// Method Save
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>T</returns>
        public async Task Add(T entity)
        {
            await entities.AddAsync(entity);
        }

        /// <summary>
        /// Method Update
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>T</returns>
        public async Task Update(T entity)
        {
            entities.Update(entity);
        }

        /// <summary>
        /// Method Count
        /// </summary>
        /// <returns>T</returns>
        public async Task<int> CountRecord()
        {
            return await entities.CountAsync();
        }

        #endregion Methods

    }
}