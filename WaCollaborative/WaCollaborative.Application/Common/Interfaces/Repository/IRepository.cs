namespace WaCollaborative.Application.Common.Interfaces.Repository
{

    #region Import

    using System.Linq.Expressions;

    #endregion Import

    /// <summary>
    /// The interface IRepository
    /// </summary>

    public interface IRepository<T> where T : class
    {

        #region Methods

        /// <summary>
        /// Method List
        /// </summary>
        /// <returns>List<T></returns>
        Task<List<T>> GetAll();

        /// <summary>
        /// Method List By Expression
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns>List<T></returns>
        Task<List<T>> GetAll(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Method T By ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>T</returns>
        Task<T> GetById(int id);

        /// <summary>
        /// Method T By Expression
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns>T</returns>
        Task<T> Get(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Method Save
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>T</returns>
        Task Add(T entity);

        /// <summary>
        /// Method Update
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>T</returns>
        Task Update(T entity);

        /// <summary>
        /// Method Count
        /// </summary>
        /// <returns>int</returns>
        Task<int> CountRecord();

        #endregion Methods

    }
}