namespace WaCollaborative.Application.Common.Interfaces
{

    #region Import

    using WaCollaborative.Application.Common.Interfaces.Repository;

    #endregion Import

    /// <summary>
    /// The interface IUnitOfWork
    /// </summary>

    public interface IUnitOfWork : IDisposable
    {

        #region Attributes

        IStatusRepository StatusRepository { get; }

        #endregion Attributes

        #region Methods

        /// <summary>
        /// Method Save Change
        /// </summary>
        void SaveChanges();

        /// <summary>
        /// Method Save Change Async
        /// </summary>
        /// <returns>int</returns>
        Task<int> SaveChangesAsync();

        #endregion Methods

    }
}