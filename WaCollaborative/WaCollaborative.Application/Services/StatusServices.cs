namespace WaCollaborative.Application.Services
{

    #region Import

    using System.Collections.Generic;
    using System.Threading.Tasks;
    using WaCollaborative.Domain.Common.DTO;
    using WaCollaborative.Application.Common.Exceptions;
    using WaCollaborative.Application.Common.Interfaces;
    using WaCollaborative.Application.Common.Interfaces.Services;

    #endregion Import

    /// <summary>
    /// The clase StatusServices
    /// </summary>

    public class StatusServices : IStatusServices
    {
        #region Attributes

        private readonly IUnitOfWork _unitOfWork;

        #endregion Attributes

        #region Constructor

        public StatusServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        #endregion Constructor

        #region Methods

        /// <summary>
        /// Method Get List Status
        /// </summary>
        /// <returns>List<StatusDTO></returns>
        public async Task<List<StatusDTO>> GetStatus()
        {
            try
            {               
                return await _unitOfWork.StatusRepository.GetStatus();
            }
            catch (Exception ex)
            {
                throw new GeneralException(" Error " + ex.Message);
            }
        }

        /// <summary>
        /// Method Get By Id
        /// </summary>
        /// <param name="statusDTO"></param>
        /// <returns>StatusDTO</returns>        
        public async Task<StatusDTO> GetStatusById(StatusDTO statusDTO)
        {
            StatusDTO search;
            try
            {
                search = await _unitOfWork.StatusRepository.GetStatusById(statusDTO);
            }
            catch (Exception ex)
            {
                throw new GeneralException(" Error " + ex.Message);
            }
            return search;
        }

        /// <summary>
        /// Method Save Status
        /// </summary>
        /// <param name="statusDTO"></param>
        /// <returns>StatusDTO</returns>       
        public async Task<StatusDTO> SaveStatus(StatusDTO statusDTO)
        {
            StatusDTO save;
            try
            {
                save = await _unitOfWork.StatusRepository.SaveStatus(statusDTO);
            }
            catch (Exception ex)
            {
                throw new GeneralException(" Error " + ex.Message);
            }
            return save;
        }

        /// <summary>
        /// Method Update Status
        /// </summary>
        /// <param name="statusDTO"></param>
        /// <returns>StatusDTO</returns>       
        public async Task<StatusDTO> UpdateStatus(StatusDTO statusDTO)
        {
            StatusDTO update;
            try
            {
                update = await _unitOfWork.StatusRepository.UpdateStatus(statusDTO);
            }
            catch (Exception ex)
            {
                throw new GeneralException(" Error " + ex.Message);
            }
            return update;
        }

        #endregion Methods

    }
}