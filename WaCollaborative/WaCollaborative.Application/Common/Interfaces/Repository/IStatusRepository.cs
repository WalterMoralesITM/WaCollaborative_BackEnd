namespace WaCollaborative.Application.Common.Interfaces.Repository
{

    #region Import

    using WaCollaborative.Common.DTO;

    #endregion Import

    /// <summary>
    /// The interface IStatusRepository
    /// </summary>

    public interface IStatusRepository
    {

        #region Methods

        /// <summary>
        /// Method List Status
        /// </summary>
        /// <returns>List<StatusDTO></returns>
        public Task<List<StatusDTO>> GetStatus();

        /// <summary>
        /// Method Get Status By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>StatusDTO</returns>
        public Task<StatusDTO> GetStatusById(int id);

        /// <summary>
        /// Method Get Status By Name
        /// </summary>
        /// <param name="name"></param>
        /// <returns>StatusDTO</returns>
        public Task<StatusDTO> GetStatusByName(string name);

        /// <summary>
        /// Method Save Status
        /// </summary>
        /// <param name="statusDTO"></param>
        /// <returns>StatusDTO</returns>
        public Task<StatusDTO> SaveStatus(StatusDTO statusDTO);

        /// <summary>
        /// Method Update Status
        /// </summary>
        /// <param name="statusDTO"></param>
        /// <returns>StatusDTO</returns>
        public Task<StatusDTO> UpdateStatus(StatusDTO statusDTO);

        #endregion Methods

    }
}