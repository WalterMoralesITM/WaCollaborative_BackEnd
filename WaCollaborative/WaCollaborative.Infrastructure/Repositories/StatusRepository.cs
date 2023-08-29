namespace WaCollaborative.Infrastructure.Repositories
{

    #region Import

    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using WaCollaborative.Application.Common.Interfaces.Repository;
    using WaCollaborative.Domain.Common.DTO;
    using WaCollaborative.Domain.Entities;
    using WaCollaborative.Infrastructure.Data;

    #endregion Import

    /// <summary>
    /// The class IStatusRepository
    /// </summary>

    public class StatusRepository : BaseRepository<Status>, IStatusRepository
    {

        #region Attributes

        private readonly DataContext _context;

        #endregion Attributes

        #region Constructor

        public StatusRepository(DataContext context) : base(context)
        {
            _context = context;         
        }

        #endregion Constructor

        #region Methods

        /// <summary>
        /// Method Get List Status
        /// </summary>
        /// <returns>List<StatusDTO></returns>      
        public async Task<List<StatusDTO>> GetStatus()
        {
            List<Status> statusList = await _context.Status.ToListAsync();
            List<StatusDTO> list = new();
            foreach (Status item in statusList)
            {                
                list.Add(StatusDTO.EntityMapStatusDTO(item));
            }
            return list;
        }

        /// <summary>
        /// Method Get By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>StatusDTO</returns>        
        public async Task<StatusDTO> GetStatusById(int id)
        {
            Status statusSearch = await _context.Status.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (statusSearch == null)
            {
                return new StatusDTO();
            }
            else {
                return StatusDTO.EntityMapStatusDTO(statusSearch);
            }            
        }

        /// <summary>
        /// Method Get By Name
        /// </summary>
        /// <param name="name"></param>
        /// <returns>StatusDTO</returns>        
        public async Task<StatusDTO> GetStatusByName(string name)
        {
            Status statusSearch = await _context.Status.Where(x => x.Name.ToUpper().Trim() == name.ToUpper().Trim()).FirstOrDefaultAsync();
            if (statusSearch == null)
            {
                return new StatusDTO();
            }
            else
            {
                return StatusDTO.EntityMapStatusDTO(statusSearch);
            }
        }

        /// <summary>
        /// Method Save Status
        /// </summary>
        /// <param name="statusDTO"></param>
        /// <returns>StatusDTO</returns>       
        public async Task<StatusDTO> SaveStatus(StatusDTO statusDTO)
        {
            Status save = StatusDTO.StatusDTOMapEntity(statusDTO);
            _context.Status.Add(save);
            await Task.Run(() => { _context.SaveChanges(); });
            return StatusDTO.EntityMapStatusDTO(save);
        }

        public async Task<StatusDTO> UpdateStatus(StatusDTO statusDTO)
        {
            Status search = await _context.Status.Where(x => x.Id == statusDTO.Id).FirstOrDefaultAsync();
            if (search != null)
            {
                search.Name = statusDTO.Name;
                search.Shortname = statusDTO.Shortname;
                await Task.Run(() => { _context.SaveChanges(); });
                return StatusDTO.EntityMapStatusDTO(search);
            }
            else {
                return new StatusDTO();
            }
        }

        #endregion Methods

    }
}