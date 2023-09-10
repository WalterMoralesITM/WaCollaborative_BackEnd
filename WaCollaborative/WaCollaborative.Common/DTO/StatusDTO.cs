namespace WaCollaborative.Common.DTO
{
    #region Import

    using WaCollaborative.Domain.Entities;

    #endregion Import

    /// <summary>
    /// The class DTO StatusDTO
    /// </summary>

    public class StatusDTO
    {
        #region Attributes

        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Shortname { get; set; } = null!;

        #endregion Attributes



        #region Methods

        /// <summary>
        /// Method Convert DTO to Entity
        /// </summary>
        /// <param name="status"></param>
        /// <returns>Status</returns>
        public static Status StatusDTOMapEntity(StatusDTO status)
        {
            return new Status()
            {
                Id = status.Id,
                Name = status.Name,
                Shortname = status.Shortname,
            };
        }

        /// <summary>
        /// Method Convert Entity to DTO
        /// </summary>
        /// <param name="status"></param>
        /// <returns>StatusDTO</returns>
        public static StatusDTO EntityMapStatusDTO(Status status)
        {
            return new StatusDTO()
            {
                Id = status.Id,
                Name = status.Name,
                Shortname = status.Shortname
            };
        }

        #endregion Methods
    }
}