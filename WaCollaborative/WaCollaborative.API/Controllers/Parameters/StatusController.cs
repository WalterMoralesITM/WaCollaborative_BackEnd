namespace WaCollaborative.API.Controllers.Parameters
{

    #region Import

    using Microsoft.AspNetCore.Mvc;
    using System.Net;
    using WaCollaborative.API.Response;
    using WaCollaborative.Application.Common.DTO;
    using WaCollaborative.Application.Common.Constants;
    using WaCollaborative.Domain.Common.DTO;
    using WaCollaborative.Application.Common.Interfaces.Services;
    using WaCollaborative.Domain.Entities;

    #endregion Import

    /// <summary>
    /// The controller StatusController
    /// </summary>

    [Route("api/status")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        #region Attributes

        private readonly IStatusServices _statusServices;

        #endregion Attributes

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="statusServices"></param>
        public StatusController(IStatusServices statusServices)
        {
            _statusServices = statusServices;
        }

        #endregion Constructor

        #region Methods

        /// <summary>
        /// Method List All Status
        /// </summary>
        /// <returns>ResponseDTO<List<StatusDTO>></returns>
        [HttpGet]        
        public async Task<ActionResult<ResponseDTO<List<StatusDTO>>>> GetStatus()
        {
            try {
                List<StatusDTO> status = await _statusServices.GetStatus();
                var response = new ResponseDTO<List<StatusDTO>>
                {
                    Code = status != null && status.Any() ? (int)HttpStatusCode.OK : (int)HttpStatusCode.NotFound,                    
                    Message = status != null && status.Any() ? Messages.FOUND : Messages.NOTFOUND,
                    Response = status != null && status.Any() ? status : new List<StatusDTO>()
                };
                return Ok(response);
            }
            catch (Exception ex)
            {
                var responseError = ApiResponse<StatusDTO>.CreateError(ex.Message);
                return BadRequest(responseError);
            }
        }

        /// <summary>
        /// Method Get By Id 
        /// </summary>
        /// <param name="statusDTO"></param>
        /// <returns>ResponseDTO<StatusDTO></returns>        
        [HttpGet("{id:int}")]
        public async Task<ActionResult<ResponseDTO<StatusDTO>>> GetStatusById(int id)
        {
            try
            {
                StatusDTO status = await _statusServices.GetStatusById(id);
                var response = new ResponseDTO<StatusDTO>
                {
                    Code = status != null && status != null && status.Id > 0 ? (int)HttpStatusCode.OK : (int)HttpStatusCode.NotFound,
                    Message = status != null && status != null && status.Id > 0 ? Messages.FOUND : Messages.NOTFOUND,
                    Response = status != null && status != null && status.Id > 0 ? status : new StatusDTO()
                };
                return Ok(response);
            }
            catch (Exception ex)
            {
                var responseError = ApiResponse<StatusDTO>.CreateError(ex.Message);
                return BadRequest(responseError);
            }
        }

        /// <summary>
        /// Method Save
        /// </summary>
        /// <param name="statusDTO"></param>
        /// <returns>ResponseDTO<StatusDTO></returns>
        [HttpPost]        
        public async Task<ActionResult<ResponseDTO<StatusDTO>>> SaveStatus([FromBody] StatusDTO statusDTO)
        {
            try
            {
                StatusDTO save = await _statusServices.SaveStatus(statusDTO);
                var response = new ResponseDTO<StatusDTO>
                {
                    Code = save != null && save.Id > 0 ? (int)HttpStatusCode.OK : (int)HttpStatusCode.NotFound,
                    Message = save != null && save.Id > 0 ? Messages.SAVE : Messages.NOTSAVE,
                    Response = save != null && save.Id > 0 ? save : new StatusDTO()
                };
                return Ok(response);
            }
            catch (Exception ex)
            {
                var responseError = ApiResponse<StatusDTO>.CreateError(ex.Message);
                return BadRequest(responseError);
            }
        }

        /// <summary>
        /// Method Update
        /// </summary>
        /// <param name="statusDTO"></param>
        /// <returns>ResponseDTO<StatusDTO></returns>
        [HttpPut("{id}")]
        public async Task<ActionResult<ResponseDTO<StatusDTO>>> UpdateStatus(int id, [FromBody] StatusDTO statusDTO)
        {
            StatusDTO update;
            StatusDTO findUpdate;
            try
            {
                findUpdate = await _statusServices.GetStatusById(id);
                if (findUpdate.Id == 0)
                {
                    update = statusDTO;
                }
                else {
                    statusDTO.Id = findUpdate.Id;
                    update = await _statusServices.UpdateStatus(statusDTO);
                }                 
                var response = new ResponseDTO<StatusDTO>
                {
                    Code = update != null && update.Id > 0 ? (int)HttpStatusCode.OK : (int)HttpStatusCode.NotFound,
                    Message = update != null && update.Id > 0 ? Messages.UPDATE : Messages.NOTUPDATE,
                    Response = update != null && update.Id > 0 ? update : new StatusDTO()
                };
                return Ok(response);
            }
            catch (Exception ex)
            {
                var responseError = ApiResponse<StatusDTO>.CreateError(ex.Message);
                return BadRequest(responseError);
            }
        }

        #endregion Methods

    }
}