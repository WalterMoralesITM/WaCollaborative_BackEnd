namespace WaCollaborative.Infrastructure.Repositories
{

    #region Import

    using WaCollaborative.Application.Common.Interfaces;
    using WaCollaborative.Application.Common.Interfaces.Repository;
    using WaCollaborative.Infrastructure.Data;

    #endregion Import

    /// <summary>
    /// The class UnitOfWork
    /// </summary>

    public class UnitOfWork : IUnitOfWork
    {

        #region Attributes

        private readonly DataContext _DBContext;

        #endregion Attributes

        #region Constructor

        public UnitOfWork(DataContext dBContext)
        {
            _DBContext = dBContext;
        }

        public IStatusRepository StatusRepository => new StatusRepository(_DBContext);

        #endregion Constructor

        #region Injection

        #endregion Injection

        #region Methods

        /// <summary>
        /// Metodo que dispone la conexión
        /// </summary>
        public void Dispose()
        {
            GC.SuppressFinalize(this);
            if (_DBContext != null)
            {
                _DBContext.Dispose();
            }
        }

        /// <summary>
        /// Metodo para guardar los cambios
        /// </summary>
        public void SaveChanges()
        {
            _DBContext.SaveChanges();
        }

        /// <summary>
        /// Metodo Asincronicos para guardar los cambios
        /// </summary>
        /// <returns></returns>
        public async Task<int> SaveChangesAsync()
        {
            return await _DBContext.SaveChangesAsync();
        }
                
        #endregion Methods

    }
}